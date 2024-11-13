using MySqlConnector;
using Projeto_de_Extensao.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.setorSelecionado = setorSelecionado;
            getAtendentes(this.setorSelecionado, pular);
            int quantidade = numAtendentes(this.setorSelecionado);

            if (quantidade == 2)
            {
                btnProxAtendente.Visible = false;
            }

        }

        private void limpaCampos()
        {
            ptbAtendente1.Image = null;
            ptbAtendente2.Image = null;
            lblNomeAtendente1.Text = string.Empty;
            lblNomeAtendente2.Text = string.Empty;
        }

        private void btnAvancarAtendentes_Click(object sender, EventArgs e)
        {
            int quantidade = numAtendentes(setorSelecionado);

            if(quantidade == 0)
            {
                btnProxAtendente.Visible = false;
            }

            if (pular < (quantidade - 2))
            {
                pular += 2;
                limpaCampos();
                getAtendentes(setorSelecionado, pular);

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



        public static async Task ListaTodosOsSetoresAsync(ComboBox comboBox)
        {
            string sql = "SELECT * FROM setores";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        var setores = new List<DictionaryEntry>
                        {
                            new DictionaryEntry(0,"--SELECIONE--")
                        };

                        while (await reader.ReadAsync())
                        {
                            int setorId = reader.GetInt32("setor_id");
                            string nomeSetor = reader.GetString("nome");

                            setores.Add(new DictionaryEntry(setorId, nomeSetor));
                        }

                        comboBox.DataSource = setores;
                        comboBox.DisplayMember = "Value";
                        comboBox.ValueMember = "Key";

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao listar setores: " + ex.Message);
            }
        }

        private void setaImagemENomeNoPTB(byte[] imageBytes, string nome)
        {
            var ptbImagem = buscaPtb();
            var lblNomeAtendente = buscalblNome();

            if (ptbImagem == null || lblNomeAtendente == null) return;

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

            lblNomeAtendente.Text = nome;
        }

        private PictureBox buscaPtb()
        {
            var ptbImagemAtendente = this.Controls.Find($"ptbAtendente{numCampoPreenchidoAtual}", true).FirstOrDefault();

            if (ptbImagemAtendente != null)
            {
                //if (ptbImagemAtendente.Visible)
                {
                    //ptbImagemAtendentes.Visible = true;
                    return (PictureBox)ptbImagemAtendente;
                }
            }

            
            return null; 
        }

        private Label buscalblNome()
        {
            var lblNomeAtendente = this.Controls.Find($"lblNomeAtendente{numCampoPreenchidoAtual}", true).FirstOrDefault();

            if (lblNomeAtendente != null)
            {
                //
                //if (lblNomeAtendente.Visible)
                {
                    return (Label)lblNomeAtendente;
                }
            }

            return null;
        }

        
    }
}
