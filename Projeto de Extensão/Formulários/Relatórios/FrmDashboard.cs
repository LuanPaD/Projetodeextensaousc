using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Admnistrativo;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Projeto_de_Extensao.Formulários.Cadastros;
using System.Web;
using System.Data.SqlTypes;
using Microsoft.VisualBasic.Logging;
using SixLabors.Fonts;

namespace Projeto_de_Extensao.Formulários.Relatórios
{
    public partial class FrmDashboard : Form
    {
        MySqlConnection conexao = ClsConexao.Conexao;
        string tipoDeRelatorio = String.Empty;
        private DateTime DataPerguntaInical;
        private DateTime DataFinalPerguntaInical;
        private int id_pergunta = 0;

        public FrmDashboard()
        {
            InitializeComponent();
            preencheStaticValues();


        }

        private void btnDashboard_Click(object sender, EventArgs e) => tbcDashboard.SelectedTab = tabPageDashboard;

        private async void btnPerguntas_Click(object sender, EventArgs e)
        {
            await FrmCadastros.ListaTodosOsSetoresAsync(cmbSetoresPerguntas);
            tbcDashboard.SelectedTab = tabPagePerguntas;
        }

        private void EstilizaGrid(DataGridView grid)
        {
            // Remover o cabeçalho das linhas (linha lateral)
            grid.RowHeadersVisible = false;

            // Remover a borda entre as células
            grid.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Estilo para células padrão
            grid.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            grid.DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
            grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;

            // Estilo para o fundo do DataGridView
            grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            grid.GridColor = System.Drawing.Color.LightSlateGray;

            // Estilo para cabeçalhos de coluna
            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Brown;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(grid.Font.FontFamily, 12, System.Drawing.FontStyle.Bold);

            // Desabilitar o estilo visual padrão do cabeçalho (para permitir personalização)
            grid.EnableHeadersVisualStyles = false;

            // Ajuste automático das colunas
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Impede a linha de adicionar dados ao final
            grid.AllowUserToAddRows = false;


        }



        #region Funções 

        private void carregaGraficos()
        {
            try
            {
                //Gráfico : Distribuição de Atendentes por Setor
                chtGrafico1.Series.Clear();
                chtGrafico1.Series.Add("Atendentes por Setor");
                chtGrafico1.Series["Atendentes por Setor"].ChartType = SeriesChartType.Pie;
                chtGrafico1.Series["Atendentes por Setor"].IsXValueIndexed = true;

                string querySetores = @"
                    SELECT setores.nome AS setor_nome, COUNT(atendente.atendente_id) AS total
                    FROM setores
                    LEFT JOIN atendente ON atendente.setor_id = setores.setor_id
                    GROUP BY setores.nome;";

                var commandSetores = new MySqlCommand(querySetores, conexao);
                var readerSetores = commandSetores.ExecuteReader();

                while (readerSetores.Read())
                {
                    string setorNome = readerSetores["setor_nome"].ToString();
                    int total = Convert.ToInt32(readerSetores["total"]);
                    chtGrafico1.Series["Atendentes por Setor"].Points.AddXY(setorNome, total);
                }
                readerSetores.Close();

                if (chtGrafico1.Series["Atendentes por Setor"].Points.Count == 0)
                {
                    chtGrafico1.Series["Atendentes por Setor"].Points.AddXY("Nenhum Atendente", 0);
                }

                chtGrafico1.Titles.Clear();
                chtGrafico1.Titles.Add("Atendentes por Setor");
                chtGrafico1.Series["Atendentes por Setor"].Color = Color.Brown;

            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao obter dados: " + err.Message);
            }
        }


        private async void preencheStaticValues()
        {
            int totalAdministradores = GetTotal("SELECT COUNT(ADMIN_ID) FROM ADMIN");
            int totalAtendentesAvaliados = GetTotal("SELECT COUNT(DISTINCT ATENDENTE_ID) FROM AVALIACAO;");
            int totalSetores = GetTotal("SELECT COUNT(SETOR_ID) FROM SETORES;");
            int totalAvaliacoes = GetTotal("SELECT COUNT(avaliacao_id) FROM AVALIACAO; ");

            lblTotalAtendentesAvaliados.Text = totalAtendentesAvaliados.ToString();
            lblTotalSetoresCadastrados.Text = totalSetores.ToString();
            lblTotalDeAvaliacoes.Text = totalAvaliacoes.ToString();
            lblTotalAdmin.Text = totalAdministradores.ToString();

            await FrmCadastros.ListaTodosOsSetoresAsync(cmbSetores);
            carregaGraficos();

        }

