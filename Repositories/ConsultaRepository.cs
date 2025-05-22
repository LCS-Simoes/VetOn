using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetOn.Repositories
{
    internal class ConsultaRepository
    {

        static string globalQuery = "";

        public static void listarDia(string searchID, TextBox tb_idagenda, TextBox tb_idanimal, TextBox  tb_idcliente, TextBox tb_nomeanimal, TextBox tb_nomecliente, ComboBox cb_nomeveterinario, ComboBox cb_status, TextBox tb_idconsulta)
        {
            DataTable dt = new DataTable();

            globalQuery = @"SELECT * FROM tb_agenda a
            JOIN tb_clientes c ON a.n_idcliente = c.n_idcliente
            JOIN tb_veterinarios v ON a.n_idveterinario = v.n_idveterinario
            JOIN tb_animais an ON a.n_idanimal = an.n_idanimal
            WHERE a.n_idagenda=" + searchID;
            dt = Banco.dql(globalQuery);


            //Agenda
            tb_idagenda.Text = dt.Rows[0].Field<Int64>("n_idagenda").ToString();

            //Cliente
            tb_idcliente.Text = dt.Rows[0].Field<Int64>("n_idcliente").ToString();
            tb_nomecliente.Text = dt.Rows[0].Field<string>("t_nomecliente");
   

            //Animal
            tb_idanimal.Text = dt.Rows[0].Field<Int64>("n_idanimal").ToString();
            tb_nomeanimal.Text = dt.Rows[0].Field<string>("t_nomeanimal");

            //Consulta
            //cb_horario.Text = dt.Rows[0].Field<string>("t_horario"); ADICIONAR
            cb_nomeveterinario.SelectedValue = dt.Rows[0].Field<Int64>("n_idveterinario");
            cb_status.Text = dt.Rows[0].Field<string>("t_status");


            /* BLOCO DANDO CONFLITO
            if (cb_status.Text == "Presente")
            {
                string queryConsult = "SELECT n_idconsulta FROM tb_consultas WHERE n_idanimal =" + tb_idanimal.Text;
                dt = Banco.dql(queryConsult);

                tb_idconsulta.Text = dt.Rows[0].Field<Int64>("n_idconsulta").ToString();
            }
            else
            {
                tb_idanimal.Text = "";
                return;
            }
            */

        }

        public static void CriarConsulta(string searchID, ComboBox tb_status, ComboBox cb_nomeveterinario, TextBox tb_nomeanimal, TextBox tb_idanimal)
        {
            string query = String.Format(@"UPDATE tb_agenda SET t_status='{0}' WHERE n_idagenda={1}",
            tb_status.Text,
            searchID
            );
            Banco.dml(query);

            query = String.Format(@"INSERT INTO tb_consultas (n_idanimal, n_idveterinario, t_nomeanimal) VALUES ({0},{1},'{2}')",
            tb_idanimal.Text,
            cb_nomeveterinario.SelectedValue,
            tb_nomeanimal.Text
            );
            Banco.dml(query);
        }

    }
}
