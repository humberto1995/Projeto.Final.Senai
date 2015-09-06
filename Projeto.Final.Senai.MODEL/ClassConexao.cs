using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace Projeto.Final.Senai.MODEL
{
    public class ClassConexao
    {       
        public static OleDbConnection conexao;
        public static OleDbCommand comando;
        public static OleDbDataAdapter adapter;
        public static DataTable table;

        public static string StrConexao, StrComando;
        
        public static void conectando()
        {

            StrComando = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BancoProjetoFinalSenai.accdb"; 
            conexao = new OleDbConnection(StrComando);
            conexao.Open();
        }


        public static void modificando()
        {
            comando = new OleDbCommand(StrConexao, conexao);
            comando.ExecuteReader();
            conexao.Close();
        }

        public static void verificando()
        {
            adapter = new OleDbDataAdapter(StrConexao, conexao);
            table = new DataTable();
            adapter.Fill(table);
            conexao.Close();
        }
    }
}