        private int GetTotal(string query)
        {
            var command = new MySqlCommand(query, conexao);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private DataTable GetData()
        {
            DataTable dados = new DataTable();
            string tipoDeRelatorio = cmbTipoRelatorio.Text;

            if (string.IsNullOrEmpty(tipoDeRelatorio) || string.IsNullOrWhiteSpace(tipoDeRelatorio))
            {
                MessageBox.Show("Escolha um tipo de Relatório", "Aviso");
                return dados;
            }

            if (tipoDeRelatorio == "Avaliações")
            {
                dados = getAvaliacoes();
            }

            if (tipoDeRelatorio == "Admnistradores")
            {
                dados = getAdmnistradores();
            }

            if (tipoDeRelatorio == "Atendentes")
            {
                dados = getAtendentes();
            }
            return dados;
        }

        private DataTable getAvaliacoes()
        {
            var conexao = ClsConexao.Conexao; // Obtém a conexão global gerenciada
            DataTable avaliacoes = new DataTable();
            bool filtrarPeriodo = chkPeriodo.Checked;
            bool filtrarSetor = chkSetor.Checked;
            string setor = cmbSetores.Text;

            try
            {
                string queryAvaliacoes = @"
                SELECT 
                    S.nome, 
                    P.texto AS 'Pergunta', 
                    O.texto AS 'Opção Escolhida', 
                    A.data 
                FROM AVALIACAO A
                INNER JOIN RESPOSTAS R ON R.avaliacao_id = A.avaliacao_id 
                INNER JOIN PERGUNTAS P ON P.pergunta_id = R.pergunta_id
                INNER JOIN OPCOES O ON O.pergunta_id = P.pergunta_id
                INNER JOIN SETORES S ON S.setor_id = A.setor_id";

                List<string> condicoes = new List<string>();
                var command = new MySqlCommand(queryAvaliacoes, conexao);

                if (filtrarSetor && !string.IsNullOrWhiteSpace(setor))
                {
                    condicoes.Add("A.setor_id = (SELECT setor_id FROM SETORES WHERE nome = @setor)");
                    command.Parameters.AddWithValue("@setor", setor);
                }

                if (filtrarPeriodo)
                {
                    condicoes.Add("A.data BETWEEN @dataInicio AND @dataFinal");
                    command.Parameters.AddWithValue("@dataInicio", DateTime.Parse(dtDataInicio.Text));
                    command.Parameters.AddWithValue("@dataFinal", DateTime.Parse(dtDataFinal.Text));
                }

                if (condicoes.Count > 0)
                {
                    queryAvaliacoes += " WHERE " + string.Join(" AND ", condicoes);
                }

                command.CommandText = queryAvaliacoes;

                using (var readerAvaliacoes = command.ExecuteReader())
                {
                    avaliacoes.Load(readerAvaliacoes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados: " + ex.Message);
            }

            return avaliacoes;
        }



        private DataTable getAtendentes()
        {
            var conexao = ClsConexao.Conexao;
            DataTable atendentes = new DataTable();
            try
            {
                string queryAtendentes = @"SELECT a.NOME, S.NOME AS 'SETOR', a.EMAIL FROM ATENDENTE A INNER JOIN SETORES S ON S.setor_id = A.setor_id;";
                var commandAtendentes = new MySqlCommand(queryAtendentes, conexao);
                var readerAtendentes = commandAtendentes.ExecuteReader();

                atendentes.Load(readerAtendentes);
                readerAtendentes.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados: " + ex.Message);
            }

            return atendentes;
        }

        private DataTable getAdmnistradores()
        {
            var conexao = ClsConexao.Conexao;
            DataTable admins = new DataTable();
            try
            {
                string queryAdminsDistribuicao = @"SELECT NOME, EMAIL FROM ADMIN;";
                var commandAdmin = new MySqlCommand(queryAdminsDistribuicao, conexao);
                var readerAdmins = commandAdmin.ExecuteReader();

                admins.Load(readerAdmins);
                readerAdmins.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados: " + ex.Message);
            }

            return admins;
        }

        private async void FiltraSugestao(DateTime dataInicial, DateTime dataFinal, int? setorId)
        {

            dataInicial = dataInicial.Date;
            dataFinal = dataFinal.Date.AddDays(1).AddSeconds(-1);

            string sql = @"SELECT a.data, s.nome AS setor, a.sugestao
                   FROM sugestoes a
                   JOIN setores s ON a.setor_id = s.setor_id
                   WHERE a.data BETWEEN @dataInicial AND @dataFinal";

            if (setorId.HasValue)
            {
                sql += " AND s.setor_id = @setorId";
            }

            using (var conexao = new MySqlConnection(ClsConexao.connectionString))
            {
                using (var comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@dataInicial", dataInicial);
                    comando.Parameters.AddWithValue("@dataFinal", dataFinal);

                    if (setorId.HasValue)
                    {
                        comando.Parameters.AddWithValue("@setorId", setorId.Value);
                    }

                    await conexao.OpenAsync();
                    using (var reader = await comando.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        EstilizaGrid(gridSugestoesDash);
                        gridSugestoesDash.DataSource = dt;
                    }
                }
            }
        }

        private async void FiltraSetorPerguntas(int? setorId)
        {

            string sql = $@"SELECT pergunta_id,texto FROM perguntas
            WHERE setor_id = {setorId} 
            order by ordem;";
            await FrmEditarCadastroscs.CarregarDadosAsync(sql, GridPerguntasRelatorio, "pergunta_id");
        }

        #endregion

        #region Eventos

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            var excelExporter = new EXCELgerador();
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            string filePath = Path.Combine(downloadsPath, "Relatorio.xlsx");
            DataTable data = GetData();

            if (data != null )
            {
                if (data.Rows.Count > 0)
                {
                    excelExporter.Export(data, filePath);
                    MessageBox.Show("Arquivo Excel gerado com sucesso em:\n" + filePath);
                }
                else
                {
                    MessageBox.Show("Nenhum dado disponível para exportar.");
                }
            }
            
        }


        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            var pdfExporter = new PDFgerador();
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            string filePath = Path.Combine(downloadsPath, "Relatorio.pdf");
            DataTable data = GetData();

            if (data != null)
            {
                if (data.Rows.Count > 0)
                {
                    pdfExporter.Export(data, filePath);
                    MessageBox.Show("Arquivo PDF gerado com sucesso em:\n" + filePath);
                }
                else
                {
                    MessageBox.Show("Nenhum dado disponível para exportar.");
                }
            }
        }


        #endregion

        private void btnVoltarParaMenu_Click(object sender, EventArgs e)
        {
            FrmEscolhaInicial frmEscolhaInicial = new FrmEscolhaInicial();
            frmEscolhaInicial.ShowDialog();
            this.Hide();
        }

        private async void btnSugestoes_Click(object sender, EventArgs e)
        {
            tbcDashboard.SelectedTab = tabPageSugestoes;

            await FrmCadastros.ListaTodosOsSetoresAsync(cmbSetoresSugestoes);
        }

        private void btnCarregarSetoresSugestao_Click(object sender, EventArgs e)
        {
            if (dataInicialSugestoes.Value == DateTime.MinValue || dataFinalSugestoes.Value == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, selecione ambas as datas (inicial e final).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataFinalSugestoes.Value < dataInicialSugestoes.Value)
            {
                MessageBox.Show("A data final não pode ser anterior à data inicial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataInicial = dataInicialSugestoes.Value;
            DateTime dataFinal = dataFinalSugestoes.Value;

            int setorId = (int)cmbSetoresSugestoes.SelectedValue;

            FiltraSugestao(dataInicial, dataFinal, setorId == 0 ? null : setorId);
        }


        private void GerarGraficoRespostas(int perguntaId, DateTime dataInicial, DateTime dataFinal)
        {
            // Verifica se o ID da pergunta é válido
            if (perguntaId <= 0)
            {
                MessageBox.Show("Selecione uma pergunta válida antes de gerar o gráfico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Configurando o SQL para contar respostas por opção
            string sql = @"
                SELECT o.opcao_id, o.texto, COUNT(r.resposta_id) AS total_respostas
                FROM opcoes o
                LEFT JOIN respostas r ON o.opcao_id = r.opcao_id
                LEFT JOIN avaliacao a ON r.avaliacao_id = a.avaliacao_id
                WHERE o.pergunta_id = @perguntaId 
                  AND a.data BETWEEN @dataInicio AND @dataFim
                GROUP BY o.opcao_id, o.texto
                ORDER BY o.opcao_id;
            ";

            try
            {
                // Criar conexão com o banco de dados
                using (var conexao = new MySqlConnection(ClsConexao.connectionString))
                {
                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        // Adicionar os parâmetros ao comando
                        comando.Parameters.AddWithValue("@perguntaId", perguntaId);
                        comando.Parameters.AddWithValue("@dataInicio", dataInicial);
                        comando.Parameters.AddWithValue("@dataFim", dataFinal);

                        // Abrir a conexão
                        conexao.Open();

                        using (var reader = comando.ExecuteReader())
                        {
                            // Preparar o gráfico
                            chartGraficoRespostas.Series.Clear();
                            var series = chartGraficoRespostas.Series.Add("Respostas");
                            series.ChartType = SeriesChartType.Column;
                            series.IsXValueIndexed = true;
                            chartGraficoRespostas.Titles.Clear();

                            // Adicionar os pontos ao gráfico
                            while (reader.Read())
                            {
                                string descricaoOpcao = reader["texto"]?.ToString() ?? "Opção desconhecida";
                                int totalRespostas = reader["total_respostas"] != DBNull.Value
                                    ? Convert.ToInt32(reader["total_respostas"])
                                    : 0;

                                series.Points.AddXY(descricaoOpcao, totalRespostas);
                            }

                            // Estilização do gráfico
                            series.Color = Color.Brown;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibir erro em caso de falha
                MessageBox.Show($"Erro ao gerar gráfico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltraSetorPergunta_Click(object sender, EventArgs e)
        {
            if (dataInicialPerguntas.Value == DateTime.MinValue || dataFinalPergunta.Value == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, selecione ambas as datas (inicial e final).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataPerguntaInical = dataInicialPerguntas.Value.Date;
            DataFinalPerguntaInical = dataFinalPergunta.Value.Date.AddDays(1).AddSeconds(-1);

            if (DataFinalPerguntaInical < DataPerguntaInical)
            {
                MessageBox.Show("A data final não pode ser anterior à data inicial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbSetoresPerguntas.SelectedValue == null || (int)cmbSetoresPerguntas.SelectedValue == 0)
            {
                MessageBox.Show("Para prosseguir, você precisa escolher um setor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int setor_id = (int)cmbSetoresPerguntas.SelectedValue;

            FiltraSetorPerguntas(setor_id);
            chartGraficoRespostas.Series.Clear();
        }

        private void gridSugestoesDash_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var row = GridPerguntasRelatorio.Rows[e.RowIndex];

                    lblPergunta.Text = row.Cells["texto"]?.Value?.ToString() ?? "Texto não encontrado";

                    if (row.Cells["pergunta_id"]?.Value != null &&
                        int.TryParse(row.Cells["pergunta_id"].Value.ToString(), out int perguntaId))
                    {
                        id_pergunta = perguntaId;
                    }
                    else
                    {
                        MessageBox.Show("ID da pergunta inválido ou ausente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        id_pergunta = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao processar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGerarGrafico_Click(object sender, EventArgs e)
        {
            // Validar as datas antes de gerar o gráfico
            if (DataPerguntaInical == DateTime.MinValue || DataFinalPerguntaInical == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, selecione as datas antes de gerar o gráfico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gerar o gráfico
            GerarGraficoRespostas(id_pergunta, DataPerguntaInical, DataFinalPerguntaInical);
        }


        private void button3_Click(object sender, EventArgs e) => this.Hide();

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            bool filtrarPeriodo = chkPeriodo.Checked;

            dtDataInicio.Enabled = filtrarPeriodo;
            dtDataFinal.Enabled = filtrarPeriodo;
        }

        private void chkSetor_CheckedChanged(object sender, EventArgs e)
        {
            bool filtrarSetor = chkSetor.Checked;

            cmbSetores.Enabled = filtrarSetor;
        }

        private void cmbTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDeRelatorio = cmbTipoRelatorio.Text;

            if (tipoDeRelatorio.Equals("Avaliações"))
                mostraFiltrosPeriodos(true);
            else
                mostraFiltrosPeriodos(false);
        }

        private void mostraFiltrosPeriodos(bool mostrar)
        {
            List<Control> campos = new List<Control>
            {
                lblPeriodo,   
                lblAte,
                lblSetor,      
                dtDataFinal,
                dtDataInicio,
                chkPeriodo,
                chkSetor,
                cmbSetores,
            };

            foreach (Control campo in campos)
            {
                campo.Visible = mostrar;
            }

        }
    }
}
