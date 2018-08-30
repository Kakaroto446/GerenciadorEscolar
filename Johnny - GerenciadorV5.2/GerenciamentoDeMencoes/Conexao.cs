using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GerenciamentoDeMencoes
{
    class Conexao
    {
        //deckarar o objeto de conexão passando como parametro a string de conexão
        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=Bd_Escola.accdb";

        //variavel de representação do banco
        private static OleDbConnection conn = null;

        public static OleDbConnection obterConn()
        {
            //passar a string para a conexão
            conn = new OleDbConnection(connString);

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida");
            }
            return conn;
        }

        public static void fecharConn()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
