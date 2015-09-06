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
    public partial class FrmAlterarDatas : Form
    {
        public FrmAlterarDatas()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ClassConexao.conectando();
            ClassConexao.StrConexao = "update Cad_Ano set Situacao='" + cbbData.Text + "' where Data='" + dtpData.Text + "'";
            ClassConexao.modificando();

            MessageBox.Show("Data Alterada com sucesso");
            this.Close();
        }
    }
}
