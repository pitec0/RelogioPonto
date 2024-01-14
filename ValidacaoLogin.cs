using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Relogio_Ponto
{
  internal partial class FormCadastro
  {
    private static Usuario[] usuarios =
    {
    };

    private static string strConnection = "server=127.0.0.1;User Id=Piteco;database=relogio_ponto;password=Pitecoso123@";

    public bool ConsultarDados(string nome, string senha)
    {
      MySqlConnection conexao = new MySqlConnection(strConnection); // Mova a declaração para fora do bloco 'using'

      try
      {
        string query = "SELECT * FROM usuarios WHERE user_name = @NomeParametro AND password = @SenhaParametro";

        conexao.Open();

        using (MySqlCommand comando = new MySqlCommand(query, conexao))
        {
          comando.Parameters.AddWithValue("@NomeParametro", nome);
          comando.Parameters.AddWithValue("@SenhaParametro", senha);

          DataTable dados = new DataTable();

          using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
          {
            adaptador.Fill(dados);
          }

          if (dados.Rows.Count > 0)
          {
            // Usuário autenticado
            return true;
          }
          else
          {
            // Usuário não encontrado ou senha incorreta
            return false;
          }
        }
      }
      catch (Exception ex)
      {
        // Trate a exceção conforme necessário
        MessageBox.Show(ex.Message);
        return false;
      }
      finally
      {
        conexao.Close();
      }
    }
  }
}
