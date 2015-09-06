using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Final.Senai.MODEL;

namespace Projeto.Final.Senai.VIEW
{
    public partial class FrmVisualizarAluno : Form
    {
        public FrmVisualizarAluno()
        {
            InitializeComponent();
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmVisualizarAluno_Load(object sender, EventArgs e)
        {
            ClassConexao.conectando();
            ClassConexao.StrConexao = "select Curso_Detalhado from Cad_Curso order by Curso_Detalhado";
            ClassConexao.verificando();

            cbxCurso.DataSource = ClassConexao.table;

        }

        private void btnVisualizarAlunos_Click(object sender, EventArgs e)
        {
            ClassConexao.conectando();
            ClassConexao.StrConexao = "select * from Cad_Aluno where Curso_Detalhado='" + cbxCurso.Text + "'";
            ClassConexao.verificando();

            dataGridView1.DataSource = ClassConexao.table;

        }
    }
}
