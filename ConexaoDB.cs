using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Relogio_Ponto
{
  public partial class Form1
  {
    public Form1()
    {
      InitializeComponent();
      string strConnection = "server=127.0.0.1;User Id=Piteco;password=Pitecoso123@";

      MySqlConnection conexao = new MySqlConnection(strConnection);

      try
      {
        conexao.Open();
        MessageBox.Show("Conectado MySQL");
        MySqlCommand comando = new MySqlCommand();
        comando.Connection = conexao;
        comando.CommandText = "CREATE DATABASE IF NOT EXISTS Relogio_Ponto";
        comando.ExecuteNonQuery();
        comando.Dispose();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro ao Conectar MySQL \n" + ex);
      }
      finally
      {
        conexao.Close();
      }

      string strConnection2 = "server=127.0.0.1;User Id=Piteco;database=relogio_ponto;password=Pitecoso123@";

      MySqlConnection conexao2 = new MySqlConnection(strConnection2);
      try
      {
        conexao2.Open();

        MySqlCommand comando = new MySqlCommand();
        comando.Connection = conexao2;

        comando.CommandText = "CREATE TABLE usuarios ( id INT NOT NULL, user_name VARCHAR(50), password VARCHAR(50), nome_completo VARCHAR(50), cpf_user VARCHAR(14),  tel_user VARCHAR(14),  email VARCHAR(100), PRIMARY KEY(id))";
        comando.CommandText = "CREATE TABLE logins (id INT NOT NULL, dayNhour VARCHAR(50), nome_logado VARCHAR(50), PRIMARY KEY(id))";
        comando.ExecuteNonQuery();

        comando.Dispose();
      }
      catch (Exception ex)
      {
      }
      finally
      {
        conexao.Close();
      }
    }
  }
}