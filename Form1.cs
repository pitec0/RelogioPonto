using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Relogio_Ponto
{
  public partial class Form1 : Form
  {
    private void Form1_Load(object sender, EventArgs e)
    {
    }
    //criar parametro no db para nome de ENTRADA E SAIDA PARA PODER FAZER FILTAGEM DE QUANDO ENTROU E QUANDO SAIU.
    //criar parametro no db para nome de ENTRADA E SAIDA..
    //criar parametro no db para nome de ENTRADA E SAIDA..
    //criar parametro no db para nome de ENTRADA E SAIDA..
    //criar parametro no db para nome de ENTRADA E SAIDA..
    //criar parametro no db para nome de ENTRADA E SAIDA..
    //criar parametro no db para nome de ENTRADA E SAIDA..
    //criar parametro no db para nome de ENTRADA E SAIDA..

    private void btnEntrada_Click(object sender, EventArgs e)
    {
      DateTime now = DateTime.Now;

      if (txtUsuario.Text == "")
      {
        MessageBox.Show("Preencha o campo Usuário.");
        txtUsuario.Focus();
        return;
      }

      if (txtSenha.Text == "")
      {
        MessageBox.Show("Preencha o campo Senha.");
        txtSenha.Focus();
        return;
      }

      string nome = txtUsuario.Text;
      string senha = txtSenha.Text;

      FormCadastro formCadastro = new FormCadastro();

      Tuple<bool, string, string, string> resultadoAutenticacao = formCadastro.ConsultarDados(nome, senha);

      if (resultadoAutenticacao.Item1)
      {
        string id = resultadoAutenticacao.Item2;
        string nomeCompleto = resultadoAutenticacao.Item3;
        string nomeUsuario = resultadoAutenticacao.Item4;

        try
        {
          string strConnection = "server=127.0.0.1;User Id=root;database=relogio_ponto;password=root";

          using (MySqlConnection conexao = new MySqlConnection(strConnection))
          {
            conexao.Open();

            using (MySqlCommand comando = new MySqlCommand())
            {
              comando.Connection = conexao;
              comando.CommandText = "INSERT INTO logins (nome_logado, dayNhour) " +
                                    "VALUES (@nome_completo, @data_registro)";
              comando.Parameters.AddWithValue("@nome_completo", nomeCompleto);
              comando.Parameters.AddWithValue("@data_registro", DateTime.Now);

              comando.ExecuteNonQuery();

              MessageBox.Show("Entrada realizada em " + DateTime.Now);
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Erro \n" + ex.Message);
        }
      }
      else
      {
        MessageBox.Show("Login ou senha incorreto!");
        txtUsuario.Text = "";
        txtSenha.Text = "";
        txtUsuario.Focus();
      }

      txtUsuario.Text = string.Empty;
      txtSenha.Text = string.Empty;
    }

    private void btnSaida_Click(object sender, EventArgs e)
    {
      DateTime now = DateTime.Now;

      if (txtUsuario.Text == "")
      {
        MessageBox.Show("Preencha o campo Usuário.");
        txtUsuario.Focus();
        return;
      }

      if (txtSenha.Text == "")
      {
        MessageBox.Show("Preencha o campo Senha.");
        txtSenha.Focus();
        return;
      }

      string nome = txtUsuario.Text;
      string senha = txtSenha.Text;

      FormCadastro formCadastro = new FormCadastro();

      Tuple<bool, string, string, string> resultadoAutenticacao = formCadastro.ConsultarDados(nome, senha);

      if (resultadoAutenticacao.Item1)
      {
        string id = resultadoAutenticacao.Item2;
        string nomeCompleto = resultadoAutenticacao.Item3;
        string nomeUsuario = resultadoAutenticacao.Item4;

        
        try
        {
          string strConnection = "server=127.0.0.1;User Id=root;database=relogio_ponto;password=root";

          using (MySqlConnection conexao = new MySqlConnection(strConnection))
          {
            conexao.Open();

            using (MySqlCommand comando = new MySqlCommand())
            {
              comando.Connection = conexao;
              comando.CommandText = "INSERT INTO logins (nome_logado, dayNhour) " +
                                    "VALUES (@nome_completo, @data_registro)";
              comando.Parameters.AddWithValue("@nome_completo", nomeCompleto);
              comando.Parameters.AddWithValue("@data_registro", DateTime.Now);

              comando.ExecuteNonQuery();
              MessageBox.Show("Saída realizada em " + DateTime.Now);
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Erro \n" + ex.Message);
        }
      }
      else
      {
        MessageBox.Show("Login ou senha incorreto!");
        txtUsuario.Text = "";
        txtSenha.Text = "";
        txtUsuario.Focus();
      }

      txtUsuario.Text = string.Empty;
      txtSenha.Text = string.Empty;
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
      FormCadastro newFuncionario = new FormCadastro();
      newFuncionario.Show();
    }
  }
}