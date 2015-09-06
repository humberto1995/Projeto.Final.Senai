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
    public partial class FrmCadastroCurso : Form
    {

        public static int intCargaHoraria, intHorasDias, intTotalDias;
        public static string StrSegunda, StrTerca, StrQuarta, StrQuinta, StrSexta, StrSabado;
        public static string VarSegunda, VarTerca, VarQuarta, VarQuinta, VarSexta, VarSabado;
        public static string StrPeriodo, StrSemana, StrDias, StrCurso, StrInicioCurso, StrTerminoCurso, StrCursoDetalhado, StrHorario;

        public FrmCadastroCurso()
        {
            InitializeComponent();
        }

        private void cbxSegunda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSegunda.Checked)
            {
                StrSegunda = "(Segunda)";
                VarSegunda = "Seg";              
            }
            else
            {
                StrSegunda = "";
                VarSegunda = "";
            }
        }

        private void cbxTerca_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSegunda.Checked)
            {
                StrTerca = "(Terça)";
                VarTerca = "Ter";
            }
            else
            {
                StrTerca = "";
                VarTerca = "";
            }
        }

        private void cbxQuarta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxQuarta.Checked)
            {
                StrQuarta = "(Quarta)";
                VarQuarta = "Qua";
            }
            else
            {
                StrQuarta = "";
                VarQuarta = "";
            }
        }

        private void cbxQuinta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxQuinta.Checked)
            {
                StrQuinta = "(Quinta)";
                VarQuinta = "Qui";
            }
            else
            {
                StrQuinta = "";
                VarQuinta = "";
            }
        }

        private void cbxSexta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSexta.Checked)
            {
                StrSexta = "(Sexta)";
                VarSexta = "Sex";
            }
            else
            {
                StrSexta = "";
                VarSexta = "";
            }
        }

        private void cbxSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSabado.Checked)
            {
                StrSabado = "(Sábado)";
                VarSabado = "Sáb";
            }
            else
            {
                StrSabado = "";
                VarSabado = "";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCurso.Text == "" || txtCargaHoraria.Text == "" || txtHorasDias.Text == "" ||  txtDocente.Text == "" || txtLaboratorio.Text == "" || (cbxSegunda.Checked == false && cbxTerca.Checked == false && cbxQuarta.Checked == false && cbxQuinta.Checked == false && cbxSexta.Checked == false && cbxSabado.Checked == false))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                intCargaHoraria = int.Parse(txtCargaHoraria.Text);
                intHorasDias = int.Parse(txtHorasDias.Text);

                if (intCargaHoraria % intHorasDias == 0)
                {
                    intTotalDias = intCargaHoraria / intHorasDias;
                }
                else
                {
                    intTotalDias = (intCargaHoraria / intHorasDias) + 1;
                }

                txtTotalDias.Text = Convert.ToString(intTotalDias);

                ClassConexao.conectando();
                ClassConexao.StrConexao = "select Numero from Cad_Ano where Data='" + dtpInicioCurso.Text + "'";
                ClassConexao.verificando();
                txtInicioCurso.Text = ClassConexao.table.Rows[0]["Numero"].ToString();

                ClassConexao.conectando();
                ClassConexao.StrConexao = "select * from Cad_Ano where Numero between " + txtInicioCurso.Text + " and 1096 and  Situacao='NORMAL' and (Dias='" + VarSegunda + "' or Dias='" + VarTerca + "'or Dias='" + VarQuarta + "' or Dias='" + VarQuinta + "' or Dias='" + VarSexta + "' or Dias='" + VarSabado + "') order by Numero";
                ClassConexao.verificando();
                txtTerminoCurso.Text = ClassConexao.table.Rows[intTotalDias - 1]["Data"].ToString();

                StrCurso = txtCurso.Text;

                ClassConexao.conectando();

                if (txtCurso.Text == "")
                {
                    MessageBox.Show("Você não definiu Curso");
                    this.Close();
                }
                else

                if (rbnManha.Checked)
                {
                    StrPeriodo = "Manhã";
                }
                else if (rbnTarde.Checked)
                {
                    StrPeriodo = "Tarde";
                }
                else if (rbnNoite.Checked)
                {
                    StrPeriodo = "Noite";
                }
                else if (rbnIntegral.Checked)
                {
                    StrPeriodo = "Integral";
                }
                else
                {
                    MessageBox.Show("Você não selecionou o Período");
                }

                if (cbxSegunda.Checked == true || cbxTerca.Checked == true || cbxQuarta.Checked == true || cbxQuinta.Checked == true || cbxSexta.Checked == true)
                {
                    rbnSemana.Checked = true;
                }
                else if (cbxSabado.Checked == true)
                {
                    rbnSabado.Checked = true;
                }

                if (rbnSemana.Checked)
                {
                    StrDias = "Semana";
                }
                else if (rbnSabado.Checked)
                {
                    StrDias = "Sabado";
                }

                
                StrSemana = " " + StrSegunda + " " + " " + StrTerca + " " + " " + StrQuarta + " " + " " + StrQuinta + " " + " " + StrSexta + " " + " " + StrSabado + " ";
                StrInicioCurso = dtpInicioCurso.Text;
                StrTerminoCurso = txtTerminoCurso.Text;
                StrCursoDetalhado = "(" + StrCurso + ")" + "(" + StrDias + ")" + "(" + StrPeriodo + ")" + "(" + dtpInicioCurso.Text + ")";
                StrHorario = "Das" + " " + cbxHorarioEntrada.Text + " " + "às" + " " + cbxHorarioSaida.Text;

                ClassConexao.conectando();
                ClassConexao.StrConexao = "insert into Cad_Curso(Curso,Curso_Detalhado,Periodo,Dias,Semana_Sabado,Horario,Carga_Horaria,Horas_Dias,Total_Dias,Inicio_Curso,Termino_Curso,Docente,Laboratorio,Observacoes) values ('" + txtCurso.Text + "','" + StrCursoDetalhado + "','" + StrPeriodo + "', '" + StrSemana + "','" + StrDias + "' ,'" + StrHorario + "','" + txtCargaHoraria.Text + "','" + txtHorasDias.Text + "','" + txtTotalDias.Text + "','" + dtpInicioCurso.Text + "','" + txtTerminoCurso.Text + "','" + txtDocente.Text + "','" + txtLaboratorio.Text + "','" + txtObservacoes.Text + "')";
                ClassConexao.modificando();

                MessageBox.Show("Curso Cadastrado com sucesso");

                this.Close();


                //if (MessageBox.Show("Deseja realmente cadastrar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                //    ClassConexao.conectando();
                //    ClassConexao.StrConexao = "insert into Cad_Curso(Curso,Curso_Detalhado,Periodo,Dias,Semana_Sabado,Horario,Carga_Horaria,Horas_Dias,Total_Horas,Inicio_Curso,Termino_Curso,Docente,Laboratorio,Observacoes) values ('" + txtCurso.Text + "','" + StrCursoDetalhado + "','" + StrPeriodo + "', '" + StrSemana + "','" + StrDias + "' ,'" + StrHorario + "','" + txtCargaHoraria.Text + "','" + txtHorasDias.Text + "','" + txtTotalHoras.Text + "','" + dtpInicioCurso.Text + "','" + txtTerminoCurso.Text + "','" + txtDocente.Text + "','" + txtLaboratorio.Text + "','" + txtObservacoes.Text + "')";
                //    ClassConexao.modificando();
                //    MessageBox.Show("Curso Cadastrado com sucesso");
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("NÃO FOI POSSIVEL CADASTRAR O CURSO", "ERRO");
                //    this.Close();
                //}
            }
}

        private void FrmCadastroCurso_Load(object sender, EventArgs e)
        {
            this.txtTerminoCurso.Enabled = false;
            this.txtTotalDias.Enabled = false;
            this.txtInicioCurso.Enabled = false;
            this.txtInicioCurso.Visible = false;
            this.rbnSemana.Enabled = false;
            this.rbnSabado.Enabled = false;
           
        }

        private void FrmCadastroCurso_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacoes_Click(object sender, EventArgs e)
        {
            txtObservacoes.Text = string.Empty;
        }

        private void txtCurso_Click(object sender, EventArgs e)
        {
            txtCurso.Text = string.Empty;
        }
    }
}
