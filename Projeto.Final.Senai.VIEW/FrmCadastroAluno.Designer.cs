namespace Projeto.Final.Senai.VIEW
{
    partial class FrmCadastroAluno
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFoneResidencial = new System.Windows.Forms.Label();
            this.lblFoneComercial = new System.Windows.Forms.Label();
            this.lblFoneCelular = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFoneResidencial = new System.Windows.Forms.TextBox();
            this.txtFoneComercial = new System.Windows.Forms.TextBox();
            this.txtFoneCelular = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbxAlunos = new System.Windows.Forms.ListBox();
            this.lblAlunosCadastrados = new System.Windows.Forms.Label();
            this.btnCadastrarAlunos = new System.Windows.Forms.Button();
            this.lblObservacoesUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(36, 27);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(39, 13);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Cursos";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(36, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblFoneResidencial
            // 
            this.lblFoneResidencial.AutoSize = true;
            this.lblFoneResidencial.Location = new System.Drawing.Point(36, 116);
            this.lblFoneResidencial.Name = "lblFoneResidencial";
            this.lblFoneResidencial.Size = new System.Drawing.Size(89, 13);
            this.lblFoneResidencial.TabIndex = 2;
            this.lblFoneResidencial.Text = "Fone Residencial";
            // 
            // lblFoneComercial
            // 
            this.lblFoneComercial.AutoSize = true;
            this.lblFoneComercial.Location = new System.Drawing.Point(248, 116);
            this.lblFoneComercial.Name = "lblFoneComercial";
            this.lblFoneComercial.Size = new System.Drawing.Size(80, 13);
            this.lblFoneComercial.TabIndex = 3;
            this.lblFoneComercial.Text = "Fone Comercial";
            // 
            // lblFoneCelular
            // 
            this.lblFoneCelular.AutoSize = true;
            this.lblFoneCelular.Location = new System.Drawing.Point(453, 116);
            this.lblFoneCelular.Name = "lblFoneCelular";
            this.lblFoneCelular.Size = new System.Drawing.Size(66, 13);
            this.lblFoneCelular.TabIndex = 4;
            this.lblFoneCelular.Text = "Fone Celular";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(36, 154);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(36, 13);
            this.lblEMail.TabIndex = 5;
            this.lblEMail.Text = "E-Mail";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(36, 189);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(70, 13);
            this.lblObservacoes.TabIndex = 6;
            this.lblObservacoes.Text = "Observações";
            // 
            // cbxCurso
            // 
            this.cbxCurso.DisplayMember = "Curso_Detalhado";
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(81, 24);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(544, 21);
            this.cbxCurso.TabIndex = 7;
            this.cbxCurso.ValueMember = "Curso_Detalhado";
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.cbxCurso_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(544, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtFoneResidencial
            // 
            this.txtFoneResidencial.Location = new System.Drawing.Point(131, 113);
            this.txtFoneResidencial.Name = "txtFoneResidencial";
            this.txtFoneResidencial.Size = new System.Drawing.Size(100, 20);
            this.txtFoneResidencial.TabIndex = 9;
            // 
            // txtFoneComercial
            // 
            this.txtFoneComercial.Location = new System.Drawing.Point(334, 113);
            this.txtFoneComercial.Name = "txtFoneComercial";
            this.txtFoneComercial.Size = new System.Drawing.Size(100, 20);
            this.txtFoneComercial.TabIndex = 10;
            // 
            // txtFoneCelular
            // 
            this.txtFoneCelular.Location = new System.Drawing.Point(525, 113);
            this.txtFoneCelular.Name = "txtFoneCelular";
            this.txtFoneCelular.Size = new System.Drawing.Size(100, 20);
            this.txtFoneCelular.TabIndex = 11;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(81, 151);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(544, 20);
            this.txtEMail.TabIndex = 12;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(39, 216);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(586, 89);
            this.txtObservacoes.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(90, 348);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(167, 71);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lbxAlunos
            // 
            this.lbxAlunos.DisplayMember = "Nome";
            this.lbxAlunos.FormattingEnabled = true;
            this.lbxAlunos.Location = new System.Drawing.Point(315, 334);
            this.lbxAlunos.Name = "lbxAlunos";
            this.lbxAlunos.Size = new System.Drawing.Size(281, 108);
            this.lbxAlunos.TabIndex = 15;
            this.lbxAlunos.ValueMember = "Nome";
            // 
            // lblAlunosCadastrados
            // 
            this.lblAlunosCadastrados.AutoSize = true;
            this.lblAlunosCadastrados.Location = new System.Drawing.Point(373, 318);
            this.lblAlunosCadastrados.Name = "lblAlunosCadastrados";
            this.lblAlunosCadastrados.Size = new System.Drawing.Size(162, 13);
            this.lblAlunosCadastrados.TabIndex = 16;
            this.lblAlunosCadastrados.Text = "Alunos Cadastrados Neste Curso";
            // 
            // btnCadastrarAlunos
            // 
            this.btnCadastrarAlunos.Location = new System.Drawing.Point(198, 177);
            this.btnCadastrarAlunos.Name = "btnCadastrarAlunos";
            this.btnCadastrarAlunos.Size = new System.Drawing.Size(268, 33);
            this.btnCadastrarAlunos.TabIndex = 17;
            this.btnCadastrarAlunos.Text = "Cadastrar Alunos Neste Curso";
            this.btnCadastrarAlunos.UseVisualStyleBackColor = true;
            this.btnCadastrarAlunos.Click += new System.EventHandler(this.btnCadastrarAlunos_Click);
            // 
            // lblObservacoesUsuario
            // 
            this.lblObservacoesUsuario.AutoSize = true;
            this.lblObservacoesUsuario.Location = new System.Drawing.Point(87, 64);
            this.lblObservacoesUsuario.Name = "lblObservacoesUsuario";
            this.lblObservacoesUsuario.Size = new System.Drawing.Size(522, 13);
            this.lblObservacoesUsuario.TabIndex = 18;
            this.lblObservacoesUsuario.Text = "Observações: Selecione o curso desejado, Depois clique no botão abaixo para cadas" +
    "trar os alunos no curso.";
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 454);
            this.Controls.Add(this.lblObservacoesUsuario);
            this.Controls.Add(this.btnCadastrarAlunos);
            this.Controls.Add(this.lblAlunosCadastrados);
            this.Controls.Add(this.lbxAlunos);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.txtFoneCelular);
            this.Controls.Add(this.txtFoneComercial);
            this.Controls.Add(this.txtFoneResidencial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblFoneCelular);
            this.Controls.Add(this.lblFoneComercial);
            this.Controls.Add(this.lblFoneResidencial);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final Senai / Cadastro Alunos";
            this.Load += new System.EventHandler(this.FrmCadastroAluno_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroAluno_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFoneResidencial;
        private System.Windows.Forms.Label lblFoneComercial;
        private System.Windows.Forms.Label lblFoneCelular;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFoneResidencial;
        private System.Windows.Forms.TextBox txtFoneComercial;
        private System.Windows.Forms.TextBox txtFoneCelular;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox lbxAlunos;
        private System.Windows.Forms.Label lblAlunosCadastrados;
        private System.Windows.Forms.Button btnCadastrarAlunos;
        private System.Windows.Forms.Label lblObservacoesUsuario;
    }
}