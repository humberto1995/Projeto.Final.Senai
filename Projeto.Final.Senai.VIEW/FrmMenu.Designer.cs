namespace Projeto.Final.Senai.VIEW
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.mspPrincipal = new System.Windows.Forms.MenuStrip();
            this.CursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFinalizarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDatasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lklSiteSenaiAnchieta = new System.Windows.Forms.LinkLabel();
            this.lklPortalSenaiSaoPaulo = new System.Windows.Forms.LinkLabel();
            this.mspPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspPrincipal
            // 
            this.mspPrincipal.BackColor = System.Drawing.Color.Red;
            this.mspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CursosToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.alterarDatasToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.mspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mspPrincipal.Name = "mspPrincipal";
            this.mspPrincipal.Size = new System.Drawing.Size(1273, 32);
            this.mspPrincipal.TabIndex = 1;
            this.mspPrincipal.Text = "menuStrip1";
            this.mspPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mspPrincipal_ItemClicked);
            // 
            // CursosToolStripMenuItem
            // 
            this.CursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeCursosToolStripMenuItem,
            this.visualizarCursosToolStripMenuItem,
            this.editarFinalizarCursosToolStripMenuItem});
            this.CursosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.CursosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem";
            this.CursosToolStripMenuItem.Size = new System.Drawing.Size(87, 28);
            this.CursosToolStripMenuItem.Text = "Cursos";
            this.CursosToolStripMenuItem.Click += new System.EventHandler(this.saToolStripMenuItem_Click);
            // 
            // cadastroDeCursosToolStripMenuItem
            // 
            this.cadastroDeCursosToolStripMenuItem.Name = "cadastroDeCursosToolStripMenuItem";
            this.cadastroDeCursosToolStripMenuItem.Size = new System.Drawing.Size(392, 28);
            this.cadastroDeCursosToolStripMenuItem.Text = "Cadastro de Cursos";
            this.cadastroDeCursosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCursosToolStripMenuItem_Click);
            // 
            // visualizarCursosToolStripMenuItem
            // 
            this.visualizarCursosToolStripMenuItem.Name = "visualizarCursosToolStripMenuItem";
            this.visualizarCursosToolStripMenuItem.Size = new System.Drawing.Size(392, 28);
            this.visualizarCursosToolStripMenuItem.Text = "Visualizar Cursos";
            this.visualizarCursosToolStripMenuItem.Click += new System.EventHandler(this.visualizarCursosToolStripMenuItem_Click);
            // 
            // editarFinalizarCursosToolStripMenuItem
            // 
            this.editarFinalizarCursosToolStripMenuItem.Name = "editarFinalizarCursosToolStripMenuItem";
            this.editarFinalizarCursosToolStripMenuItem.Size = new System.Drawing.Size(392, 28);
            this.editarFinalizarCursosToolStripMenuItem.Text = "Finalizar / Excluir / Alterar Cursos";
            this.editarFinalizarCursosToolStripMenuItem.Click += new System.EventHandler(this.editarFinalizarCursosToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroAlunosToolStripMenuItem,
            this.visualizarAlunosToolStripMenuItem,
            this.editarAlunosToolStripMenuItem});
            this.alunosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(87, 28);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // cadastroAlunosToolStripMenuItem
            // 
            this.cadastroAlunosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cadastroAlunosToolStripMenuItem.Name = "cadastroAlunosToolStripMenuItem";
            this.cadastroAlunosToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.cadastroAlunosToolStripMenuItem.Text = "Cadastro de Alunos";
            this.cadastroAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastroAlunosToolStripMenuItem_Click);
            // 
            // visualizarAlunosToolStripMenuItem
            // 
            this.visualizarAlunosToolStripMenuItem.Name = "visualizarAlunosToolStripMenuItem";
            this.visualizarAlunosToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.visualizarAlunosToolStripMenuItem.Text = "Visualizar Alunos";
            this.visualizarAlunosToolStripMenuItem.Click += new System.EventHandler(this.visualizarAlunosToolStripMenuItem_Click);
            // 
            // editarAlunosToolStripMenuItem
            // 
            this.editarAlunosToolStripMenuItem.Name = "editarAlunosToolStripMenuItem";
            this.editarAlunosToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.editarAlunosToolStripMenuItem.Text = "Excluir / Alterar Alunos";
            this.editarAlunosToolStripMenuItem.Click += new System.EventHandler(this.editarAlunosToolStripMenuItem_Click);
            // 
            // alterarDatasToolStripMenuItem
            // 
            this.alterarDatasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarDatasToolStripMenuItem1});
            this.alterarDatasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.alterarDatasToolStripMenuItem.Name = "alterarDatasToolStripMenuItem";
            this.alterarDatasToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.alterarDatasToolStripMenuItem.Text = "Datas";
            // 
            // alterarDatasToolStripMenuItem1
            // 
            this.alterarDatasToolStripMenuItem1.Name = "alterarDatasToolStripMenuItem1";
            this.alterarDatasToolStripMenuItem1.Size = new System.Drawing.Size(198, 28);
            this.alterarDatasToolStripMenuItem1.Text = "Alterar Datas";
            this.alterarDatasToolStripMenuItem1.Click += new System.EventHandler(this.alterarDatasToolStripMenuItem1_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarRelatórioToolStripMenuItem});
            this.relatórioToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // visualizarRelatórioToolStripMenuItem
            // 
            this.visualizarRelatórioToolStripMenuItem.Name = "visualizarRelatórioToolStripMenuItem";
            this.visualizarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.visualizarRelatórioToolStripMenuItem.Text = "Visualizar Relatório";
            this.visualizarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.visualizarRelatórioToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(93, 28);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cadastrarUsuarioToolStripMenuItem
            // 
            this.cadastrarUsuarioToolStripMenuItem.Name = "cadastrarUsuarioToolStripMenuItem";
            this.cadastrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.cadastrarUsuarioToolStripMenuItem.Text = "Cadastrar Usuario";
            this.cadastrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuarioToolStripMenuItem_Click);
            // 
            // lklSiteSenaiAnchieta
            // 
            this.lklSiteSenaiAnchieta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lklSiteSenaiAnchieta.AutoSize = true;
            this.lklSiteSenaiAnchieta.BackColor = System.Drawing.SystemColors.WindowText;
            this.lklSiteSenaiAnchieta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklSiteSenaiAnchieta.ForeColor = System.Drawing.Color.Red;
            this.lklSiteSenaiAnchieta.Location = new System.Drawing.Point(851, 72);
            this.lklSiteSenaiAnchieta.Name = "lklSiteSenaiAnchieta";
            this.lklSiteSenaiAnchieta.Size = new System.Drawing.Size(137, 31);
            this.lklSiteSenaiAnchieta.TabIndex = 3;
            this.lklSiteSenaiAnchieta.TabStop = true;
            this.lklSiteSenaiAnchieta.Text = "Site Senai";
            this.lklSiteSenaiAnchieta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSiteSenaiAnchieta_LinkClicked);
            // 
            // lklPortalSenaiSaoPaulo
            // 
            this.lklPortalSenaiSaoPaulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lklPortalSenaiSaoPaulo.AutoSize = true;
            this.lklPortalSenaiSaoPaulo.BackColor = System.Drawing.SystemColors.WindowText;
            this.lklPortalSenaiSaoPaulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklPortalSenaiSaoPaulo.ForeColor = System.Drawing.Color.Red;
            this.lklPortalSenaiSaoPaulo.Location = new System.Drawing.Point(831, 41);
            this.lklPortalSenaiSaoPaulo.Name = "lklPortalSenaiSaoPaulo";
            this.lklPortalSenaiSaoPaulo.Size = new System.Drawing.Size(250, 31);
            this.lklPortalSenaiSaoPaulo.TabIndex = 5;
            this.lklPortalSenaiSaoPaulo.TabStop = true;
            this.lklPortalSenaiSaoPaulo.Text = "Site Senai Anchieta";
            this.lklPortalSenaiSaoPaulo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklPortalSenaiSaoPaulo_LinkClicked);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 731);
            this.Controls.Add(this.lklPortalSenaiSaoPaulo);
            this.Controls.Add(this.lklSiteSenaiAnchieta);
            this.Controls.Add(this.mspPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Final  Senai / Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMenu_KeyDown);
            this.mspPrincipal.ResumeLayout(false);
            this.mspPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspPrincipal;
        private System.Windows.Forms.ToolStripMenuItem CursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFinalizarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarDatasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lklSiteSenaiAnchieta;
        private System.Windows.Forms.LinkLabel lklPortalSenaiSaoPaulo;
    }
}