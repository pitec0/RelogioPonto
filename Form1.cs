using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Org.BouncyCastle.Utilities;

namespace Relogio_Ponto
{
  public partial class Form1 : Form
  {
    private void Form1_Load(object sender, EventArgs e)
    {
    }
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

      if (formCadastro.ConsultarDados(nome, senha))
      {
        MessageBox.Show("Entrada realizada em " + now);
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

      // fazer envio para banco de dados da hora de saída


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

      if (formCadastro.ConsultarDados(nome, senha))
      {
        MessageBox.Show("Saída realizada em " + now);
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

      // fazer envio para banco de dados da hora de saída
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
      FormCadastro newFuncionario = new FormCadastro();
      newFuncionario.Show();
    }
  }
}