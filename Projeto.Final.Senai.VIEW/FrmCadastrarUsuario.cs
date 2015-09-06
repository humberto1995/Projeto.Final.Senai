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
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            txtCadastrarLogin.Enabled = false;
            txtCadastrarSenha.Enabled = false;
            btnCadastrarUsuario.Enabled = false;
            lblObservacoesValidar.Visible = true;
            lblValidarLogin.Visible = true;
            txtValidarLogin.Visible = true;
            lblValidarSenha.Visible = true;
            txtValidarSenha.Visible = true;
            btnValidar.Visible = true;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if ((txtValidarLogin.Text == "humberto") && (txtValidarSenha.Text == "12345678"))
            {
                ClassConexao.conectando();
                ClassConexao.StrConexao = "insert into Usuario(Login,Senha) values('" + txtCadastrarLogin.Text + "','" + txtCadastrarSenha.Text + "')";
                ClassConexao.modificando();

                MessageBox.Show("Usuario Cadastrado com Sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possivel validar, Impossivel de Cadastrar Usuario","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
