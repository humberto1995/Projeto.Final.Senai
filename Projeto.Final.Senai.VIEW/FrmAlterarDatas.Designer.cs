namespace Projeto.Final.Senai.VIEW
{
    partial class FrmAlterarDatas
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbbData = new System.Windows.Forms.ComboBox();
            this.lblAlterarData = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(65, 63);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 0;
            // 
            // cbbData
            // 
            this.cbbData.FormattingEnabled = true;
            this.cbbData.Items.AddRange(new object[] {
            "NORMAL",
            "FERIADO",
            "EMENDA"});
            this.cbbData.Location = new System.Drawing.Point(65, 102);
            this.cbbData.Name = "cbbData";
            this.cbbData.Size = new System.Drawing.Size(200, 21);
            this.cbbData.TabIndex = 1;
            // 
            // lblAlterarData
            // 
            this.lblAlterarData.AutoSize = true;
            this.lblAlterarData.Location = new System.Drawing.Point(123, 29);
            this.lblAlterarData.Name = "lblAlterarData";
            this.lblAlterarData.Size = new System.Drawing.Size(68, 13);
            this.lblAlterarData.TabIndex = 2;
            this.lblAlterarData.Text = "Alterar Datas";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(78, 144);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(172, 43);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // FrmAlterarDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 208);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblAlterarData);
            this.Controls.Add(this.cbbData);
            this.Controls.Add(this.dtpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAlterarDatas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final Senai / Alterar Datas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbbData;
        private System.Windows.Forms.Label lblAlterarData;
        private System.Windows.Forms.Button btnAlterar;
    }
}