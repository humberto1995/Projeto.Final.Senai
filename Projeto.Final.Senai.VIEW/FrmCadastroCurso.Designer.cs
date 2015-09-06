namespace Projeto.Final.Senai.VIEW
{
    partial class FrmCadastroCurso
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
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.pnlPeriodo = new System.Windows.Forms.Panel();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.rbnIntegral = new System.Windows.Forms.RadioButton();
            this.rbnNoite = new System.Windows.Forms.RadioButton();
            this.rbnTarde = new System.Windows.Forms.RadioButton();
            this.rbnManha = new System.Windows.Forms.RadioButton();
            this.pnlDiasSemana = new System.Windows.Forms.Panel();
            this.lblDiasSemana = new System.Windows.Forms.Label();
            this.cbxSabado = new System.Windows.Forms.CheckBox();
            this.cbxSexta = new System.Windows.Forms.CheckBox();
            this.cbxQuinta = new System.Windows.Forms.CheckBox();
            this.cbxQuarta = new System.Windows.Forms.CheckBox();
            this.cbxTerca = new System.Windows.Forms.CheckBox();
            this.cbxSegunda = new System.Windows.Forms.CheckBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cbxHorarioEntrada = new System.Windows.Forms.ComboBox();
            this.cbxHorarioSaida = new System.Windows.Forms.ComboBox();
            this.lblAs = new System.Windows.Forms.Label();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblHorasDias = new System.Windows.Forms.Label();
            this.lblTotalDias = new System.Windows.Forms.Label();
            this.lblInicioCurso = new System.Windows.Forms.Label();
            this.lblTerminoCurso = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.Observacoes = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtHorasDias = new System.Windows.Forms.TextBox();
            this.txtTotalDias = new System.Windows.Forms.TextBox();
            this.dtpInicioCurso = new System.Windows.Forms.DateTimePicker();
            this.txtTerminoCurso = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtInicioCurso = new System.Windows.Forms.TextBox();
            this.pnlSemanaSabado = new System.Windows.Forms.Panel();
            this.rbnSabado = new System.Windows.Forms.RadioButton();
            this.rbnSemana = new System.Windows.Forms.RadioButton();
            this.pnlPeriodo.SuspendLayout();
            this.pnlDiasSemana.SuspendLayout();
            this.pnlSemanaSabado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(12, 9);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso";
            // 
            // txtCurso
            // 
            this.txtCurso.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCurso.Location = new System.Drawing.Point(52, 6);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(412, 20);
            this.txtCurso.TabIndex = 2;
            this.txtCurso.Text = "Escreva o nome do Curso(Campo Obrigatório)";
            this.txtCurso.Click += new System.EventHandler(this.txtCurso_Click);
            this.txtCurso.TextChanged += new System.EventHandler(this.txtCurso_TextChanged);
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.Controls.Add(this.lblPeriodo);
            this.pnlPeriodo.Controls.Add(this.rbnIntegral);
            this.pnlPeriodo.Controls.Add(this.rbnNoite);
            this.pnlPeriodo.Controls.Add(this.rbnTarde);
            this.pnlPeriodo.Controls.Add(this.rbnManha);
            this.pnlPeriodo.Location = new System.Drawing.Point(33, 44);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(167, 104);
            this.pnlPeriodo.TabIndex = 3;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(56, 5);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(43, 13);
            this.lblPeriodo.TabIndex = 5;
            this.lblPeriodo.Text = "Periodo";
            // 
            // rbnIntegral
            // 
            this.rbnIntegral.AutoSize = true;
            this.rbnIntegral.Location = new System.Drawing.Point(89, 52);
            this.rbnIntegral.Name = "rbnIntegral";
            this.rbnIntegral.Size = new System.Drawing.Size(60, 17);
            this.rbnIntegral.TabIndex = 3;
            this.rbnIntegral.TabStop = true;
            this.rbnIntegral.Text = "Integral";
            this.rbnIntegral.UseVisualStyleBackColor = true;
            // 
            // rbnNoite
            // 
            this.rbnNoite.AutoSize = true;
            this.rbnNoite.Location = new System.Drawing.Point(9, 52);
            this.rbnNoite.Name = "rbnNoite";
            this.rbnNoite.Size = new System.Drawing.Size(50, 17);
            this.rbnNoite.TabIndex = 2;
            this.rbnNoite.TabStop = true;
            this.rbnNoite.Text = "Noite";
            this.rbnNoite.UseVisualStyleBackColor = true;
            // 
            // rbnTarde
            // 
            this.rbnTarde.AutoSize = true;
            this.rbnTarde.Location = new System.Drawing.Point(89, 28);
            this.rbnTarde.Name = "rbnTarde";
            this.rbnTarde.Size = new System.Drawing.Size(53, 17);
            this.rbnTarde.TabIndex = 1;
            this.rbnTarde.TabStop = true;
            this.rbnTarde.Text = "Tarde";
            this.rbnTarde.UseVisualStyleBackColor = true;
            // 
            // rbnManha
            // 
            this.rbnManha.AutoSize = true;
            this.rbnManha.Location = new System.Drawing.Point(9, 28);
            this.rbnManha.Name = "rbnManha";
            this.rbnManha.Size = new System.Drawing.Size(58, 17);
            this.rbnManha.TabIndex = 0;
            this.rbnManha.TabStop = true;
            this.rbnManha.Text = "Manhã";
            this.rbnManha.UseVisualStyleBackColor = true;
            // 
            // pnlDiasSemana
            // 
            this.pnlDiasSemana.Controls.Add(this.lblDiasSemana);
            this.pnlDiasSemana.Controls.Add(this.cbxSabado);
            this.pnlDiasSemana.Controls.Add(this.cbxSexta);
            this.pnlDiasSemana.Controls.Add(this.cbxQuinta);
            this.pnlDiasSemana.Controls.Add(this.cbxQuarta);
            this.pnlDiasSemana.Controls.Add(this.cbxTerca);
            this.pnlDiasSemana.Controls.Add(this.cbxSegunda);
            this.pnlDiasSemana.Location = new System.Drawing.Point(228, 44);
            this.pnlDiasSemana.Name = "pnlDiasSemana";
            this.pnlDiasSemana.Size = new System.Drawing.Size(217, 104);
            this.pnlDiasSemana.TabIndex = 4;
            // 
            // lblDiasSemana
            // 
            this.lblDiasSemana.AutoSize = true;
            this.lblDiasSemana.Location = new System.Drawing.Point(61, 5);
            this.lblDiasSemana.Name = "lblDiasSemana";
            this.lblDiasSemana.Size = new System.Drawing.Size(85, 13);
            this.lblDiasSemana.TabIndex = 6;
            this.lblDiasSemana.Text = "Dias da Semana";
            // 
            // cbxSabado
            // 
            this.cbxSabado.AutoSize = true;
            this.cbxSabado.Location = new System.Drawing.Point(139, 75);
            this.cbxSabado.Name = "cbxSabado";
            this.cbxSabado.Size = new System.Drawing.Size(63, 17);
            this.cbxSabado.TabIndex = 5;
            this.cbxSabado.Text = "Sabado";
            this.cbxSabado.UseVisualStyleBackColor = true;
            this.cbxSabado.CheckedChanged += new System.EventHandler(this.cbxSabado_CheckedChanged);
            // 
            // cbxSexta
            // 
            this.cbxSexta.AutoSize = true;
            this.cbxSexta.Location = new System.Drawing.Point(139, 52);
            this.cbxSexta.Name = "cbxSexta";
            this.cbxSexta.Size = new System.Drawing.Size(53, 17);
            this.cbxSexta.TabIndex = 4;
            this.cbxSexta.Text = "Sexta";
            this.cbxSexta.UseVisualStyleBackColor = true;
            this.cbxSexta.CheckedChanged += new System.EventHandler(this.cbxSexta_CheckedChanged);
            // 
            // cbxQuinta
            // 
            this.cbxQuinta.AutoSize = true;
            this.cbxQuinta.Location = new System.Drawing.Point(139, 28);
            this.cbxQuinta.Name = "cbxQuinta";
            this.cbxQuinta.Size = new System.Drawing.Size(57, 17);
            this.cbxQuinta.TabIndex = 3;
            this.cbxQuinta.Text = "Quinta";
            this.cbxQuinta.UseVisualStyleBackColor = true;
            this.cbxQuinta.CheckedChanged += new System.EventHandler(this.cbxQuinta_CheckedChanged);
            // 
            // cbxQuarta
            // 
            this.cbxQuarta.AutoSize = true;
            this.cbxQuarta.Location = new System.Drawing.Point(16, 75);
            this.cbxQuarta.Name = "cbxQuarta";
            this.cbxQuarta.Size = new System.Drawing.Size(58, 17);
            this.cbxQuarta.TabIndex = 2;
            this.cbxQuarta.Text = "Quarta";
            this.cbxQuarta.UseVisualStyleBackColor = true;
            this.cbxQuarta.CheckedChanged += new System.EventHandler(this.cbxQuarta_CheckedChanged);
            // 
            // cbxTerca
            // 
            this.cbxTerca.AutoSize = true;
            this.cbxTerca.Location = new System.Drawing.Point(16, 52);
            this.cbxTerca.Name = "cbxTerca";
            this.cbxTerca.Size = new System.Drawing.Size(54, 17);
            this.cbxTerca.TabIndex = 1;
            this.cbxTerca.Text = "Terça";
            this.cbxTerca.UseVisualStyleBackColor = true;
            this.cbxTerca.CheckedChanged += new System.EventHandler(this.cbxTerca_CheckedChanged);
            // 
            // cbxSegunda
            // 
            this.cbxSegunda.AutoSize = true;
            this.cbxSegunda.Location = new System.Drawing.Point(16, 28);
            this.cbxSegunda.Name = "cbxSegunda";
            this.cbxSegunda.Size = new System.Drawing.Size(69, 17);
            this.cbxSegunda.TabIndex = 0;
            this.cbxSegunda.Text = "Segunda";
            this.cbxSegunda.UseVisualStyleBackColor = true;
            this.cbxSegunda.CheckedChanged += new System.EventHandler(this.cbxSegunda_CheckedChanged);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(12, 187);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 5;
            this.lblHorario.Text = "Horário";
            // 
            // cbxHorarioEntrada
            // 
            this.cbxHorarioEntrada.FormattingEnabled = true;
            this.cbxHorarioEntrada.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.cbxHorarioEntrada.Location = new System.Drawing.Point(59, 184);
            this.cbxHorarioEntrada.Name = "cbxHorarioEntrada";
            this.cbxHorarioEntrada.Size = new System.Drawing.Size(76, 21);
            this.cbxHorarioEntrada.TabIndex = 6;
            // 
            // cbxHorarioSaida
            // 
            this.cbxHorarioSaida.FormattingEnabled = true;
            this.cbxHorarioSaida.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.cbxHorarioSaida.Location = new System.Drawing.Point(181, 184);
            this.cbxHorarioSaida.Name = "cbxHorarioSaida";
            this.cbxHorarioSaida.Size = new System.Drawing.Size(76, 21);
            this.cbxHorarioSaida.TabIndex = 7;
            // 
            // lblAs
            // 
            this.lblAs.AutoSize = true;
            this.lblAs.Location = new System.Drawing.Point(148, 187);
            this.lblAs.Name = "lblAs";
            this.lblAs.Size = new System.Drawing.Size(18, 13);
            this.lblAs.TabIndex = 8;
            this.lblAs.Text = "às";
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(12, 222);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(72, 13);
            this.lblCargaHoraria.TabIndex = 9;
            this.lblCargaHoraria.Text = "Carga Horária";
            // 
            // lblHorasDias
            // 
            this.lblHorasDias.AutoSize = true;
            this.lblHorasDias.Location = new System.Drawing.Point(174, 222);
            this.lblHorasDias.Name = "lblHorasDias";
            this.lblHorasDias.Size = new System.Drawing.Size(59, 13);
            this.lblHorasDias.TabIndex = 10;
            this.lblHorasDias.Text = "Horas Dias";
            // 
            // lblTotalDias
            // 
            this.lblTotalDias.AutoSize = true;
            this.lblTotalDias.Location = new System.Drawing.Point(325, 222);
            this.lblTotalDias.Name = "lblTotalDias";
            this.lblTotalDias.Size = new System.Drawing.Size(55, 13);
            this.lblTotalDias.TabIndex = 11;
            this.lblTotalDias.Text = "Total Dias";
            // 
            // lblInicioCurso
            // 
            this.lblInicioCurso.AutoSize = true;
            this.lblInicioCurso.Location = new System.Drawing.Point(12, 261);
            this.lblInicioCurso.Name = "lblInicioCurso";
            this.lblInicioCurso.Size = new System.Drawing.Size(64, 13);
            this.lblInicioCurso.TabIndex = 12;
            this.lblInicioCurso.Text = "Início Curso";
            // 
            // lblTerminoCurso
            // 
            this.lblTerminoCurso.AutoSize = true;
            this.lblTerminoCurso.Location = new System.Drawing.Point(283, 257);
            this.lblTerminoCurso.Name = "lblTerminoCurso";
            this.lblTerminoCurso.Size = new System.Drawing.Size(75, 13);
            this.lblTerminoCurso.TabIndex = 13;
            this.lblTerminoCurso.Text = "Termino Curso";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(12, 298);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 14;
            this.lblDocente.Text = "Docente";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(314, 298);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(60, 13);
            this.lblLaboratorio.TabIndex = 15;
            this.lblLaboratorio.Text = "Laboratório";
            // 
            // Observacoes
            // 
            this.Observacoes.AutoSize = true;
            this.Observacoes.Location = new System.Drawing.Point(14, 335);
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.Size = new System.Drawing.Size(70, 13);
            this.Observacoes.TabIndex = 16;
            this.Observacoes.Text = "Observações";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(90, 219);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(71, 20);
            this.txtCargaHoraria.TabIndex = 17;
            // 
            // txtHorasDias
            // 
            this.txtHorasDias.Location = new System.Drawing.Point(239, 219);
            this.txtHorasDias.Name = "txtHorasDias";
            this.txtHorasDias.Size = new System.Drawing.Size(71, 20);
            this.txtHorasDias.TabIndex = 18;
            // 
            // txtTotalDias
            // 
            this.txtTotalDias.Location = new System.Drawing.Point(393, 219);
            this.txtTotalDias.Name = "txtTotalDias";
            this.txtTotalDias.Size = new System.Drawing.Size(71, 20);
            this.txtTotalDias.TabIndex = 19;
            // 
            // dtpInicioCurso
            // 
            this.dtpInicioCurso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioCurso.Location = new System.Drawing.Point(82, 255);
            this.dtpInicioCurso.Name = "dtpInicioCurso";
            this.dtpInicioCurso.Size = new System.Drawing.Size(93, 20);
            this.dtpInicioCurso.TabIndex = 20;
            // 
            // txtTerminoCurso
            // 
            this.txtTerminoCurso.Location = new System.Drawing.Point(364, 254);
            this.txtTerminoCurso.Name = "txtTerminoCurso";
            this.txtTerminoCurso.Size = new System.Drawing.Size(100, 20);
            this.txtTerminoCurso.TabIndex = 21;
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(66, 295);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(232, 20);
            this.txtDocente.TabIndex = 22;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(380, 295);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(84, 20);
            this.txtLaboratorio.TabIndex = 23;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtObservacoes.Location = new System.Drawing.Point(15, 351);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(449, 99);
            this.txtObservacoes.TabIndex = 24;
            this.txtObservacoes.Text = "Escreva Algumas Observações(Campo não é Obrigatório,Clique para Limpar o Campo)";
            this.txtObservacoes.Click += new System.EventHandler(this.txtObservacoes_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(171, 465);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(131, 62);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtInicioCurso
            // 
            this.txtInicioCurso.Location = new System.Drawing.Point(181, 254);
            this.txtInicioCurso.Name = "txtInicioCurso";
            this.txtInicioCurso.Size = new System.Drawing.Size(91, 20);
            this.txtInicioCurso.TabIndex = 26;
            // 
            // pnlSemanaSabado
            // 
            this.pnlSemanaSabado.Controls.Add(this.rbnSabado);
            this.pnlSemanaSabado.Controls.Add(this.rbnSemana);
            this.pnlSemanaSabado.Location = new System.Drawing.Point(275, 171);
            this.pnlSemanaSabado.Name = "pnlSemanaSabado";
            this.pnlSemanaSabado.Size = new System.Drawing.Size(189, 42);
            this.pnlSemanaSabado.TabIndex = 27;
            // 
            // rbnSabado
            // 
            this.rbnSabado.AutoSize = true;
            this.rbnSabado.Location = new System.Drawing.Point(105, 14);
            this.rbnSabado.Name = "rbnSabado";
            this.rbnSabado.Size = new System.Drawing.Size(62, 17);
            this.rbnSabado.TabIndex = 1;
            this.rbnSabado.TabStop = true;
            this.rbnSabado.Text = "Sábado";
            this.rbnSabado.UseVisualStyleBackColor = true;
            // 
            // rbnSemana
            // 
            this.rbnSemana.AutoSize = true;
            this.rbnSemana.Location = new System.Drawing.Point(19, 14);
            this.rbnSemana.Name = "rbnSemana";
            this.rbnSemana.Size = new System.Drawing.Size(64, 17);
            this.rbnSemana.TabIndex = 0;
            this.rbnSemana.TabStop = true;
            this.rbnSemana.Text = "Semana";
            this.rbnSemana.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 539);
            this.Controls.Add(this.pnlSemanaSabado);
            this.Controls.Add(this.txtInicioCurso);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.txtTerminoCurso);
            this.Controls.Add(this.dtpInicioCurso);
            this.Controls.Add(this.txtTotalDias);
            this.Controls.Add(this.txtHorasDias);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.Observacoes);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.lblTerminoCurso);
            this.Controls.Add(this.lblInicioCurso);
            this.Controls.Add(this.lblTotalDias);
            this.Controls.Add(this.lblHorasDias);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.lblAs);
            this.Controls.Add(this.cbxHorarioSaida);
            this.Controls.Add(this.cbxHorarioEntrada);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.pnlDiasSemana);
            this.Controls.Add(this.pnlPeriodo);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadastroCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final Senai / Cadastro de Cursos";
            this.Load += new System.EventHandler(this.FrmCadastroCurso_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroCurso_KeyDown);
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            this.pnlDiasSemana.ResumeLayout(false);
            this.pnlDiasSemana.PerformLayout();
            this.pnlSemanaSabado.ResumeLayout(false);
            this.pnlSemanaSabado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Panel pnlPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.RadioButton rbnIntegral;
        private System.Windows.Forms.RadioButton rbnNoite;
        private System.Windows.Forms.RadioButton rbnTarde;
        private System.Windows.Forms.RadioButton rbnManha;
        private System.Windows.Forms.Panel pnlDiasSemana;
        private System.Windows.Forms.Label lblDiasSemana;
        private System.Windows.Forms.CheckBox cbxSabado;
        private System.Windows.Forms.CheckBox cbxSexta;
        private System.Windows.Forms.CheckBox cbxQuinta;
        private System.Windows.Forms.CheckBox cbxQuarta;
        private System.Windows.Forms.CheckBox cbxTerca;
        private System.Windows.Forms.CheckBox cbxSegunda;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cbxHorarioEntrada;
        private System.Windows.Forms.ComboBox cbxHorarioSaida;
        private System.Windows.Forms.Label lblAs;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label lblHorasDias;
        private System.Windows.Forms.Label lblTotalDias;
        private System.Windows.Forms.Label lblInicioCurso;
        private System.Windows.Forms.Label lblTerminoCurso;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label Observacoes;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtHorasDias;
        private System.Windows.Forms.TextBox txtTotalDias;
        private System.Windows.Forms.DateTimePicker dtpInicioCurso;
        private System.Windows.Forms.TextBox txtTerminoCurso;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtInicioCurso;
        private System.Windows.Forms.Panel pnlSemanaSabado;
        private System.Windows.Forms.RadioButton rbnSabado;
        private System.Windows.Forms.RadioButton rbnSemana;
    }
}