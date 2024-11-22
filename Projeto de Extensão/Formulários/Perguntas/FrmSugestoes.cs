using MySqlConnector;
using Projeto_de_Extensao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Extensao.Formulários.Perguntas
{
    public partial class FrmSugestoes : Form
    {
        private string setorSelecionado;
        public FrmSugestoes(string setorSelecionado)
        {
            InitializeComponent();
            this.setorSelecionado = setorSelecionado;
        }

        private void btnFinalizarAvaliacao_Click(object sender, EventArgs e)
        {
            if (txtSugestao.Text != string.Empty) 
            { 
                InsereSugestao(txtSugestao.Text);
            }

            FrmAgradecimento frmAgradecimento = new FrmAgradecimento();
            frmAgradecimento.ShowDialog();
            this.Hide();
        }





        private async void InsereSugestao(string sugestao)
        {
            DateTime dataAtual = DateTime.Now;
            string dataFormatada = dataAtual.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = @"
            INSERT INTO sugestoes (setor_id, data, sugestao)
            VALUES ((SELECT setor_id FROM setores WHERE nome = @setor), @data, @sugestao);
            SELECT LAST_INSERT_ID();";

            try
            {
                using (var conexao = new MySqlConnection(ClsConexao.connectionString))
                {
                    await conexao.OpenAsync();

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@setor", setorSelecionado);
                        cmd.Parameters.AddWithValue("@data", dataFormatada);
                        cmd.Parameters.AddWithValue("@sugestao", sugestao);

                        await cmd.ExecuteScalarAsync();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("[Informe o Administrador] - Erro ao salvar avaliação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }





    }
}

