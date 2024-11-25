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

            if (quantidade == 1)
            {
                rdbAtendente2.Visible = false;
                ptbAtendente2.Visible = false;
                btnProxAtendente.Visible = false;

            }

            if (quantidade == 2)
            {
                btnProxAtendente.Visible = false;
            }
        }

        private void EstilizarRadioButton(RadioButton rb)
        {
            rb.Appearance = Appearance.Button;
            rb.FlatStyle = FlatStyle.Flat;

            // Estilo padrão quando não está clicado
            rb.BackColor = Color.White;
            rb.ForeColor = Color.Black;
            rb.FlatAppearance.BorderColor = Color.DarkRed;
            rb.FlatAppearance.BorderSize = 2;
            rb.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rb.Size = new Size(ptbAtendente1.Width, 45);
            rb.TextAlign = ContentAlignment.MiddleCenter;

            rb.CheckedChanged += (sender, e) =>
            {
                if (rb.Checked)
                {
                    rb.BackColor = Color.DarkRed;
                    rb.ForeColor = Color.White;
                    rb.FlatAppearance.BorderColor = Color.Maroon;
                }
                else
                {
                    rb.BackColor = Color.White;
                    rb.ForeColor = Color.DarkSlateGray;
                    rb.FlatAppearance.BorderColor = Color.DarkRed;
                }
            };

            // Evento de hover para mouse
            rb.MouseEnter += (sender, e) =>
            {
                if (!rb.Checked)
                {
                    rb.BackColor = Color.LightCoral; 
                }
            };

            rb.MouseLeave += (sender, e) =>
            {
                if (!rb.Checked)
                {
                    rb.BackColor = Color.White; 
                }
            };
        }


        private void EstilizarPictureBox(PictureBox pictureBox)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Paint += (sender, e) =>
            {
                int borderRadius = 20;
                int borderThickness = 2;

                
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(pictureBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(pictureBox.Width - borderRadius, pictureBox.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, pictureBox.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                
                pictureBox.Region = new Region(path);

                
                Color shadowColor = Color.FromArgb(60, 0, 0, 0);
                using (Pen shadowPen = new Pen(shadowColor, borderThickness * 4))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(shadowPen, path);
                }

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
                    ptbAtendente2.Visible = false;
                }
                else
                {
                    rdbAtendente1.Visible = true;
                    rdbAtendente2.Visible = true;
                    ptbAtendente2.Visible = true;
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
                ptbAtendente2.Visible = true;
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
            FROM fotos f
            INNER JOIN atendente a ON a.atendente_id = f.atendente_id
            AND a.setor_id = (SELECT setor_id FROM setores WHERE nome = @setor)
            LIMIT 2 OFFSET @pular;";

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
                FrmPergunta FrmPergunta = new FrmPergunta(atendenteId, setorSelecionado);
                //FrmPergunta.ShowDialog();
                FrmPergunta.Show();
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
