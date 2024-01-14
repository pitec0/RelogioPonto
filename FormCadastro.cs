using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Relogio_Ponto
{

  internal partial class FormCadastro : Form
  {
    
    private Label lblUserName;
    private Label lblNomeC;
    private Label lblCPF;
    private Label lblTel;
    private Label lblEmail;
    private TextBox txtUserName;
    private TextBox txtUserPass;
    private TextBox txtNomeC;
    private TextBox txtEmail;
    private Button btnEnviar;
    private Button btnCancelar;
    private Button btnClean;
    private MaskedTextBox txtTel;
    private MaskedTextBox txtCPF;
    private Label lblSenhaUser;

    private void InitializeComponent()
    {
      this.lblUserName = new System.Windows.Forms.Label();
      this.lblNomeC = new System.Windows.Forms.Label();
      this.lblSenhaUser = new System.Windows.Forms.Label();
      this.lblCPF = new System.Windows.Forms.Label();
      this.lblTel = new System.Windows.Forms.Label();
      this.lblEmail = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.txtUserPass = new System.Windows.Forms.TextBox();
      this.txtNomeC = new System.Windows.Forms.TextBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.btnEnviar = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnClean = new System.Windows.Forms.Button();
      this.txtTel = new System.Windows.Forms.MaskedTextBox();
      this.txtCPF = new System.Windows.Forms.MaskedTextBox();
      this.SuspendLayout();
      //
      // lblUserName
      //
      this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserName.Location = new System.Drawing.Point(29, 75);
      this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(195, 23);
      this.lblUserName.TabIndex = 0;
      this.lblUserName.Text = "Nome do Usuário";
      this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      //
      // lblNomeC
      //
      this.lblNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNomeC.Location = new System.Drawing.Point(29, 150);
      this.lblNomeC.Margin = new System.Windows.Forms.Padding(0);
      this.lblNomeC.Name = "lblNomeC";
      this.lblNomeC.Size = new System.Drawing.Size(195, 23);
      this.lblNomeC.TabIndex = 1;
      this.lblNomeC.Text = "Nome Completo";
      this.lblNomeC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      //
      // lblSenhaUser
      //
      this.lblSenhaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSenhaUser.Location = new System.Drawing.Point(29, 113);
      this.lblSenhaUser.Margin = new System.Windows.Forms.Padding(0);
      this.lblSenhaUser.Name = "lblSenhaUser";
      this.lblSenhaUser.Size = new System.Drawing.Size(100, 23);
      this.lblSenhaUser.TabIndex = 2;
      this.lblSenhaUser.Text = "Senha";
      this.lblSenhaUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      //
      // lblCPF
      //
      this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCPF.Location = new System.Drawing.Point(29, 186);
      this.lblCPF.Margin = new System.Windows.Forms.Padding(0);
      this.lblCPF.Name = "lblCPF";
      this.lblCPF.Size = new System.Drawing.Size(100, 23);
      this.lblCPF.TabIndex = 3;
      this.lblCPF.Text = "CPF";
      this.lblCPF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      //
      // lblTel
      //
      this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTel.Location = new System.Drawing.Point(29, 223);
      this.lblTel.Margin = new System.Windows.Forms.Padding(0);
      this.lblTel.Name = "lblTel";
      this.lblTel.Size = new System.Drawing.Size(113, 23);
      this.lblTel.TabIndex = 4;
      this.lblTel.Text = "Telefone";
      this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      //
      // lblEmail
      //
      this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEmail.Location = new System.Drawing.Point(29, 260);
      this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(100, 23);
      this.lblEmail.TabIndex = 5;
      this.lblEmail.Text = "E-mail";
      this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      //
      // txtUserName
      //
      this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUserName.Location = new System.Drawing.Point(227, 75);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(552, 29);
      this.txtUserName.TabIndex = 1;
      //
      // txtUserPass
      //
      this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUserPass.Location = new System.Drawing.Point(227, 113);
      this.txtUserPass.Name = "txtUserPass";
      this.txtUserPass.PasswordChar = '*';
      this.txtUserPass.Size = new System.Drawing.Size(552, 29);
      this.txtUserPass.TabIndex = 2;
      //
      // txtNomeC
      //
      this.txtNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNomeC.Location = new System.Drawing.Point(227, 150);
      this.txtNomeC.Name = "txtNomeC";
      this.txtNomeC.Size = new System.Drawing.Size(552, 29);
      this.txtNomeC.TabIndex = 3;
      //
      // txtEmail
      //
      this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEmail.Location = new System.Drawing.Point(227, 260);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(552, 29);
      this.txtEmail.TabIndex = 6;
      //
      // btnEnviar
      //
      this.btnEnviar.Location = new System.Drawing.Point(34, 376);
      this.btnEnviar.Name = "btnEnviar";
      this.btnEnviar.Size = new System.Drawing.Size(178, 48);
      this.btnEnviar.TabIndex = 12;
      this.btnEnviar.Text = "Enviar Cadastro";
      this.btnEnviar.UseVisualStyleBackColor = true;
      this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
      //
      // btnCancelar
      //
      this.btnCancelar.Location = new System.Drawing.Point(322, 376);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(178, 48);
      this.btnCancelar.TabIndex = 13;
      this.btnCancelar.Text = "Fechar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      //
      // btnClean
      //
      this.btnClean.Location = new System.Drawing.Point(601, 376);
      this.btnClean.Name = "btnClean";
      this.btnClean.Size = new System.Drawing.Size(178, 48);
      this.btnClean.TabIndex = 14;
      this.btnClean.Text = "Limpar Dados";
      this.btnClean.UseVisualStyleBackColor = true;
      this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
      //
      // txtTel
      //
      this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTel.Location = new System.Drawing.Point(227, 223);
      this.txtTel.Mask = "(00) 00000-0000";
      this.txtTel.Name = "txtTel";
      this.txtTel.Size = new System.Drawing.Size(168, 31);
      this.txtTel.TabIndex = 5;
      //
      // txtCPF
      //
      this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCPF.Location = new System.Drawing.Point(227, 185);
      this.txtCPF.Mask = "000,000,000-00";
      this.txtCPF.Name = "txtCPF";
      this.txtCPF.Size = new System.Drawing.Size(140, 29);
      this.txtCPF.TabIndex = 4;
      //
      // FormCadastro
      //
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.txtCPF);
      this.Controls.Add(this.txtTel);
      this.Controls.Add(this.btnClean);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnEnviar);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.txtNomeC);
      this.Controls.Add(this.txtUserPass);
      this.Controls.Add(this.txtUserName);
      this.Controls.Add(this.lblEmail);
      this.Controls.Add(this.lblTel);
      this.Controls.Add(this.lblCPF);
      this.Controls.Add(this.lblSenhaUser);
      this.Controls.Add(this.lblNomeC);
      this.Controls.Add(this.lblUserName);
      this.Name = "FormCadastro";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public FormCadastro()
    {
      InitializeComponent();
      
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      if (txtUserName.Text == "")
      {
        MessageBox.Show("Preencha o campo nome.");
        txtUserName.Focus();
        return;
      }
      if (txtUserPass.Text == "")
      {
        MessageBox.Show("Preencha o campo nome.");
        txtUserPass.Focus();
        return;
      }
      if (txtNomeC.Text == "")
      {
        MessageBox.Show("Preencha o campo nome.");
        txtNomeC.Focus();
        return;
      }
      if (txtCPF.Text == "")
      {
        MessageBox.Show("Preencha o campo nome.");
        txtCPF.Focus();
        return;
      }
      if (txtTel.Text == "(  )      -")
      {
        MessageBox.Show("Preencha o campo telefone.");
        txtTel.Focus();
        return;
      }
      if (txtEmail.Text == "")
      {
        MessageBox.Show("Preencha o campo telefone.");
        txtEmail.Focus();
        return;
      }

      List<Usuario> listaUsuarios = new List<Usuario>();

      Random random = new Random();
      int randomId = random.Next(1, 999999);

      Usuario novoUsuario = new Usuario
      {
        UserName = txtUserName.Text,
        Senha = txtUserPass.Text,
        NomeCompleto = txtNomeC.Text,
        CPF = txtCPF.Text,
        Telefone = txtTel.Text,
        Email = txtEmail.Text,
        ID = randomId.ToString()
      };

      listaUsuarios.Add(novoUsuario);

      try
      {
        string strConnection = "server=127.0.0.1;User Id=Piteco;database=relogio_ponto;password=Pitecoso123@";

        using (MySqlConnection conexao = new MySqlConnection(strConnection))
        {
          conexao.Open();

          using (MySqlCommand comando = new MySqlCommand())
          {
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO usuarios (id, user_name, password, nome_completo, cpf_user, tel_user, email) " +
                                  "VALUES (@id, @user_name, @password, @nome_completo, @cpf_user, @tel_user, @email)";
            comando.Parameters.AddWithValue("@id", novoUsuario.ID);
            comando.Parameters.AddWithValue("@user_name", novoUsuario.UserName);
            comando.Parameters.AddWithValue("@password", novoUsuario.Senha);
            comando.Parameters.AddWithValue("@nome_completo", novoUsuario.NomeCompleto);
            comando.Parameters.AddWithValue("@cpf_user", novoUsuario.CPF);
            comando.Parameters.AddWithValue("@tel_user", novoUsuario.Telefone);
            comando.Parameters.AddWithValue("@email", novoUsuario.Email);

            comando.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso!");
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro ao Cadastrar, por favor tente novamente! \n" + ex.Message);
      }

      Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnClean_Click(object sender, EventArgs e)
    {
      txtUserName.Text = string.Empty;
      txtUserPass.Text = string.Empty;
      txtNomeC.Text = string.Empty;
      txtCPF.Text = string.Empty;
      txtTel.Text = string.Empty;
      txtEmail.Text = string.Empty;
    }
  }
}