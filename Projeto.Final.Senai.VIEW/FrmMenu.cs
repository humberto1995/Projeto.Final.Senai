using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Final.Senai.VIEW
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        //apenas um formulario aberto
        public void FecharTodos()
        {
            if(this.MdiChildren.Length > 0)
            {
                ActiveMdiChild.Close();
            }
        }

        private void saToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastroCurso>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCadastroCurso>().First().Focus();
            }
            else
            {
                FrmCadastroCurso CadastroCurso = new FrmCadastroCurso();
                CadastroCurso.MdiParent = this;
                CadastroCurso.Show();
            }
        }

        private void visualizarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVisualizarCurso>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmVisualizarCurso>().First().Focus();
            }
            else
            {
                FrmVisualizarCurso VisualizarCurso = new FrmVisualizarCurso();
                VisualizarCurso.MdiParent = this;
                VisualizarCurso.Show();
            }
        }

        private void cadastroAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastroAluno>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCadastroAluno>().First().Focus();
            }
            else
            {
                FrmCadastroAluno CadastroAluno = new FrmCadastroAluno();
                CadastroAluno.MdiParent = this;
                CadastroAluno.Show();
            }
        }

        private void visualizarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmVisualizarAluno>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmVisualizarAluno>().First().Focus();
            }
            else
            {
                FrmVisualizarAluno VisualizarAluno = new FrmVisualizarAluno();
                VisualizarAluno.MdiParent = this;
                VisualizarAluno.Show();
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms.OfType<FrmVisualizarCurso>().Count() > 0)
        //    {
        //        Application.OpenForms.OfType<FrmVisualizarCurso>().First().Focus();
        //    }
        //    else
        //    {
        //        FrmCadastroCurso CadastroCurso = new FrmCadastroCurso();
        //        CadastroCurso.MdiParent = this;
        //        CadastroCurso.Show();
        //    }
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms.OfType<FrmVisualizarCurso>().Count() > 0)
        //    {
        //        Application.OpenForms.OfType<FrmVisualizarCurso>().First().Focus();
        //    }
        //    else
        //    {
        //        FrmVisualizarCurso VisualizarCurso = new FrmVisualizarCurso();
        //        VisualizarCurso.MdiParent = this;
        //        VisualizarCurso.Show();
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms.OfType<FrmVisualizarCurso>().Count() > 0)
        //    {
        //        Application.OpenForms.OfType<FrmVisualizarCurso>().First().Focus();
        //    }
        //    else
        //    {
        //        FrmCadastroAluno CadastroAluno = new FrmCadastroAluno();
        //        CadastroAluno.MdiParent = this;
        //        CadastroAluno.Show();
        //    }
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    if (Application.OpenForms.OfType<FrmVisualizarCurso>().Count() > 0)
        //    {
        //        Application.OpenForms.OfType<FrmVisualizarCurso>().First().Focus();
        //    }
        //    else
        //    {
        //        FrmVisualizarAluno VisualizarAluno = new FrmVisualizarAluno();
        //        VisualizarAluno.MdiParent = this;
        //        VisualizarAluno.Show();
        //    }
        //}

        private void FrmMenu_Load(object sender, EventArgs e)
        {          
            lklSiteSenaiAnchieta.Text = "visite o Site do Senai - Anchieta";
            lklSiteSenaiAnchieta.Links.Add(17, 17, "http://eletronica.sp.senai.br//");

            lklPortalSenaiSaoPaulo.Text = "visite o Portal do Senai - São Paulo";
            lklPortalSenaiSaoPaulo.Links.Add(19, 17, "http://www.sp.senai.br/senaisp/");
        }

        private void FrmMenu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void editarFinalizarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEditarFinalizarCurso>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmEditarFinalizarCurso>().First().Focus();
            }
            else
            {
                FrmEditarFinalizarCurso EditarFinalizarCursos = new FrmEditarFinalizarCurso();
                EditarFinalizarCursos.MdiParent = this;
                EditarFinalizarCursos.Show();
            }
        }

        private void editarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEditarAlunos>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmEditarAlunos>().First().Focus();
            }
            else
            {
                FrmEditarAlunos EditarAlunos = new FrmEditarAlunos();
                EditarAlunos.MdiParent = this;
                EditarAlunos.Show();
            }
        }

        private void alterarDatasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmAlterarDatas>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmAlterarDatas>().First().Focus();
            }
            else
            {
                FrmAlterarDatas AlterarDatas = new FrmAlterarDatas();
                AlterarDatas.MdiParent = this;
                AlterarDatas.Show();
            }
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void visualizarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmRelatorio>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmRelatorio>().First().Focus();
            }
            else
            {
                FrmRelatorio Relatorio = new FrmRelatorio();
                Relatorio.MdiParent = this;
                Relatorio.Show();
            }
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadastrarUsuario>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCadastrarUsuario>().First().Focus();
            }
            else
            {
                FrmCadastrarUsuario CadastroUsuario = new FrmCadastrarUsuario();
                CadastroUsuario.MdiParent = this;
                CadastroUsuario.Show();
            }
        }

        private void lklSiteSenaiAnchieta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void lklPortalSenaiSaoPaulo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void mspPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
