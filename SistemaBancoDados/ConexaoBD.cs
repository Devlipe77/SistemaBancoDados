using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banco_de_dados
{
    public class ConexaoDB
    {
        private string connectionString = "Server=localhost;Port=3306;User=root;Password=@admin;Database=northwind;";
        private MySqlConnection connection;

        public ConexaoDB()
        {
            connection = new MySqlConnection(connectionString);
        }

        public bool AbrirConexao()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    return true;
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool FecharConexao()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    return true;
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao fechar conexão: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable ExecutarConsulta(string consulta)
        {
            DataTable dataTable = new DataTable();

            try
            {
                if (AbrirConexao())
                {
                    MySqlCommand comando = new MySqlCommand(consulta, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    adapter.Fill(dataTable);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao executar consulta: {ex.Message}", "Erro na Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FecharConexao();
            }

            return dataTable;
        }

        public bool ExecutarComando(string comando)
        {
            try
            {
                if (AbrirConexao())
                {
                    MySqlCommand sqlComando = new MySqlCommand(comando, connection);
                    sqlComando.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao executar comando: {ex.Message}", "Erro no Comando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void DefinirConexao(string server, int porta, string usuario, string senha, string banco)
        {
            connectionString = $"Server={server};Port={porta};User={usuario};Password={senha};Database={banco};";
            connection = new MySqlConnection(connectionString);
        }
    }
}