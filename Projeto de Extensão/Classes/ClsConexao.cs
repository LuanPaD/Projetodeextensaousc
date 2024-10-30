using System;
using System.Threading.Tasks;
using MySqlConnector;

namespace Projeto_de_Extensao.Classes
{
    internal class ClsConexao
    {
        public static MySqlConnection? Conexao { get; private set; }
        private static string connectionString = "Server=127.0.0.1;Port=3306;Database=avaliacaoatendimento;User=luan;Password=3237;";

        // Método para obter a conexão com o banco de dados
        public async Task GetConexao()
        {
            if (ConexaoAtiva())
            {
                Console.WriteLine("A conexão já está aberta.");
                return;
            }

            Conexao = new MySqlConnection(connectionString);

            try
            {
                await Conexao.OpenAsync();
                Console.WriteLine("Conexão aberta com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }

        // Método para fechar a conexão
        public async Task CloseConnection()
        {
            if (!ConexaoAtiva())
            {
                Console.WriteLine("A conexão já está fechada.");
                return;
            }

            try
            {
                await Conexao.CloseAsync();
                Console.WriteLine("Conexão fechada com sucesso!");
                Conexao = null; // Libera a conexão
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fechar a conexão: " + ex.Message);
            }
        }

        // Verifica se a conexão está ativa
        public static bool ConexaoAtiva()
        {
            if (Conexao == null) return false;
            return Conexao.State == System.Data.ConnectionState.Open;
        }
    }
}
