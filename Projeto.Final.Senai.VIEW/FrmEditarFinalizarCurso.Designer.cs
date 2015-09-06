namespace Projeto.Final.Senai.VIEW
{
    partial class FrmEditarFinalizarCurso
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblHorasDias = new System.Windows.Forms.Label();
            this.lblTotalDias = new System.Windows.Forms.Label();
            this.cbbCursos = new System.Windows.Forms.ComboBox();
            this.txtCursos = new System.Windows.Forms.TextBox();
            this.lblInicioCurso = new System.Windows.Forms.Label();
            this.lblTerminoCurso = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtHorasDias = new System.Windows.Forms.TextBox();
            this.txtTotalDias = new System.Windows.Forms.TextBox();
            this.txtInicioCurso = new System.Windows.Forms.TextBox();
            this.txtTerminoCurso = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.ltbAlunos = new System.Windows.Forms.ListBox();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.btnFinazilarCurso = new System.Windows.Forms.Button();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAutenticar = new System.Windows.Forms.Button();
            this.btnCarregarCursos = new System.Windows.Forms.Button();
            this.lblCursosA = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblSemanaSabado = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtSemanaSabado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Location = new System.Drawing.Point(56, 18);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(39, 13);
            this.lblCursos.TabIndex = 0;
            this.lblCursos.Text = "Cursos";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(56, 118);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso";
            this.lblCurso.Visible = false;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(440, 122);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "Horário";
            this.lblHorario.Visible = false;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(54, 160);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(72, 13);
            this.lblCargaHoraria.TabIndex = 3;
            this.lblCargaHoraria.Text = "Carga Horária";
            this.lblCargaHoraria.Visible = false;
            // 
            // lblHorasDias
            // 
            this.lblHorasDias.AutoSize = true;
            this.lblHorasDias.Location = new System.Drawing.Point(283, 160);
            this.lblHorasDias.Name = "lblHorasDias";
            this.lblHorasDias.Size = new System.Drawing.Size(59, 13);
            this.lblHorasDias.TabIndex = 4;
            this.lblHorasDias.Text = "Horas Dias";
            this.lblHorasDias.Visible = false;
            // 
            // lblTotalDias
            // 
            this.lblTotalDias.AutoSize = true;
            this.lblTotalDias.Location = new System.Drawing.Point(484, 159);
            this.lblTotalDias.Name = "lblTotalDias";
            this.lblTotalDias.Size = new System.Drawing.Size(55, 13);
            this.lblTotalDias.TabIndex = 5;
            this.lblTotalDias.Text = "Total Dias";
            this.lblTotalDias.Visible = false;
            // 
            // cbbCursos
            // 
            this.cbbCursos.DisplayMember = "Curso_Detalhado";
            this.cbbCursos.FormattingEnabled = true;
            this.cbbCursos.Location = new System.Drawing.Point(107, 15);
            this.cbbCursos.Name = "cbbCursos";
            this.cbbCursos.Size = new System.Drawing.Size(597, 21);
            this.cbbCursos.TabIndex = 6;
            this.cbbCursos.ValueMember = "Curso_Detalhado";
            // 
            // txtCursos
            // 
            this.txtCursos.Enabled = false;
            this.txtCursos.Location = new System.Drawing.Point(107, 86);
            this.txtCursos.Name = "txtCursos";
            this.txtCursos.Size = new System.Drawing.Size(597, 20);
            this.txtCursos.TabIndex = 7;
            this.txtCursos.Visible = false;
            // 
            // lblInicioCurso
            // 
            this.lblInicioCurso.AutoSize = true;
            this.lblInicioCurso.Location = new System.Drawing.Point(54, 209);
            this.lblInicioCurso.Name = "lblInicioCurso";
            this.lblInicioCurso.Size = new System.Drawing.Size(64, 13);
            this.lblInicioCurso.TabIndex = 8;
            this.lblInicioCurso.Text = "Início Curso";
            this.lblInicioCurso.Visible = false;
            // 
            // lblTerminoCurso
            // 
            this.lblTerminoCurso.AutoSize = true;
            this.lblTerminoCurso.Location = new System.Drawing.Point(236, 209);
            this.lblTerminoCurso.Name = "lblTerminoCurso";
            this.lblTerminoCurso.Size = new System.Drawing.Size(75, 13);
            this.lblTerminoCurso.TabIndex = 9;
            this.lblTerminoCurso.Text = "Termino Curso";
            this.lblTerminoCurso.Visible = false;
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(433, 209);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 10;
            this.lblDocente.Text = "Docente";
            this.lblDocente.Visible = false;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(56, 257);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(60, 13);
            this.lblLaboratorio.TabIndex = 11;
            this.lblLaboratorio.Text = "Laboratório";
            this.lblLaboratorio.Visible = false;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(56, 338);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(70, 13);
            this.lblObservacoes.TabIndex = 12;
            this.lblObservacoes.Text = "Observaçoes";
            this.lblObservacoes.Visible = false;
            // 
            // txtCurso
            // 
            this.txtCurso.Enabled = false;
            this.txtCurso.Location = new System.Drawing.Point(96, 115);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(329, 20);
            this.txtCurso.TabIndex = 13;
            this.txtCurso.Visible = false;
            // 
            // txtHorario
            // 
            this.txtHorario.Enabled = false;
            this.txtHorario.Location = new System.Drawing.Point(487, 115);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(217, 20);
            this.txtHorario.TabIndex = 14;
            this.txtHorario.Visible = false;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Enabled = false;
            this.txtCargaHoraria.Location = new System.Drawing.Point(132, 156);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(127, 20);
            this.txtCargaHoraria.TabIndex = 15;
            this.txtCargaHoraria.Visible = false;
            // 
            // txtHorasDias
            // 
            this.txtHorasDias.Enabled = false;
            this.txtHorasDias.Location = new System.Drawing.Point(359, 157);
            this.txtHorasDias.Name = "txtHorasDias";
            this.txtHorasDias.Size = new System.Drawing.Size(110, 20);
            this.txtHorasDias.TabIndex = 16;
            this.txtHorasDias.Visible = false;
            // 
            // txtTotalDias
            // 
            this.txtTotalDias.Enabled = false;
            this.txtTotalDias.Location = new System.Drawing.Point(552, 156);
            this.txtTotalDias.Name = "txtTotalDias";
            this.txtTotalDias.Size = new System.Drawing.Size(152, 20);
            this.txtTotalDias.TabIndex = 17;
            this.txtTotalDias.Visible = false;
            // 
            // txtInicioCurso
            // 
            this.txtInicioCurso.Enabled = false;
            this.txtInicioCurso.Location = new System.Drawing.Point(124, 206);
            this.txtInicioCurso.Name = "txtInicioCurso";
            this.txtInicioCurso.Size = new System.Drawing.Size(95, 20);
            this.txtInicioCurso.TabIndex = 18;
            this.txtInicioCurso.Visible = false;
            // 
            // txtTerminoCurso
            // 
            this.txtTerminoCurso.Enabled = false;
            this.txtTerminoCurso.Location = new System.Drawing.Point(313, 206);
            this.txtTerminoCurso.Name = "txtTerminoCurso";
            this.txtTerminoCurso.Size = new System.Drawing.Size(94, 20);
            this.txtTerminoCurso.TabIndex = 19;
            this.txtTerminoCurso.Visible = false;
            // 
            // txtDocente
            // 
            this.txtDocente.Enabled = false;
            this.txtDocente.Location = new System.Drawing.Point(487, 206);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(216, 20);
            this.txtDocente.TabIndex = 20;
            this.txtDocente.Visible = false;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Enabled = false;
            this.txtLaboratorio.Location = new System.Drawing.Point(132, 254);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(190, 20);
            this.txtLaboratorio.TabIndex = 21;
            this.txtLaboratorio.Visible = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Enabled = false;
            this.txtObservacoes.Location = new System.Drawing.Point(57, 354);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(647, 71);
            this.txtObservacoes.TabIndex = 22;
            this.txtObservacoes.Visible = false;
            // 
            // ltbAlunos
            // 
            this.ltbAlunos.DisplayMember = "Nome";
            this.ltbAlunos.FormattingEnabled = true;
            this.ltbAlunos.Location = new System.Drawing.Point(737, 54);
            this.ltbAlunos.Name = "ltbAlunos";
            this.ltbAlunos.Size = new System.Drawing.Size(272, 147);
            this.ltbAlunos.TabIndex = 23;
            this.ltbAlunos.ValueMember = "Nome";
            this.ltbAlunos.Visible = false;
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Location = new System.Drawing.Point(822, 38);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(97, 13);
            this.lblAlunos.TabIndex = 24;
            this.lblAlunos.Text = "Alunos neste curso";
            this.lblAlunos.Visible = false;
            // 
            // btnFinazilarCurso
            // 
            this.btnFinazilarCurso.Location = new System.Drawing.Point(59, 435);
            this.btnFinazilarCurso.Name = "btnFinazilarCurso";
            this.btnFinazilarCurso.Size = new System.Drawing.Size(179, 79);
            this.btnFinazilarCurso.TabIndex = 25;
            this.btnFinazilarCurso.Text = "Finalizar Curso";
            this.btnFinazilarCurso.UseVisualStyleBackColor = true;
            this.btnFinazilarCurso.Visible = false;
            this.btnFinazilarCurso.Click += new System.EventHandler(this.btnFinazilarCurso_Click);
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.Location = new System.Drawing.Point(275, 435);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(177, 79);
            this.btnExcluirCurso.TabIndex = 26;
            this.btnExcluirCurso.Text = "Excluir Curso";
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            this.btnExcluirCurso.Visible = false;
            this.btnExcluirCurso.Click += new System.EventHandler(this.btnExcluirCurso_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(488, 435);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(216, 79);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar Informações sobre este Curso";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(760, 243);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(231, 89);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(757, 357);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 29;
            this.lblLogin.Text = "Login";
            this.lblLogin.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(757, 396);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 30;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(760, 373);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(231, 20);
            this.txtLogin.TabIndex = 31;
            this.txtLogin.Text = "humberto";
            this.txtLogin.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(760, 412);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(231, 20);
            this.txtSenha.TabIndex = 32;
            this.txtSenha.Text = "12345678";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Visible = false;
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.Location = new System.Drawing.Point(800, 460);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.Size = new System.Drawing.Size(151, 54);
            this.btnAutenticar.TabIndex = 33;
            this.btnAutenticar.Text = "Autenticar";
            this.btnAutenticar.UseVisualStyleBackColor = true;
            this.btnAutenticar.Visible = false;
            this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
            // 
            // btnCarregarCursos
            // 
            this.btnCarregarCursos.Location = new System.Drawing.Point(301, 42);
            this.btnCarregarCursos.Name = "btnCarregarCursos";
            this.btnCarregarCursos.Size = new System.Drawing.Size(196, 38);
            this.btnCarregarCursos.TabIndex = 34;
            this.btnCarregarCursos.Text = "Carregar cursos";
            this.btnCarregarCursos.UseVisualStyleBackColor = true;
            this.btnCarregarCursos.Visible = false;
            this.btnCarregarCursos.Click += new System.EventHandler(this.btnCarregarCursos_Click);
            // 
            // lblCursosA
            // 
            this.lblCursosA.AutoSize = true;
            this.lblCursosA.Location = new System.Drawing.Point(56, 89);
            this.lblCursosA.Name = "lblCursosA";
            this.lblCursosA.Size = new System.Drawing.Size(39, 13);
            this.lblCursosA.TabIndex = 35;
            this.lblCursosA.Text = "Cursos";
            this.lblCursosA.Visible = false;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(342, 257);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(31, 13);
            this.lblDias.TabIndex = 36;
            this.lblDias.Text = "Dias ";
            this.lblDias.Visible = false;
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(379, 254);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(324, 20);
            this.txtDias.TabIndex = 37;
            this.txtDias.Visible = false;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(56, 301);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(43, 13);
            this.lblPeriodo.TabIndex = 38;
            this.lblPeriodo.Text = "Periodo";
            this.lblPeriodo.Visible = false;
            // 
            // lblSemanaSabado
            // 
            this.lblSemanaSabado.AutoSize = true;
            this.lblSemanaSabado.Location = new System.Drawing.Point(351, 301);
            this.lblSemanaSabado.Name = "lblSemanaSabado";
            this.lblSemanaSabado.Size = new System.Drawing.Size(101, 13);
            this.lblSemanaSabado.TabIndex = 39;
            this.lblSemanaSabado.Text = "Semana ou Sabado";
            this.lblSemanaSabado.Visible = false;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Location = new System.Drawing.Point(105, 298);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(237, 20);
            this.txtPeriodo.TabIndex = 40;
            this.txtPeriodo.Visible = false;
            // 
            // txtSemanaSabado
            // 
            this.txtSemanaSabado.Enabled = false;
            this.txtSemanaSabado.Location = new System.Drawing.Point(458, 298);
            this.txtSemanaSabado.Name = "txtSemanaSabado";
            this.txtSemanaSabado.Size = new System.Drawing.Size(245, 20);
            this.txtSemanaSabado.TabIndex = 41;
            this.txtSemanaSabado.Visible = false;
            // 
            // FrmEditarFinalizarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 543);
            this.Controls.Add(this.txtSemanaSabado);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.lblSemanaSabado);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblCursosA);
            this.Controls.Add(this.btnCarregarCursos);
            this.Controls.Add(this.btnAutenticar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluirCurso);
            this.Controls.Add(this.btnFinazilarCurso);
            this.Controls.Add(this.lblAlunos);
            this.Controls.Add(this.ltbAlunos);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.txtTerminoCurso);
            this.Controls.Add(this.txtInicioCurso);
            this.Controls.Add(this.txtTotalDias);
            this.Controls.Add(this.txtHorasDias);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.lblTerminoCurso);
            this.Controls.Add(this.lblInicioCurso);
            this.Controls.Add(this.txtCursos);
            this.Controls.Add(this.cbbCursos);
            this.Controls.Add(this.lblTotalDias);
            this.Controls.Add(this.lblHorasDias);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEditarFinalizarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final Senai / Finalizar / Excluir / Alterar Cursos";
            this.Load += new System.EventHandler(this.FrmEditarFinalizarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label lblHorasDias;
        private System.Windows.Forms.Label lblTotalDias;
        private System.Windows.Forms.ComboBox cbbCursos;
        private System.Windows.Forms.TextBox txtCursos;
        private System.Windows.Forms.Label lblInicioCurso;
        private System.Windows.Forms.Label lblTerminoCurso;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtHorasDias;
        private System.Windows.Forms.TextBox txtTotalDias;
        private System.Windows.Forms.TextBox txtInicioCurso;
        private System.Windows.Forms.TextBox txtTerminoCurso;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.ListBox ltbAlunos;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Button btnFinazilarCurso;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.Button btnCarregarCursos;
        private System.Windows.Forms.Label lblCursosA;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblSemanaSabado;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtSemanaSabado;
    }
}