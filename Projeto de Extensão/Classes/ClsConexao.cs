using System;
using System.Threading.Tasks;
using MySqlConnector;

namespace Projeto_de_Extensao.Classes
{
    internal class ClsConexao
    {
        public static MySqlConnection Conexao { get; private set; } = null!;
        private static string connectionString = "Server=127.0.0.1;Port=3306;Database=avaliacaoatendimento;User=luan;Password=3237;";

        public async Task getConexao()
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

        public async Task closeConnection()
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fechar a conexão: " + ex.Message);
            }
        }

        public static bool ConexaoAtiva()
        {
            if (Conexao == null) { return false; }
            if (Conexao.State == System.Data.ConnectionState.Closed) { return false; }
            if (Conexao.State == System.Data.ConnectionState.Broken) { return false; }

            return Conexao.State == System.Data.ConnectionState.Open;
        }
    }
}
