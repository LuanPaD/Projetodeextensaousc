using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensão.Formulários.Perguntas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; 

namespace Projeto_de_Extensao.Formulários.Cadastros
{
    public partial class FrmSelecionarAtendentes : Form
    {
        int numCampoPreenchidoAtual = 1;
        private string setorSelecionado;
        private int pular = 0;

        public FrmSelecionarAtendentes(string setorSelecionado)
        {
            InitializeComponent();
            EstilizarPictureBox(ptbAtendente1);
            EstilizarPictureBox(ptbAtendente2);
            EstilizarRadioButton(rdbAtendente1);
            EstilizarRadioButton(rdbAtendente2);

            this.setorSelecionado = setorSelecionado;
            getAtendentes(this.setorSelecionado, pular);
            int quantidade = numAtendentes(this.setorSelecionado);

            if (quantidade == 2)
            {
                btnProxAtendente.Visible = false;
            }
        }

        private void EstilizarRadioButton(RadioButton radioButton)
        {
            // Customizando o estilo visual do RadioButton
            radioButton.Appearance = Appearance.Normal;
            radioButton.FlatStyle = FlatStyle.Flat;
            radioButton.FlatAppearance.BorderSize = 0;
            radioButton.BackColor = Color.Transparent;  // Fundo transparente
            radioButton.ForeColor = Color.Black;  // Cor do texto
            radioButton.TextAlign = ContentAlignment.MiddleCenter;
            radioButton.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            // Criando borda circular para o RadioButton
            radioButton.Paint += (s, e) =>
            {
                int size = radioButton.Height - 4;
                RectangleF bounds = new RectangleF(2, 2, size, size);
                Color borderColor = radioButton.Checked ? Color.Red : Color.LightGray;
                Color fillColor = radioButton.Checked ? Color.Red : Color.Transparent;

                // Desenhando o círculo do RadioButton
                using (Pen borderPen = new Pen(borderColor, 2))
                using (SolidBrush fillBrush = new SolidBrush(fillColor))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillEllipse(fillBrush, bounds);
                    e.Graphics.DrawEllipse(borderPen, bounds);
                }

                // Desenhando o texto
                using (Brush textBrush = new SolidBrush(radioButton.ForeColor))
                {
                    e.Graphics.DrawString(radioButton.Text, radioButton.Font, textBrush, new RectangleF(1000, 0, radioButton.Width - 50, radioButton.Height));
                }
            };

            // Adicionando animação para hover e clique
            //radioButton.MouseEnter += (s, e) => radioButton.BackColor = Color.FromArgb(40, 40, 40);  // Escurecendo um pouco ao passar o mouse
            //radioButton.MouseLeave += (s, e) => radioButton.BackColor = Color.Transparent;

            radioButton.CheckedChanged += (s, e) =>
            {
                radioButton.Invalidate();  // Forçando o repaint para atualizar o estado
            };
        }
        /*private void EstilizarRadioButton(RadioButton rb)
{
    rb.Appearance = Appearance.Button; // Faz com que o RadioButton tenha aparência de botão
    rb.FlatStyle = FlatStyle.Flat;
    rb.BackColor = Color.White; // Cor de fundo padrão
    rb.ForeColor = Color.DarkSlateGray; // Cor do texto padrão
    rb.FlatAppearance.BorderColor = Color.DarkGray; // Cor da borda
    rb.FlatAppearance.BorderSize = 2;
    rb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
    rb.Size = new Size(120, 50); // Tamanho do botão para dar mais destaque
    rb.TextAlign = ContentAlignment.MiddleCenter;

    // Eventos para alterar o estilo quando o botão é clicado
    rb.CheckedChanged += (sender, e) =>
    {
        if (rb.Checked)
        {
            rb.BackColor = Color.Red; // Cor de fundo vermelha ao selecionar
            rb.ForeColor = Color.White; // Texto em branco para contraste
        }
        else
        {
            rb.BackColor = Color.White; // Volta à cor padrão ao desmarcar
            rb.ForeColor = Color.DarkSlateGray;
        }
    };

    // Evento para mudar a aparência ao passar o mouse
    rb.MouseEnter += (sender, e) =>
    {
        if (!rb.Checked) rb.BackColor = Color.LightGray;
    };
    rb.MouseLeave += (sender, e) =>
    {
        if (!rb.Checked) rb.BackColor = Color.White;
    };
}

         */
        private void EstilizarPictureBox(PictureBox pictureBox)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Preenchimento total do PictureBox
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Paint += (sender, e) =>
            {
                int borderRadius = 20; // Aumentado para uma aparência mais moderna
                int borderThickness = 2;

                // Criação do caminho arredondado para os cantos
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(pictureBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(pictureBox.Width - borderRadius, pictureBox.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, pictureBox.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                // Aplicando máscara arredondada
                pictureBox.Region = new Region(path);

                // Sombra suave para destacar o PictureBox
                Color shadowColor = Color.FromArgb(60, 0, 0, 0); // Sombra mais suave e difusa
                using (Pen shadowPen = new Pen(shadowColor, borderThickness * 4))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(shadowPen, path);
                }

                // Borda arredondada moderna
                Color borderColor = Color.Gray;
                using (Pen borderPen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(borderPen, path);
                }
            };
        }
        private void limpaCampos()
        {
            ptbAtendente1.Image = null;
            ptbAtendente2.Image = null;
            rdbAtendente1.Checked = false;
            rdbAtendente2.Checked = false;
        }

