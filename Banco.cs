using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VetOn
{
    internal class Banco
    {
        private static SQLiteConnection conexao;
            
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=" + Globais.camnhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        

        //ÁREA DE CONSULTAS
        public static DataTable dql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static void dml(string query, string msgOK = null, string msgERRO = null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = query;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    if (msgOK != null)
                    {
                        MessageBox.Show(msgOK);
                    }
                }
            }
            catch (Exception ex)
            {
                if(msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex);
                }
                ConexaoBanco().Close();
                throw ex;
            }
        }

        //PROVISORIO
        public static object getScalar(string query)    
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = query;
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                return cmd.ExecuteScalar();
            }
        }

    }
}
