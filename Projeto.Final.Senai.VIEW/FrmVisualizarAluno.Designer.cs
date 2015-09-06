namespace Projeto.Final.Senai.VIEW
{
    partial class FrmVisualizarAluno
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
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVisualizarAlunos = new System.Windows.Forms.Button();
            this.lblObservacoesUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(24, 22);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso";
            // 
            // cbxCurso
            // 
            this.cbxCurso.DisplayMember = "Curso_Detalhado";
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "Alunos"});
            this.cbxCurso.Location = new System.Drawing.Point(64, 19);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(552, 21);
            this.cbxCurso.TabIndex = 1;
            this.cbxCurso.ValueMember = "Curso_Detalhado";
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.cbxCurso_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(589, 199);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnVisualizarAlunos
            // 
            this.btnVisualizarAlunos.Location = new System.Drawing.Point(194, 86);
            this.btnVisualizarAlunos.Name = "btnVisualizarAlunos";
            this.btnVisualizarAlunos.Size = new System.Drawing.Size(258, 37);
            this.btnVisualizarAlunos.TabIndex = 3;
            this.btnVisualizarAlunos.Text = "Visualizar Alunos deste Curso";
            this.btnVisualizarAlunos.UseVisualStyleBackColor = true;
            this.btnVisualizarAlunos.Click += new System.EventHandler(this.btnVisualizarAlunos_Click);
            // 
            // lblObservacoesUsuario
            // 
            this.lblObservacoesUsuario.AutoSize = true;
            this.lblObservacoesUsuario.Location = new System.Drawing.Point(115, 56);
            this.lblObservacoesUsuario.Name = "lblObservacoesUsuario";
            this.lblObservacoesUsuario.Size = new System.Drawing.Size(436, 13);
            this.lblObservacoesUsuario.TabIndex = 4;
            this.lblObservacoesUsuario.Text = "Observações: Selecione o Curso desejado, Depois clique em visualizar alunos deste" +
    " curso.";
            // 
            // FrmVisualizarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 368);
            this.Controls.Add(this.lblObservacoesUsuario);
            this.Controls.Add(this.btnVisualizarAlunos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.lblCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVisualizarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final Senai / Visualizar Alunos";
            this.Load += new System.EventHandler(this.FrmVisualizarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVisualizarAlunos;
        private System.Windows.Forms.Label lblObservacoesUsuario;
    }
}