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
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void btnConsultarRelatorio_Click(object sender, EventArgs e)
        {
            if (cbbRelatorio.Text == "")
            {
                MessageBox.Show("Nenhum Relatório foi Selecionado","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                cbbRelatorio.Enabled = false;
                lblLogin.Visible = true;
                txtLogin.Visible = true;
                lblSenha.Visible = true;
                txtSenha.Visible = true;
                btnAutenticar.Visible = true;
                btnConsultarRelatorio.Enabled = false;
                dgvRelatorio.Enabled = false;
            }
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text == "humberto") && (txtSenha.Text == "12345678"))
            {
                cbbRelatorio.Enabled = true;
                lblLogin.Visible = false;
                txtLogin.Visible = false;
                //txtLogin.Text = "";
                lblSenha.Visible = false;
                txtSenha.Visible = false;
                //txtSenha.Text = "";
                btnAutenticar.Visible = false;
                btnConsultarRelatorio.Enabled = true;
                dgvRelatorio.Enabled = true;

                if (cbbRelatorio.Text == "Cursos Ativos")
                {
                    ClassConexao.conectando();
                    ClassConexao.StrConexao = "select * from Cad_Curso";
                    ClassConexao.verificando();
                    dgvRelatorio.DataSource = ClassConexao.table;
                }
                else if (cbbRelatorio.Text == "Cursos Finalizados")
                {
                    ClassConexao.conectando();
                    ClassConexao.StrConexao = "select * from Cad_CursoFinalizado";
                    ClassConexao.verificando();
                    dgvRelatorio.DataSource = ClassConexao.table;
                }
                else if (cbbRelatorio.Text == "Cursos Excluidos")
                {
                    ClassConexao.conectando();
                    ClassConexao.StrConexao = "select * from Cad_CursoExcluidos";
                    ClassConexao.verificando();
                    dgvRelatorio.DataSource = ClassConexao.table;
                }
                else if (cbbRelatorio.Text == "Alunos Excluidos")
                {
                    ClassConexao.conectando();
                    ClassConexao.StrConexao = "select * from Cad_AlunoExcluido";
                    ClassConexao.verificando();
                    dgvRelatorio.DataSource = ClassConexao.table;
                }
                else if (cbbRelatorio.Text == "Todos os Alunos")
                {
                    ClassConexao.conectando();
                    ClassConexao.StrConexao = "select * from Cad_Aluno";
                    ClassConexao.verificando();
                    dgvRelatorio.DataSource = ClassConexao.table;
                }
                    else if (cbbRelatorio.Text == "Usuarios")
                {
                    ClassConexao.conectando();
                    ClassConexao.StrConexao = "select * from Usuario";
                    ClassConexao.verificando();
                    dgvRelatorio.DataSource = ClassConexao.table;
                }
                else if (cbbRelatorio.Text == "Calendario")
                {
                    ClassConexao.conectando();
                    ClassConexao.StrConexao = "select * from Cad_Ano";
                    ClassConexao.verificando();
                    dgvRelatorio.DataSource = ClassConexao.table;
                }

            }
            else
            {
                MessageBox.Show("Não foi possiver conectarse com o sistema!");
                lblLogin.Visible = false;
                txtLogin.Visible = false;
                txtLogin.Text = "";
                lblSenha.Visible = false;
                txtSenha.Visible = false;
                txtSenha.Text = "";
                btnAutenticar.Visible = false;
                this.Close();
            }
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {

        }
    }
}