        private void btnAvancarAtendentes_Click(object sender, EventArgs e)
        {
            int quantidade = numAtendentes(setorSelecionado);

            bool qtdImpar = quantidade % 2 != 0;

            if (pular < (quantidade - 2))
            {
                pular += 2;
                limpaCampos();
                getAtendentes(setorSelecionado, pular);

                if (qtdImpar && pular >= quantidade - 1)
                {
                    rdbAtendente1.Visible = true;
                    rdbAtendente2.Visible = false;
                }
                else
                {
                    rdbAtendente1.Visible = true;
                    rdbAtendente2.Visible = true;
                }

                btnVoltarAtendentes.Visible = true;

                if (pular >= (quantidade - 2))
                {
                    btnProxAtendente.Visible = false;
                }
            }
            else
            {
                btnProxAtendente.Visible = false;
            }
        }


        private void btnVoltarAtendentes_Click(object sender, EventArgs e)
        {
            if (pular >= 2)
            {
                rdbAtendente1.Visible = true;
                rdbAtendente2.Visible = true;
                pular -= 2;
                limpaCampos();
                getAtendentes(setorSelecionado, pular);

                if (pular < 2)
                {
                    btnVoltarAtendentes.Visible = false;
                }
                btnProxAtendente.Visible = true;
            }
        }


        private void getAtendentes(string setorSelecionado, int pular)
        {
            string sql = @"SELECT f.imagem as 'Imagem', a.nome as 'Nome'
                    from fotos f 
                    inner join atendente a 
                    where 
                        a.atendente_id = f.atendente_id
                    and a.setor_id = ( select setor_id from setores where  nome = @setor ) LIMIT 2 OFFSET @pular;";

            using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@setor", setorSelecionado);
                cmd.Parameters.AddWithValue("@pular", pular);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["Nome"] != DBNull.Value && reader["Imagem"] != DBNull.Value)
                        {
                            setaImagemENomeNoPTB((byte[])reader["Imagem"], (string)reader["Nome"]);
                            numCampoPreenchidoAtual++;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            numCampoPreenchidoAtual = 1;
        }

        private int numAtendentes(string setorSelecionado)
        {
            string sql = @"SELECT COUNT(atendente_id)
                    FROM atendente
                    WHERE setor_id = (select setor_id from setores where nome = @setorSelecionado); ";

            using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@setorSelecionado", setorSelecionado);

                int quantidade = Convert.ToInt32(cmd.ExecuteScalar());

                return quantidade;
            }
        }

        private void setaImagemENomeNoPTB(byte[] imageBytes, string nome)
        {
            var ptbImagem = buscaPtb();
            var rdbAtendeteSelecionado = buscaRBNome();

            if (ptbImagem == null || rdbAtendeteSelecionado == null) return;

            if (imageBytes != null)
            {
                using (var ms = new MemoryStream(imageBytes))
                {
                    ptbImagem.Image = Image.FromStream(ms);
                }
            }
            else
            {
                ptbImagem.Image = Properties.Resources.Foto_de_perfil_para_redes_sociais_gradiente_simples__1__removebg_preview;
            }
            rdbAtendeteSelecionado.Text = nome;
        }

        private PictureBox buscaPtb()
        {
            var ptbImagemAtendente = this.Controls.Find($"ptbAtendente{numCampoPreenchidoAtual}", true).FirstOrDefault();

            if (ptbImagemAtendente != null)
            {
                return (PictureBox)ptbImagemAtendente;
            }

            return null;
        }


        private RadioButton buscaRBNome()
        {
            var rdbNomeAtendente = this.Controls.Find($"rdbAtendente{numCampoPreenchidoAtual}", true).FirstOrDefault();

            if (rdbNomeAtendente != null)
            {
                return (RadioButton)rdbNomeAtendente;
            }

            return null;
        }

        private void btnAvancarAtendentes_Click_1(object sender, EventArgs e)
        {
            if (ValidarAtendenteSelecionado())
            {
                FrmPergunta FrmPergunta = new FrmPergunta(atendenteId);
                FrmPergunta.ShowDialog();
                this.Hide();
            }
        }

        private int atendenteId = -1;

        private bool ValidarAtendenteSelecionado()
        {
            if (!rdbAtendente1.Checked && !rdbAtendente2.Checked)
            {
                MessageBox.Show("Por favor, selecione um atendente.");
                return false;
            }

            if (rdbAtendente1.Checked)
            {
                string nomeAtendente1 = rdbAtendente1.Text;
                atendenteId = GetAtendenteId(nomeAtendente1);
            }
            else if (rdbAtendente2.Checked)
            {
                string nomeAtendente2 = rdbAtendente2.Text;
                atendenteId = GetAtendenteId(nomeAtendente2);
            }

            if (atendenteId != -1)
                return true;
            else
            {
                MessageBox.Show("Nenhum atendente encontrado.");
                return false;
            }
        }

        private int GetAtendenteId(string nome)
        {
            string sql = @"SELECT atendente_id FROM atendente WHERE nome = @nome";

            using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@nome", nome);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32("atendente_id");
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }


    }
}
