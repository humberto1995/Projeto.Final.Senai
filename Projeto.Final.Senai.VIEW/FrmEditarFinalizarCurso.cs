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
    public partial class FrmEditarFinalizarCurso : Form
    {
        public FrmEditarFinalizarCurso()
        {
            InitializeComponent();
        }

        private void FrmEditarFinalizarCurso_Load(object sender, EventArgs e)
        {
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
                btnCarregarCursos.Visible = true;
            }
        }

        private void btnCarregarCursos_Click(object sender, EventArgs e)
        {
            cbbCursos.Enabled = false;
            lblCursosA.Visible = true;
            txtCursos.Visible = true;
            lblCurso.Visible = true;
            txtCurso.Visible = true;
            lblHorario.Visible = true;
            txtHorario.Visible = true;
            lblCargaHoraria.Visible = true;
            txtCargaHoraria.Visible = true;
            lblHorasDias.Visible = true;
            txtHorasDias.Visible = true;
            lblTotalDias.Visible = true;
            txtTotalDias.Visible = true;
            lblInicioCurso.Visible = true;
            txtInicioCurso.Visible = true;
            lblTerminoCurso.Visible = true;
            txtTerminoCurso.Visible = true;
            lblDocente.Visible = true;
            txtDocente.Visible = true;
            lblLaboratorio.Visible = true;
            txtLaboratorio.Visible = true;
            lblObservacoes.Visible = true;
            txtObservacoes.Visible = true;
            lblDias.Visible = true;
            txtDias.Visible = true;
            lblPeriodo.Visible = true;
            txtPeriodo.Visible = true;
            lblSemanaSabado.Visible = true;
            txtSemanaSabado.Visible = true;
            lblAlunos.Visible = true;
            ltbAlunos.Visible = true;
            btnEditar.Visible = true;        

            ClassConexao.conectando();
            ClassConexao.StrConexao = "select Nome from Cad_Aluno where Curso_Detalhado='" + cbbCursos.Text + "' order by Nome";
            ClassConexao.verificando();
            ltbAlunos.DataSource = ClassConexao.table;

            ClassConexao.conectando();
            ClassConexao.StrConexao = "select * from Cad_Curso where Curso_Detalhado='" + cbbCursos.Text + "'";
            ClassConexao.verificando();

            txtCursos.Text = ClassConexao.table.Rows[0]["Curso_Detalhado"].ToString();
            txtCurso.Text = ClassConexao.table.Rows[0]["Curso"].ToString();
            txtHorario.Text = ClassConexao.table.Rows[0]["Horario"].ToString();
            txtCargaHoraria.Text = ClassConexao.table.Rows[0]["Carga_Horaria"].ToString();
            txtHorasDias.Text = ClassConexao.table.Rows[0]["Horas_Dias"].ToString();
            txtTotalDias.Text = ClassConexao.table.Rows[0]["Total_Dias"].ToString();
            txtInicioCurso.Text = ClassConexao.table.Rows[0]["Inicio_Curso"].ToString();
            txtTerminoCurso.Text = ClassConexao.table.Rows[0]["Termino_Curso"].ToString();
            txtDocente.Text = ClassConexao.table.Rows[0]["Docente"].ToString();
            txtLaboratorio.Text = ClassConexao.table.Rows[0]["Laboratorio"].ToString();
            txtObservacoes.Text = ClassConexao.table.Rows[0]["Observacoes"].ToString();
            txtDias.Text = ClassConexao.table.Rows[0]["Dias"].ToString();
            txtPeriodo.Text = ClassConexao.table.Rows[0]["Periodo"].ToString();
            txtSemanaSabado.Text = ClassConexao.table.Rows[0]["Semana_Sabado"].ToString();

            btnCarregarCursos.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblLogin.Visible = true;
            txtLogin.Visible = true;
            lblSenha.Visible = true;
            txtSenha.Visible = true;
            btnAutenticar.Visible = true;
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
                btnAlterar.Visible = true;
                txtCursos.Enabled = true;
                txtCurso.Enabled = true;
                txtDocente.Enabled = true;
                txtLaboratorio.Enabled = true;
                txtObservacoes.Enabled = true;
                btnExcluirCurso.Visible = true;
                btnFinazilarCurso.Visible = true;
                txtLogin.Text = "";
                txtSenha.Text = "";
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

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Deseja Realmente Excluir o Curso?","ATENÇÃO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (ltbAlunos.Text == "")
            {
                ClassConexao.conectando();
                ClassConexao.StrConexao = "insert into Cad_CursoExcluidos(Curso,Curso_Detalhado,Periodo,Dias,Semana_Sabado,Horario,Carga_Horaria,Horas_Dias,Total_Dias,Inicio_Curso,Termino_Curso,Docente,Laboratorio,Observacoes) values ('" + txtCurso.Text + "','" + txtCursos.Text + "','" + txtPeriodo.Text + "', '" + txtDias.Text + "','" + txtSemanaSabado.Text + "' ,'" + txtHorario.Text + "','" + txtCargaHoraria.Text + "','" + txtHorasDias.Text + "','" + txtTotalDias.Text + "','" + txtInicioCurso.Text + "','" + txtTerminoCurso.Text + "','" + txtDocente.Text + "','" + txtLaboratorio.Text + "','" + txtObservacoes.Text + "')";
                ClassConexao.modificando();

                MessageBox.Show("Dados armazenados em outra tabela");

                ClassConexao.conectando();
                ClassConexao.StrConexao = "delete from Cad_Curso Where Curso_Detalhado='" + cbbCursos.Text + "'";
                ClassConexao.modificando();

                MessageBox.Show("Deletado com sucesso");
            }
            else
            {
                MessageBox.Show("Não é possivelm excluir curso com alunos cadastrados, somente Finalizar!", "Não é possivel excluir curso", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnFinazilarCurso_Click(object sender, EventArgs e)
        {
            //String StrCurso_Detalhado, StrNome, StrFone_Residencial, StrFone_Comercial, StrFone_Celular, StrE_Mail, StrObservacoes;

            ClassConexao.conectando();
            ClassConexao.StrConexao = "insert into Cad_CursoFinalizado(Curso,Curso_Detalhado,Periodo,Dias,Semana_Sabado,Horario,Carga_Horaria,Horas_Dias,Total_Dias,Inicio_Curso,Termino_Curso,Docente,Laboratorio,Observacoes) values ('" + txtCurso.Text + "','" + txtCursos.Text + "','" + txtPeriodo.Text + "', '" + txtDias.Text + "','" + txtSemanaSabado.Text + "' ,'" + txtHorario.Text + "','" + txtCargaHoraria.Text + "','" + txtHorasDias.Text + "','" + txtTotalDias.Text + "','" + txtInicioCurso.Text + "','" + txtTerminoCurso.Text + "','" + txtDocente.Text + "','" + txtLaboratorio.Text + "','" + txtObservacoes.Text + "')";
            ClassConexao.modificando();

            MessageBox.Show("Dados armazenados em outra tabela");

            //ClassConexao.conectando();
            //ClassConexao.StrConexao = "select * from Cad_Aluno where Curso_Detalhado='" + cbbCursos.Text + "'";
            //ClassConexao.verificando();
            //dataGridView1.DataSource = ClassConexao.table;

            //StrCurso_Detalhado = ClassConexao.table.Rows[0]["Curso_Detalhado"].ToString();
            //StrNome = ClassConexao.table.Rows[0]["Nome"].ToString();
            //StrFone_Residencial = ClassConexao.table.Rows[0]["Fone_Residencial"].ToString();
            //StrFone_Comercial = ClassConexao.table.Rows[0]["Fone_Comercial"].ToString();
            //StrFone_Celular = ClassConexao.table.Rows[0]["Fone_Celular"].ToString();
            //StrE_Mail = ClassConexao.table.Rows[0]["E_Mail"].ToString();
            //StrObservacoes = ClassConexao.table.Rows[0]["Observacoes"].ToString();

            //ClassConexao.conectando();
            //ClassConexao.StrConexao = "insert into Cad_AlunoExcluido(Curso_Detalhado,Nome,Fone_Residencial,Fone_Comercial,Fone_Celular,E_Mail,Observacoes) values ('"+ StrCurso_Detalhado + "','" + StrNome + "','"+ StrFone_Residencial + "','"+ StrFone_Comercial + "','"+ StrFone_Celular + "','"+ StrE_Mail + "','"+ StrObservacoes +"')";
            //ClassConexao.modificando();

            //MessageBox.Show("Dados dos Alunos armazenadas em outra tabela");

            ClassConexao.conectando();
            ClassConexao.StrConexao = "delete from Cad_Curso Where Curso_Detalhado='" + cbbCursos.Text + "'";
            ClassConexao.modificando();

            MessageBox.Show("Curso finalizado com sucesso");

            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClassConexao.conectando();
            ClassConexao.StrConexao = "update Cad_Curso set Curso='" + txtCurso.Text + "', Curso_Detalhado='" + txtCursos.Text + "', Periodo='" + txtPeriodo.Text + "', Dias='" + txtDias.Text + "', Semana_Sabado='" + txtSemanaSabado.Text + "', Horario='" + txtHorario.Text + "', Carga_Horaria='" + txtCargaHoraria.Text + "', Horas_Dias='" + txtHorasDias.Text + "', Total_Dias='" + txtTotalDias.Text + "', Inicio_Curso='" + txtInicioCurso.Text + "', Termino_Curso='" + txtTerminoCurso.Text + "', Docente='" + txtDocente.Text + "', Laboratorio='"+ txtLaboratorio.Text + "', Observacoes='"+ txtObservacoes.Text + "' where Curso_Detalhado='" + cbbCursos.Text + "'";
            ClassConexao.modificando();

            ClassConexao.conectando();
            ClassConexao.StrConexao = "update Cad_Aluno set Curso_Detalhado='"+ txtCursos.Text + "' where Curso_Detalhado='"+ cbbCursos.Text +"'";
            ClassConexao.modificando();

            MessageBox.Show("Alteração realizada com sucesso");

            this.Close();
        }
    }
}
