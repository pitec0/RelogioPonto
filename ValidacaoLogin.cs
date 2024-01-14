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

    // Modifique a assinatura para retornar uma tupla
    public Tuple<bool, string, string, string> ConsultarDados(string nome, string senha)
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
            string id = dados.Rows[0]["id"].ToString();
            string nomeCompleto = dados.Rows[0]["nome_completo"].ToString();
            string nomeUsuario = dados.Rows[0]["user_name"].ToString();

            return new Tuple<bool, string, string, string>(true, id, nomeCompleto, nomeUsuario);
          }
          else
          {
            // Usuário não encontrado ou senha incorreta
            return new Tuple<bool, string, string, string>(false, null, null, null);
          }
        }
      }
      catch (Exception ex)
      {
        // Trate a exceção conforme necessário
        MessageBox.Show(ex.Message);
        return new Tuple<bool, string, string, string>(false, null, null, null);
      }
      finally
      {
        conexao.Close();
      }
    }
  }
}
