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
    public partial class FrmCadastroAluno : Form
    {
        public FrmCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome");
            }
            else
            {
                ClassConexao.conectando();
                ClassConexao.StrConexao = "insert into Cad_Aluno(Curso_Detalhado,Nome,Fone_Residencial,Fone_Comercial,Fone_Celular,E_Mail,Observacoes) values('" + cbxCurso.Text + "','" + txtNome.Text + "','" + txtFoneResidencial.Text + "','" + txtFoneComercial.Text + "','" + txtFoneCelular.Text + "','" + txtEMail.Text + "','" + txtObservacoes.Text + "')";
                ClassConexao.modificando();

                MessageBox.Show("Aluno Cadastrado com Sucesso");

                txtNome.Text = "";
                txtFoneResidencial.Text = "";
                txtFoneComercial.Text = "";
                txtFoneCelular.Text = "";
                txtEMail.Text = "";
                txtObservacoes.Text = "";

                ClassConexao.conectando();
                ClassConexao.StrConexao = "select Nome from Cad_Aluno where Curso_Detalhado='" + cbxCurso.Text + "' order by Nome";
                ClassConexao.verificando();
                lbxAlunos.DataSource = ClassConexao.table;
            }
        }


        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmCadastroAluno_Load(object sender, EventArgs e)
        {

            ClassConexao.conectando();

            ClassConexao.StrConexao = "select Curso_Detalhado from Cad_Curso order by Curso_Detalhado";
            ClassConexao.verificando();

            cbxCurso.DataSource = ClassConexao.table;

            lblNome.Visible = false;
            txtNome.Visible = false;
            lblFoneResidencial.Visible = false;
            txtFoneResidencial.Visible = false;
            lblFoneComercial.Visible = false;
            txtFoneComercial.Visible = false;
            lblFoneCelular.Visible = false;
            txtFoneCelular.Visible = false;
            lblEMail.Visible = false;
            txtEMail.Visible = false;
            lblObservacoes.Visible = false;
            txtObservacoes.Visible = false;
            btnCadastrar.Visible = false;
            lblAlunosCadastrados.Visible = false;
            lbxAlunos.Visible = false;
        }

        private void FrmCadastroAluno_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnCadastrarAlunos_Click(object sender, EventArgs e)
        {
            btnCadastrarAlunos.Visible = false;
            cbxCurso.Enabled = false;
            lblObservacoesUsuario.Visible = false;           
            lblNome.Visible = true;
            txtNome.Visible = true;
            lblFoneResidencial.Visible = true;
            txtFoneResidencial.Visible = true;
            lblFoneComercial.Visible = true;
            txtFoneComercial.Visible = true;
            lblFoneCelular.Visible = true;
            txtFoneCelular.Visible = true;
            lblEMail.Visible = true;
            txtEMail.Visible = true;
            lblObservacoes.Visible = true;
            txtObservacoes.Visible = true;
            btnCadastrar.Visible = true;
            lblAlunosCadastrados.Visible = true;
            lbxAlunos.Visible = true;

            ClassConexao.conectando();
            ClassConexao.StrConexao = "select Nome from Cad_Aluno where Curso_Detalhado='" + cbxCurso.Text + "' order by Nome";
            ClassConexao.verificando();
            lbxAlunos.DataSource = ClassConexao.table;
        }
    }
}
