using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Extensao.Formulários.Perguntas
{
    public partial class FrmEscolhaSetorAvaliacao : Form
    {
        public FrmEscolhaSetorAvaliacao()
        {
            InitializeComponent();
            CustomizeListBox();
            CarregarLista();
        }

        private void CustomizeListBox()
        {
            // Configurações visuais do ListBox
            lstItems.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Fonte mais elegante e legível
            lstItems.ForeColor = Color.White;
            lstItems.BackColor = Color.FromArgb(60, 20, 20); // Cor de fundo mais suave
            lstItems.BorderStyle = BorderStyle.FixedSingle;
            lstItems.ItemHeight = 60; // Aumento da altura dos itens para mais espaço
            lstItems.DrawMode = DrawMode.OwnerDrawFixed; // Habilita o modo de desenho customizado
            lstItems.DrawItem += LstItems_DrawItem; // Associa o evento de desenho
        }

        private async void CarregarLista()
        {
            lstItems.Items.Clear(); // Certifique-se de limpar a lista antes de carregar novos itens

            var itens = await getSetor();
            lstItems.Items.AddRange(itens);
        }

        private void LstItems_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lstItems.Items.Count)
                return;

            e.DrawBackground(); // Desenha o fundo padrão
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Definindo cores mais harmoniosas para o fundo e texto
            Color bgColor = isSelected ? Color.Firebrick : (e.Index % 2 == 0 ? Color.IndianRed : Color.LightCoral);
            Color textColor = isSelected ? Color.White : Color.Black;

            // Preenchendo o fundo com a cor definida
            using (SolidBrush backgroundBrush = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);

            // Definindo padding para o texto não ficar colado nas bordas
            const int padding = 10;
            string itemText = lstItems.Items[e.Index].ToString();

            // Calcula o tamanho do texto
            SizeF textSize = e.Graphics.MeasureString(itemText, e.Font);

            // Calcula a posição do texto centralizado
            float x = e.Bounds.Left + (e.Bounds.Width - textSize.Width) / 2;
            float y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            // Desenhando o texto centralizado com a cor apropriada
            using (SolidBrush textBrush = new SolidBrush(textColor))
                e.Graphics.DrawString(itemText, e.Font, textBrush, x, y);

            e.DrawFocusRectangle(); // Desenha a borda de foco se o item estiver selecionado
        }

        private async Task<string[]> getSetor()
        {
            var nomeSetor = new List<string>();
            string sql = @"SELECT nome FROM setores;";

            try
            {
                using (var connection = new MySqlConnection(ClsConexao.connectionString))
                {
                    await connection.OpenAsync();

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                nomeSetor.Add(reader.GetString("nome"));
                            }
                        }
                    }
                }
                return nomeSetor.ToArray();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao buscar setores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return nomeSetor.ToArray();
            }
        }

        private void btnAvancarAtendentes_Click(object sender, EventArgs e)
        {
            string selecionado = lstItems.SelectedItem?.ToString();

            if (selecionado == null)
            {
                MessageBox.Show("Nenhum setor foi selecionado");
                return;
            }

            FrmSelecionarAtendentes FrmSelecionarAtendentes = new FrmSelecionarAtendentes(selecionado);
            FrmSelecionarAtendentes.ShowDialog();
            this.Hide();
        }
    }
}
