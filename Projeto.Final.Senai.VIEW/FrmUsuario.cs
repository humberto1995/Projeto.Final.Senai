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
using System.IO;

namespace Projeto.Final.Senai.VIEW
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ClassConexao.conectando();
            ClassConexao.StrConexao = "select Login,Senha from Usuario where Login='" + txtLogin.Text + "' and Senha='" + txtSenha.Text + "'";
            ClassConexao.verificando();
            if (ClassConexao.table.Rows.Count == 0)
            {
                MessageBox.Show("Não foi possiver se conectar com o sistema!");
            }
            else
            {
                FrmMenu Menu = new FrmMenu();
                Menu.Show();
                this.Hide();
                
                //DialogResult = DialogResult.OK;
            }
        }

        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
