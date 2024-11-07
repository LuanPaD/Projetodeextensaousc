﻿using iText.Kernel.Colors;
using iText.StyledXmlParser.Jsoup.Nodes;
using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Projeto_de_Extensao.Formulários.Admnistrativo
{
    public partial class FrmEditarCadastroscs : Form
    {

        public FrmEditarCadastroscs()
        {
            InitializeComponent();
        }

        private void btnSetor_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbSetor;
        }

        private void btnPerguntas_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbPerguntas;
        }

        private void btnCadrastoAdmin_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbAdmin;
        }

        private void btnHomeSetor_Click(object sender, EventArgs e)
        {
            FrmEscolhaInicial frmEscolhaInicial = new FrmEscolhaInicial();
            frmEscolhaInicial.Show();

            this.Hide();
        }

        private void btnAtendentes_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbAtendentes;
        }

        private async void btnCarregarSetores_Click(object sender, EventArgs e)
        {
            await CarregarDadosAsync("SELECT * FROM setores;", GridSetores, "setor_id");

        }

        private async void btnCarregaAdmin_Click(object sender, EventArgs e)
        {
            await CarregarDadosAsync("SELECT * FROM admin;", GridAdmin, "senha", "admin_id");
        }

        private async void btnCarregarAtendentes_Click(object sender, EventArgs e)
        {
            string sql = @"
                SELECT a.atendente_id,a.nome, s.nome AS setor, a.email
                FROM atendente a
                JOIN setores s ON a.setor_id = s.setor_id;";

            await CarregarDadosAsync(sql, GridAtendentes, "atendentes_id");
        }

        public async Task CarregarDadosAsync(string sql, DataGridView grid, params string[] colunasOcultar)
        {
            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    if (ClsConexao.Conexao.State == ConnectionState.Closed)
                    {
                        await ClsConexao.Conexao.OpenAsync();
                    }

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        grid.DataSource = dt;
                        grid.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                        grid.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        grid.BackgroundColor = System.Drawing.Color.White;
                        grid.GridColor = System.Drawing.Color.Gray;
                        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        foreach (var coluna in colunasOcultar)
                        {
                            if (grid.Columns.Contains(coluna))
                            {
                                grid.Columns[coluna].Visible = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar cadastro: " + ex.Message);
            }
        }
        private void MostraBotoesAtendentes(bool valor)
        {
            gbBotoesAtendente.Visible = valor;
        }

        private void MostrarBotoesAdmin(bool valor)
        {
            gbBotoesAdmin.Visible = valor;
        }

        private void MostraBotoesSetor(bool valor)
        {
            gbBotoesSetor.Visible = valor;
        }

        private void btnEditarSetor_Click(object sender, EventArgs e)
        {
            MostraBotoesSetor(true);
        }

        private void btnEditarAtendentes_Click(object sender, EventArgs e)
        {
            MostraBotoesAtendentes(true);
        }

        private void btnEditarAdmin_Click(object sender, EventArgs e)
        {
            MostrarBotoesAdmin(true);
        }

        private void GridSetores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var row = GridSetores.Rows[e.RowIndex];


                txtNomeSetor.Text = row.Cells["nome"].Value?.ToString();
                txtIdSetor.Text = row.Cells["setor_id"].Value?.ToString();

            }
        }

        private void GridAdimin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var row = GridAdmin.Rows[e.RowIndex];

                txtIdAdmin.Text = row.Cells["admin_id"].Value?.ToString();
                txtNomeAdimin.Text = row.Cells["nome"].Value?.ToString();
                txtEmailAdmin.Text = row.Cells["email"].Value?.ToString();
                txtSenhaAdmin.Text = row.Cells["senha"].Value?.ToString();

            }
        }

        private void GridAtendentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var row = GridAtendentes.Rows[e.RowIndex];

                txtIdAtendente.Text = row.Cells["atendente_id"].Value?.ToString();
                txtNomeAtendente.Text = row.Cells["nome"].Value?.ToString();
                txtEmailAtendente.Text = row.Cells["email"].Value?.ToString();
                txtSetorAtendente.Text = row.Cells["setor"].Value?.ToString();
            }
        }

        private async void btnSalvarSetor_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdSetor.Text, out int setorId);
           
            bool operacaoRealizada = await AtualizarSetorAsync(setorId, txtNomeSetor.Text);

            if (operacaoRealizada)
            {
                MostraBotoesSetor(false);
            } 
        }

        private async Task<bool>  jaExisteCadastroSetor(string nome)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT COUNT(*) FROM setores WHERE NOME = @nome");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@nome", nome);

                try
                {

                    var result = await cmd.ExecuteScalarAsync();
                    int count = Convert.ToInt32(result);
                    return count > 0;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao verificar cadastro :" + ex.Message);
                    return false;
                }
            }
        }


        private  async Task<bool> AtualizarSetorAsync(int setorId, string nome)
        {
            if (await jaExisteCadastroSetor(nome))
            {
                lblMsgDaOperacao.Text = "Esse SETOR Já Cadastrado";
                lblMsgDaOperacao.Visible = true;
                await Task.Delay(2000);
                lblMsgDaOperacao.Visible = false;
                return false;
            }
            string sql = @"
                    UPDATE setores 
                    SET nome = @nome 
                    WHERE setor_id = @setorId;";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                { 
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@setorId", setorId);

                    int linhasAfetadas = await cmd.ExecuteNonQueryAsync();

                    if (linhasAfetadas > 0)
                    {
                        lblMsgDaOperacao.Text = "Setor atualizado com sucesso!";
                        lblMsgDaOperacao.Visible = true;
                        await CarregarDadosAsync("SELECT setor_id, nome FROM setores;", GridSetores, "setor_id");
                        await Task.Delay(2000);
                        lblMsgDaOperacao.Visible = false;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi feita.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar setor: " + ex.Message);
                return false;
            }
        }


        private async Task<bool> AtualizarAdminAsync(int adminId, string nome, string email, string senha)
        {
            if (!FrmCadastros.ValidaEmail(email))
            {
                lblMsgErroAdmin.Text = "Digite um e-mail válido.";
                lblMsgErroAdmin.Visible = true;
                await Task.Delay(2000);
                lblMsgErroAdmin.Visible = false;
                return false;
            }

            if (await FrmCadastros.jaExisteCadastroEmailAdmin(email))
            {
                lblMsgErroAdmin.Text = "Este e-mail já está cadastrado com outro administrador.";
                lblMsgErroAdmin.Visible = true;
                await Task.Delay(2000);
                lblMsgErroAdmin.Visible = false;
                return false;
            }

            string sql = @"
                UPDATE admin 
                SET nome = @nome, email = @email, senha = @senha
                WHERE admin_id = @admin_id;";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@admin_id", adminId);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int linhasAfetadas = await cmd.ExecuteNonQueryAsync();

                    if (linhasAfetadas > 0)
                    {
                        lblMsgErroAdmin.Text = "Administrador atualizado com sucesso!";
                        lblMsgErroAdmin.Visible = true;
                        await CarregarDadosAsync("SELECT * FROM admin;", GridAdmin, "admin_id", "senha");
                        await Task.Delay(2000);
                        lblMsgErroAdmin.Visible = false;
                        return true;
                    }
                    else
                    {
                        lblMsgErroAdmin.Text = "Nenhuma alteração foi feita.";
                        lblMsgErroAdmin.Visible = true;
                        await Task.Delay(2000);
                        lblMsgErroAdmin.Visible = false;
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsgErroAdmin.Text = "Erro ao atualizar administrador: " + ex.Message;
                lblMsgErroAdmin.Visible = true;
                await Task.Delay(2000);
                lblMsgErroAdmin.Visible = false;
                return false;
            }
        }

        private async void btnSalvarAdmin_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdAdmin.Text , out int AdminId);

            bool operacaoRealizada = await AtualizarAdminAsync(AdminId, txtNomeAdimin.Text, txtEmailAdmin.Text, txtSenhaAdmin.Text);

            if (operacaoRealizada)
            {
                MostrarBotoesAdmin(false);
            }
        }

        //Não deixar o usuario EDITAR UM CAMPO QUE AINDA NN EXISTE
    }
}
