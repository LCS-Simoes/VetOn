using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetOn.Repositories
{
    internal class ManutencaoRepository
    {

        public static void CorrigirCategorias(ComboBox cb1, ComboBox cb2)
        {

            //Status 
            if (cb1.Text == "A")
            {
                cb1.Text = "Ativa";
            }
            else if (cb1.Text == "B")
            {
                cb1.Text = "Bloqueada";
            }
            else
            {
                cb1.Text = "Desativada";
            }

            //Cargos
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


        public static void CadastrarUsuarios(TextBox tb_nome, TextBox tb_senha, TextBox tb_username, ComboBox cb_categoria, ComboBox cb_status)
        {
            CorrigirCategorias(cb_status, cb_categoria);

            string query = String.Format(@"INSERT INTO tb_usuarios (t_nomeusuario, t_username, t_senhausuario, cb_categoria, cb_status) VALUES '{0}','{1}','{2}','{3}','{4}'",
            tb_nome.Text,
            tb_username.Text,
            tb_senha.Text,  
            cb_status.Text,
            cb_categoria.Text
            );
            Banco.dql(query);
            MessageBox.Show("Usuário cadastrado");
        }
    }
}
