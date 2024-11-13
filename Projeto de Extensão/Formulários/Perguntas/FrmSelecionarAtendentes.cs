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
        public FrmSelecionarAtendentes(string setorSelecionado)
        {
            InitializeComponent();
            getAtendentes(setorSelecionado);
        }

        private void btnAvancarAtendentes_Click(object sender, EventArgs e)
        {

        }
        private void getAtendentes(string setorSelecionado)
        {
            string sql = @"SELECT f.imagem as 'Imagem', a.nome as 'Nome'
                    from fotos f 
                    inner join atendente a 
                    where 
                        a.atendente_id = f.atendente_id
                    and a.setor_id = ( select setor_id from setores where  nome = @setor ) LIMIT 2";

            using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@setor", setorSelecionado);
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

            lblNomeAtendente    .Text = nome;
        }

        private PictureBox buscaPtb()
        {
            var ptbImagemAtendente = this.Controls.Find($"ptbAtendente{numCampoPreenchidoAtual}", true).FirstOrDefault();

            if (ptbImagemAtendente != null)
            {
                //if (ptbImagemAtendente.Visible)
                {
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
                    return (Label) lblNomeAtendente;
                }
            }

            return null;
        }
        
    }
}
