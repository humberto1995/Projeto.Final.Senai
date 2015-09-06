namespace Projeto.Final.Senai.VIEW
{
    partial class FrmEditarAlunos
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
            this.lblCursos = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFoneResidencial = new System.Windows.Forms.Label();
            this.lblFoneComercial = new System.Windows.Forms.Label();
            this.lblFoneCelular = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.cbbCursos = new System.Windows.Forms.ComboBox();
            this.cbbAlunos = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFoneResidencial = new System.Windows.Forms.TextBox();
            this.txtFoneComercial = new System.Windows.Forms.TextBox();
            this.txtFoneCelular = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnCarregarCursos = new System.Windows.Forms.Button();
            this.btnCarregarAlunos = new System.Windows.Forms.Button();
            this.lblAlunosCadastrados = new System.Windows.Forms.Label();
            this.ltbAlunosCadastrados = new System.Windows.Forms.ListBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAutenticar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluirAlunos = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Location = new System.Drawing.Point(31, 19);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(39, 13);
            this.lblCursos.TabIndex = 0;
            this.lblCursos.Text = "Cursos";
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Location = new System.Drawing.Point(31, 45);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(39, 13);
            this.lblAlunos.TabIndex = 1;
            this.lblAlunos.Text = "Alunos";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 119);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            this.lblNome.Visible = false;
            // 
            // lblFoneResidencial
            // 
            this.lblFoneResidencial.AutoSize = true;
            this.lblFoneResidencial.Location = new System.Drawing.Point(30, 162);
            this.lblFoneResidencial.Name = "lblFoneResidencial";
            this.lblFoneResidencial.Size = new System.Drawing.Size(89, 13);
            this.lblFoneResidencial.TabIndex = 3;
            this.lblFoneResidencial.Text = "Fone Residencial";
            this.lblFoneResidencial.Visible = false;
            // 
            // lblFoneComercial
            // 
            this.lblFoneComercial.AutoSize = true;
            this.lblFoneComercial.Location = new System.Drawing.Point(252, 162);
            this.lblFoneComercial.Name = "lblFoneComercial";
            this.lblFoneComercial.Size = new System.Drawing.Size(80, 13);
            this.lblFoneComercial.TabIndex = 4;
            this.lblFoneComercial.Text = "Fone Comercial";
            this.lblFoneComercial.Visible = false;
            // 
            // lblFoneCelular
            // 
            this.lblFoneCelular.AutoSize = true;
            this.lblFoneCelular.Location = new System.Drawing.Point(463, 162);
            this.lblFoneCelular.Name = "lblFoneCelular";
            this.lblFoneCelular.Size = new System.Drawing.Size(66, 13);
            this.lblFoneCelular.TabIndex = 5;
            this.lblFoneCelular.Text = "Fone Celular";
            this.lblFoneCelular.Visible = false;
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(31, 199);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(36, 13);
            this.lblEMail.TabIndex = 6;
            this.lblEMail.Text = "E-Mail";
            this.lblEMail.Visible = false;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(31, 246);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(70, 13);
            this.lblObservacoes.TabIndex = 7;
            this.lblObservacoes.Text = "Observações";
            this.lblObservacoes.Visible = false;
            // 
            // cbbCursos
            // 
            this.cbbCursos.DisplayMember = "Curso_Detalhado";
            this.cbbCursos.FormattingEnabled = true;
            this.cbbCursos.Location = new System.Drawing.Point(76, 16);
            this.cbbCursos.Name = "cbbCursos";
            this.cbbCursos.Size = new System.Drawing.Size(559, 21);
            this.cbbCursos.TabIndex = 8;
            this.cbbCursos.ValueMember = "Curso_Detalhado";
            // 
            // cbbAlunos
            // 
            this.cbbAlunos.DisplayMember = "Nome";
            this.cbbAlunos.Enabled = false;
            this.cbbAlunos.FormattingEnabled = true;
            this.cbbAlunos.Location = new System.Drawing.Point(76, 42);
            this.cbbAlunos.Name = "cbbAlunos";
            this.cbbAlunos.Size = new System.Drawing.Size(559, 21);
            this.cbbAlunos.TabIndex = 9;
            this.cbbAlunos.ValueMember = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(564, 20);
            this.txtNome.TabIndex = 10;
            this.txtNome.Visible = false;
            // 
            // txtFoneResidencial
            // 
            this.txtFoneResidencial.Location = new System.Drawing.Point(125, 159);
            this.txtFoneResidencial.Name = "txtFoneResidencial";
            this.txtFoneResidencial.Size = new System.Drawing.Size(100, 20);
            this.txtFoneResidencial.TabIndex = 11;
            this.txtFoneResidencial.Visible = false;
            // 
            // txtFoneComercial
            // 
            this.txtFoneComercial.Location = new System.Drawing.Point(338, 159);
            this.txtFoneComercial.Name = "txtFoneComercial";
            this.txtFoneComercial.Size = new System.Drawing.Size(100, 20);
            this.txtFoneComercial.TabIndex = 12;
            this.txtFoneComercial.Visible = false;
            // 
            // txtFoneCelular
            // 
            this.txtFoneCelular.Location = new System.Drawing.Point(535, 159);
            this.txtFoneCelular.Name = "txtFoneCelular";
            this.txtFoneCelular.Size = new System.Drawing.Size(100, 20);
            this.txtFoneCelular.TabIndex = 13;
            this.txtFoneCelular.Visible = false;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(71, 196);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(564, 20);
            this.txtEMail.TabIndex = 14;
            this.txtEMail.Visible = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(34, 262);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(601, 79);
            this.txtObservacoes.TabIndex = 15;
            this.txtObservacoes.Visible = false;
            // 
            // btnCarregarCursos
            // 
            this.btnCarregarCursos.Enabled = false;
            this.btnCarregarCursos.Location = new System.Drawing.Point(136, 69);
            this.btnCarregarCursos.Name = "btnCarregarCursos";
            this.btnCarregarCursos.Size = new System.Drawing.Size(196, 41);
            this.btnCarregarCursos.TabIndex = 16;
            this.btnCarregarCursos.Text = "Carregar Cursos";
            this.btnCarregarCursos.UseVisualStyleBackColor = true;
            this.btnCarregarCursos.Click += new System.EventHandler(this.btnCarregarCursos_Click);
            // 
            // btnCarregarAlunos
            // 
            this.btnCarregarAlunos.Enabled = false;
            this.btnCarregarAlunos.Location = new System.Drawing.Point(367, 69);
            this.btnCarregarAlunos.Name = "btnCarregarAlunos";
            this.btnCarregarAlunos.Size = new System.Drawing.Size(196, 41);
            this.btnCarregarAlunos.TabIndex = 17;
            this.btnCarregarAlunos.Text = "Carregar Alunos";
            this.btnCarregarAlunos.UseVisualStyleBackColor = true;
            this.btnCarregarAlunos.Click += new System.EventHandler(this.btnCarregarAlunos_Click);
            // 
            // lblAlunosCadastrados
            // 
            this.lblAlunosCadastrados.AutoSize = true;
            this.lblAlunosCadastrados.Location = new System.Drawing.Point(696, 24);
            this.lblAlunosCadastrados.Name = "lblAlunosCadastrados";
            this.lblAlunosCadastrados.Size = new System.Drawing.Size(160, 13);
            this.lblAlunosCadastrados.TabIndex = 18;
            this.lblAlunosCadastrados.Text = "Alunos Cadastrados neste Curso";
            this.lblAlunosCadastrados.Visible = false;
            // 
            // ltbAlunosCadastrados
            // 
            this.ltbAlunosCadastrados.DisplayMember = "Nome";
            this.ltbAlunosCadastrados.Enabled = false;
            this.ltbAlunosCadastrados.FormattingEnabled = true;
            this.ltbAlunosCadastrados.Location = new System.Drawing.Point(673, 45);
            this.ltbAlunosCadastrados.Name = "ltbAlunosCadastrados";
            this.ltbAlunosCadastrados.Size = new System.Drawing.Size(214, 134);
            this.ltbAlunosCadastrados.TabIndex = 19;
            this.ltbAlunosCadastrados.ValueMember = "Nome";
            this.ltbAlunosCadastrados.Visible = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(674, 256);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "Login";
            this.lblLogin.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(674, 305);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 21;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(677, 272);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(210, 20);
            this.txtLogin.TabIndex = 22;
            this.txtLogin.Text = "humberto";
            this.txtLogin.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(677, 321);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(210, 20);
            this.txtSenha.TabIndex = 23;
            this.txtSenha.Text = "12345678";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Visible = false;
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.Location = new System.Drawing.Point(699, 352);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.Size = new System.Drawing.Size(170, 62);
            this.btnAutenticar.TabIndex = 24;
            this.btnAutenticar.Text = "Autenticar";
            this.btnAutenticar.UseVisualStyleBackColor = true;
            this.btnAutenticar.Visible = false;
            this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(673, 185);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(214, 64);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluirAlunos
            // 
            this.btnExcluirAlunos.Location = new System.Drawing.Point(87, 352);
            this.btnExcluirAlunos.Name = "btnExcluirAlunos";
            this.btnExcluirAlunos.Size = new System.Drawing.Size(225, 62);
            this.btnExcluirAlunos.TabIndex = 26;
            this.btnExcluirAlunos.Text = "Excluir Alunos";
            this.btnExcluirAlunos.UseVisualStyleBackColor = true;
            this.btnExcluirAlunos.Visible = false;
            this.btnExcluirAlunos.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(352, 352);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(225, 62);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar informações sobre esse aluno";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // FrmEditarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 436);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluirAlunos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAutenticar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.ltbAlunosCadastrados);
            this.Controls.Add(this.lblAlunosCadastrados);
            this.Controls.Add(this.btnCarregarAlunos);
            this.Controls.Add(this.btnCarregarCursos);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.txtFoneCelular);
            this.Controls.Add(this.txtFoneComercial);
            this.Controls.Add(this.txtFoneResidencial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbbAlunos);
            this.Controls.Add(this.cbbCursos);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblFoneCelular);
            this.Controls.Add(this.lblFoneComercial);
            this.Controls.Add(this.lblFoneResidencial);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblAlunos);
            this.Controls.Add(this.lblCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEditarAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final Senai / Excluir / Alterar Alunos";
            this.Load += new System.EventHandler(this.FrmEditarAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFoneResidencial;
        private System.Windows.Forms.Label lblFoneComercial;
        private System.Windows.Forms.Label lblFoneCelular;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.ComboBox cbbCursos;
        private System.Windows.Forms.ComboBox cbbAlunos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFoneResidencial;
        private System.Windows.Forms.TextBox txtFoneComercial;
        private System.Windows.Forms.TextBox txtFoneCelular;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnCarregarCursos;
        private System.Windows.Forms.Button btnCarregarAlunos;
        private System.Windows.Forms.Label lblAlunosCadastrados;
        private System.Windows.Forms.ListBox ltbAlunosCadastrados;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluirAlunos;
        private System.Windows.Forms.Button btnAlterar;
    }
}