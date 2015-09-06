namespace Projeto.Final.Senai.VIEW
{
    partial class FrmCadastrarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblObservacoesCadastrar = new System.Windows.Forms.Label();
            this.lblCadastrarLogin = new System.Windows.Forms.Label();
            this.lblCadastrarSenha = new System.Windows.Forms.Label();
            this.txtCadastrarLogin = new System.Windows.Forms.TextBox();
            this.txtCadastrarSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.lblObservacoesValidar = new System.Windows.Forms.Label();
            this.lblValidarLogin = new System.Windows.Forms.Label();
            this.lblValidarSenha = new System.Windows.Forms.Label();
            this.txtValidarLogin = new System.Windows.Forms.TextBox();
            this.txtValidarSenha = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblObservacoesCadastrar
            // 
            this.lblObservacoesCadastrar.AutoSize = true;
            this.lblObservacoesCadastrar.Location = new System.Drawing.Point(66, 23);
            this.lblObservacoesCadastrar.Name = "lblObservacoesCadastrar";
            this.lblObservacoesCadastrar.Size = new System.Drawing.Size(96, 13);
            this.lblObservacoesCadastrar.TabIndex = 0;
            this.lblObservacoesCadastrar.Text = "Cadastrar Usuarios";
            // 
            // lblCadastrarLogin
            // 
            this.lblCadastrarLogin.AutoSize = true;
            this.lblCadastrarLogin.Location = new System.Drawing.Point(12, 57);
            this.lblCadastrarLogin.Name = "lblCadastrarLogin";
            this.lblCadastrarLogin.Size = new System.Drawing.Size(81, 13);
            this.lblCadastrarLogin.TabIndex = 1;
            this.lblCadastrarLogin.Text = "Cadastrar Login";
            // 
            // lblCadastrarSenha
            // 
            this.lblCadastrarSenha.AutoSize = true;
            this.lblCadastrarSenha.Location = new System.Drawing.Point(12, 111);
            this.lblCadastrarSenha.Name = "lblCadastrarSenha";
            this.lblCadastrarSenha.Size = new System.Drawing.Size(86, 13);
            this.lblCadastrarSenha.TabIndex = 2;
            this.lblCadastrarSenha.Text = "Cadastrar Senha";
            // 
            // txtCadastrarLogin
            // 
            this.txtCadastrarLogin.Location = new System.Drawing.Point(15, 73);
            this.txtCadastrarLogin.Name = "txtCadastrarLogin";
            this.txtCadastrarLogin.Size = new System.Drawing.Size(211, 20);
            this.txtCadastrarLogin.TabIndex = 3;
            // 
            // txtCadastrarSenha
            // 
            this.txtCadastrarSenha.Location = new System.Drawing.Point(15, 127);
            this.txtCadastrarSenha.Name = "txtCadastrarSenha";
            this.txtCadastrarSenha.Size = new System.Drawing.Size(211, 20);
            this.txtCadastrarSenha.TabIndex = 4;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(48, 165);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(132, 65);
            this.btnCadastrarUsuario.TabIndex = 5;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuario";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // lblObservacoesValidar
            // 
            this.lblObservacoesValidar.AutoSize = true;
            this.lblObservacoesValidar.Location = new System.Drawing.Point(269, 23);
            this.lblObservacoesValidar.Name = "lblObservacoesValidar";
            this.lblObservacoesValidar.Size = new System.Drawing.Size(438, 13);
            this.lblObservacoesValidar.TabIndex = 6;
            this.lblObservacoesValidar.Text = "Observações: Para cadastrar um usuario novo precisa validar com Login e Senha Pri" +
    "ncipal.";
            this.lblObservacoesValidar.Visible = false;
            // 
            // lblValidarLogin
            // 
            this.lblValidarLogin.AutoSize = true;
            this.lblValidarLogin.Location = new System.Drawing.Point(347, 57);
            this.lblValidarLogin.Name = "lblValidarLogin";
            this.lblValidarLogin.Size = new System.Drawing.Size(68, 13);
            this.lblValidarLogin.TabIndex = 7;
            this.lblValidarLogin.Text = "Validar Login";
            this.lblValidarLogin.Visible = false;
            // 
            // lblValidarSenha
            // 
            this.lblValidarSenha.AutoSize = true;
            this.lblValidarSenha.Location = new System.Drawing.Point(347, 111);
            this.lblValidarSenha.Name = "lblValidarSenha";
            this.lblValidarSenha.Size = new System.Drawing.Size(73, 13);
            this.lblValidarSenha.TabIndex = 8;
            this.lblValidarSenha.Text = "Validar Senha";
            this.lblValidarSenha.Visible = false;
            // 
            // txtValidarLogin
            // 
            this.txtValidarLogin.Location = new System.Drawing.Point(350, 73);
            this.txtValidarLogin.Name = "txtValidarLogin";
            this.txtValidarLogin.Size = new System.Drawing.Size(280, 20);
            this.txtValidarLogin.TabIndex = 9;
            this.txtValidarLogin.Text = "humberto";
            this.txtValidarLogin.Visible = false;
            // 
            // txtValidarSenha
            // 
            this.txtValidarSenha.Location = new System.Drawing.Point(350, 127);
            this.txtValidarSenha.Name = "txtValidarSenha";
            this.txtValidarSenha.Size = new System.Drawing.Size(280, 20);
            this.txtValidarSenha.TabIndex = 10;
            this.txtValidarSenha.Text = "12345678";
            this.txtValidarSenha.UseSystemPasswordChar = true;
            this.txtValidarSenha.Visible = false;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(389, 165);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(199, 65);
            this.btnValidar.TabIndex = 11;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Visible = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // FrmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 250);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtValidarSenha);
            this.Controls.Add(this.txtValidarLogin);
            this.Controls.Add(this.lblValidarSenha);
            this.Controls.Add(this.lblValidarLogin);
            this.Controls.Add(this.lblObservacoesValidar);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.txtCadastrarSenha);
            this.Controls.Add(this.txtCadastrarLogin);
            this.Controls.Add(this.lblCadastrarSenha);
            this.Controls.Add(this.lblCadastrarLogin);
            this.Controls.Add(this.lblObservacoesCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final Senai / Cadastrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObservacoesCadastrar;
        private System.Windows.Forms.Label lblCadastrarLogin;
        private System.Windows.Forms.Label lblCadastrarSenha;
        private System.Windows.Forms.TextBox txtCadastrarLogin;
        private System.Windows.Forms.TextBox txtCadastrarSenha;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Label lblObservacoesValidar;
        private System.Windows.Forms.Label lblValidarLogin;
        private System.Windows.Forms.Label lblValidarSenha;
        private System.Windows.Forms.TextBox txtValidarLogin;
        private System.Windows.Forms.TextBox txtValidarSenha;
        private System.Windows.Forms.Button btnValidar;
    }
}