namespace Projeto.Final.Senai.VIEW
{
    partial class FrmRelatorio
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
            this.cbbRelatorio = new System.Windows.Forms.ComboBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAutenticar = new System.Windows.Forms.Button();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.btnConsultarRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbRelatorio
            // 
            this.cbbRelatorio.FormattingEnabled = true;
            this.cbbRelatorio.Items.AddRange(new object[] {
            "Cursos Ativos",
            "Cursos Finalizados",
            "Cursos Excluidos",
            "Alunos Excluidos",
            "Todos os Alunos",
            "Usuarios",
            "Calendario"});
            this.cbbRelatorio.Location = new System.Drawing.Point(29, 44);
            this.cbbRelatorio.Name = "cbbRelatorio";
            this.cbbRelatorio.Size = new System.Drawing.Size(738, 21);
            this.cbbRelatorio.TabIndex = 0;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(26, 28);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(229, 13);
            this.lblObservacoes.TabIndex = 1;
            this.lblObservacoes.Text = "Observações: Selecione o Relatório desejado .";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(174, 73);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            this.lblLogin.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(174, 120);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(177, 89);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(217, 20);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Text = "humberto";
            this.txtLogin.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(177, 136);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(217, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Text = "12345678";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Visible = false;
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.Location = new System.Drawing.Point(427, 89);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.Size = new System.Drawing.Size(161, 67);
            this.btnAutenticar.TabIndex = 6;
            this.btnAutenticar.Text = "Autenticar";
            this.btnAutenticar.UseVisualStyleBackColor = true;
            this.btnAutenticar.Visible = false;
            this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(29, 238);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(738, 267);
            this.dgvRelatorio.TabIndex = 7;
            // 
            // btnConsultarRelatorio
            // 
            this.btnConsultarRelatorio.Location = new System.Drawing.Point(278, 162);
            this.btnConsultarRelatorio.Name = "btnConsultarRelatorio";
            this.btnConsultarRelatorio.Size = new System.Drawing.Size(211, 60);
            this.btnConsultarRelatorio.TabIndex = 8;
            this.btnConsultarRelatorio.Text = "Consultar Relatório";
            this.btnConsultarRelatorio.UseVisualStyleBackColor = true;
            this.btnConsultarRelatorio.Click += new System.EventHandler(this.btnConsultarRelatorio_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 537);
            this.Controls.Add(this.btnConsultarRelatorio);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.btnAutenticar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.cbbRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final Senai / Relatório";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbRelatorio;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btnConsultarRelatorio;
    }
}