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
        public Form1()
        {
            InitializeComponent();
        }

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

            if (FormCadastro.Login(nome, senha))
            {
                MessageBox.Show("Entrada realizada em " + now);
            }
            else
            {
                MessageBox.Show("Login ou senha incorreto!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                this.Close();
            }
                txtUsuario.Text = string.Empty;
                txtSenha.Text = string.Empty;
            


            //fazer envio para banco de dados da hora de entrada
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (txtUsuario.Text == " ")
            {
                MessageBox.Show("Preencha o campo Usuário.");
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text == " ")
            {
                MessageBox.Show("Preencha o campo Senha.");
                txtSenha.Focus();
                return;
            }
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (FormCadastro.Login(nome, senha))
            {
                MessageBox.Show("Saida realizada em " + now);
            }
            else
            {
                MessageBox.Show("Login ou senha incorreto!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                this.Close();
            }
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;

            //fazer envio para banco de dados da hora de saida
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro newFuncionario = new FormCadastro();
            newFuncionario.Show();
        }
    }
}
