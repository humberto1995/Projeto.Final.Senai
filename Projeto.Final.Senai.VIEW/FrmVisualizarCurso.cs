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
    public partial class FrmVisualizarCurso : Form
    {
        public FrmVisualizarCurso()
        {
            InitializeComponent();
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassConexao.conectando();
            if (cbxCurso.Text == "Todos os Cursos")
            {
                ClassConexao.StrConexao = "select * from Cad_Curso";
                ClassConexao.verificando();
                dataGridView1.DataSource = ClassConexao.table;
            }
        }

        private void FrmVisualizarCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
