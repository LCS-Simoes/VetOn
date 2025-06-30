using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetOn.Repositories
{
    internal class ManutencaoRepository
    {
        //Talvez eu remova
        public static void CorrigirCategorias(ComboBox cb2)
        {

            if (cb2.Text == "S")
            {
                cb2.Text = "secretaria";
            }
            else if (cb2.Text == "M")
            {
                cb2.Text = "manutencao";
            }
            else if (cb2.Text == "V")
            {
                cb2.Text = "veterinaria";
            }
            else if (cb2.Text == "G")
            {
                cb2.Text = "gerente";
            }
            else
            {
                cb2.Text = "farmacia";
            }
        }

        public static void listarUsuarios(string searchID, TextBox tb_id,TextBox tb_nome, TextBox tb_senha, TextBox tb_username, ComboBox cb_categoria, ComboBox cb_status)
        {
            DataTable dt = new DataTable();

            string globalQuery = @"SELECT * FROM tb_usuarios WHERE n_idusuario=" + searchID;
            dt = Banco.dql(globalQuery);

            tb_id.Text = dt.Rows[0].Field<Int64>("n_idusuario").ToString();
            tb_nome.Text = dt.Rows[0].Field<string>("t_nomeusuario");
            tb_senha.Text = dt.Rows[0].Field<string>("t_senhausuario");
            tb_username.Text = dt.Rows[0].Field<string>("t_username");
            cb_categoria.Text = dt.Rows[0].Field<string>("t_nivel");
            cb_status.Text = dt.Rows[0].Field<string>("t_status");
        }
        
        public static void CadastrarUsuarios(TextBox tb_nome, TextBox tb_senha, TextBox tb_username, ComboBox cb_categoria, ComboBox cb_status)
        {
            CorrigirCategorias(cb_categoria);
            string query = String.Format(@"INSERT INTO tb_usuarios (t_nomeusuario, t_username, t_senhausuario, t_nivel, t_status) VALUES ('{0}','{1}','{2}','{3}','{4}')",
            tb_nome.Text,
            tb_username.Text,
            tb_senha.Text,
            cb_categoria.Text,
            cb_status.Text
            );
            Banco.dql(query);
            MessageBox.Show("Usuário cadastrado");
        }

        public static void RemoverUsuario(string searchID)
        {
            DialogResult res = MessageBox.Show("Deseja realmente remover esse usuário?", "Remover", MessageBoxButtons.YesNo);
            string query = String.Format(@"DELETE FROM tb_usuarios WHERE n_idusuario=" + searchID);
            Banco.dml(query);
            MessageBox.Show("Usuário removido");
        }
    }
}
