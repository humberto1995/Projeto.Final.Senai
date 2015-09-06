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
    public partial class FrmEditarAlunos : Form
    {
        public FrmEditarAlunos()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClassConexao.conectando();
            ClassConexao.StrConexao = "insert into Cad_AlunoExcluido(Curso_Detalhado,Nome,Fone_Residencial,Fone_Comercial,Fone_Celular,E_Mail,Observacoes) values ('" + cbbCursos.Text + "','" + txtNome.Text + "','" + txtFoneResidencial.Text + "', '" + txtFoneComercial.Text + "','" + txtFoneCelular.Text + "' ,'" + txtEMail.Text + "','" + txtObservacoes.Text + "')";
            ClassConexao.modificando();

            MessageBox.Show("Dados armazenados em outra tabela");

            ClassConexao.conectando();
            ClassConexao.StrConexao = "delete from Cad_Aluno Where Curso_Detalhado='" + cbbCursos.Text + "' and Nome='" + txtNome.Text + "'";
            ClassConexao.modificando();

            MessageBox.Show("Deletado com sucesso");
            this.Close();
        }

        private void btnCarregarCursos_Click(object sender, EventArgs e)
        {
            cbbAlunos.Enabled = true;
            btnCarregarAlunos.Visible = true;
            btnCarregarCursos.Visible = false;
            cbbCursos.Enabled = false;
            lblAlunosCadastrados.Visible = true;
            ltbAlunosCadastrados.Visible = true;

            ClassConexao.conectando();
            ClassConexao.StrConexao = "select Nome from Cad_Aluno where Curso_Detalhado='" + cbbCursos.Text + "' order by Nome";
            ClassConexao.verificando();
            ltbAlunosCadastrados.DataSource = ClassConexao.table;
            cbbAlunos.DataSource = ClassConexao.table;

        }

        private void btnCarregarAlunos_Click(object sender, EventArgs e)
        {
            if (cbbAlunos.Text == "")
            {
                MessageBox.Show("Nenhum aluno cadastrado neste curso");
                this.Close();
            }
            else
            {
                ClassConexao.conectando();
                ClassConexao.StrConexao = "select * from Cad_Aluno where Curso_Detalhado='" + cbbCursos.Text + "' and Nome='" + cbbAlunos.Text + "'";
                ClassConexao.verificando();

                txtNome.Text = ClassConexao.table.Rows[0]["Nome"].ToString();
                txtFoneResidencial.Text = ClassConexao.table.Rows[0]["Fone_Residencial"].ToString();
                txtFoneComercial.Text = ClassConexao.table.Rows[0]["Fone_Comercial"].ToString();
                txtFoneCelular.Text = ClassConexao.table.Rows[0]["Fone_Celular"].ToString();
                txtEMail.Text = ClassConexao.table.Rows[0]["E_Mail"].ToString();
                txtObservacoes.Text = ClassConexao.table.Rows[0]["Observacoes"].ToString();
            }

            btnCarregarAlunos.Visible = false;
            cbbAlunos.Enabled = false;
            lblNome.Visible = true;
            txtNome.Visible = true;
            txtNome.Enabled = false;
            lblFoneResidencial.Visible = true;
            txtFoneResidencial.Visible = true;
            txtFoneResidencial.Enabled = false;
            lblFoneComercial.Visible = true;
            txtFoneComercial.Visible = true;
            txtFoneComercial.Enabled = false;
            lblFoneCelular.Visible = true;
            txtFoneCelular.Visible = true;
            txtFoneCelular.Enabled = false;
            lblEMail.Visible = true;
            txtEMail.Visible = true;
            txtEMail.Enabled = false;
            lblObservacoes.Visible = true;
            txtObservacoes.Visible = true;
            txtObservacoes.Enabled = false;
            btnEditar.Visible = true;
     
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblLogin.Visible = true;
            txtLogin.Visible = true;
            lblSenha.Visible = true;
            txtSenha.Visible = true;
            btnAutenticar.Visible = true;
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text == "humberto") && (txtSenha.Text == "12345678"))
            {
            btnEditar.Visible = false;
            lblLogin.Visible = false;
            txtLogin.Visible = false;
            lblSenha.Visible = false;
            txtSenha.Visible = false;
            btnAutenticar.Visible = false;
            txtLogin.Text = "";
            txtSenha.Text = "";
            btnExcluirAlunos.Visible = true;
            btnAlterar.Visible = true;
            txtNome.Enabled = true;
            txtFoneResidencial.Enabled = true;
            txtFoneComercial.Enabled = true;
            txtFoneCelular.Enabled = true;
            txtEMail.Enabled = true;
            txtObservacoes.Enabled = true;
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
            }



        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClassConexao.conectando();
            ClassConexao.StrConexao = "update Cad_Aluno set Nome='" + txtNome.Text + "', Fone_Residencial='"+ txtFoneResidencial.Text + "', Fone_Comercial='"+ txtFoneComercial.Text + "', Fone_Celular='"+ txtFoneCelular.Text + "', E_Mail='"+ txtEMail.Text + "', Observacoes='"+ txtObservacoes.Text +"' where Curso_Detalhado='" + cbbCursos.Text + "' and Nome='"+ cbbAlunos.Text +"'";
            ClassConexao.modificando();

            MessageBox.Show("Alteração realizada com sucesso");
            this.Close();
        }

        private void FrmEditarAlunos_Load(object sender, EventArgs e)
        {

            txtNome.Text = "";
            txtFoneResidencial.Text = "";
            txtFoneComercial.Text = "";
            txtFoneCelular.Text = "";
            txtEMail.Text = "";
            txtObservacoes.Text = "";

            btnCarregarAlunos.Visible = false;
            ClassConexao.conectando();
            ClassConexao.StrConexao = "select Curso_Detalhado from Cad_Curso order by Curso_Detalhado";
            ClassConexao.verificando();
            cbbCursos.DataSource = ClassConexao.table;

            if (cbbCursos.Text == "")
            {
                MessageBox.Show("Nenhum Curso Cadastrado, Favor Cadastrar Curso Primeiro.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }
            else
            {
                btnCarregarCursos.Enabled = true;
                btnCarregarAlunos.Enabled = true;
            }
        }
    }
}
