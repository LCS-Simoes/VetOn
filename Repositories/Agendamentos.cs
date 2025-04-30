using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetOn.Repositories
{
    internal class Agendamentos
    {
        public static void listarAgendas(string id, TextBox tb_idcliente, TextBox tb_idanimal, TextBox tb_nomeanimal, TextBox tb_nomecliente, ComboBox cb_horario, ComboBox cb_veterinario, MaskedTextBox mb_cpf, MaskedTextBox mb_celular, DateTimePicker dtp_consulta)

        {
            DataTable dt = new DataTable();

            string query = @"SELECT * FROM tb_agenda a
            JOIN tb_clientes c ON a.n_idcliente = c.n_idcliente
            JOIN tb_veterinarios v ON a.n_idveterinario = v.n_idveterinario
            JOIN tb_animais an ON a.n_idanimal = an.n_idanimal";
            dt = Banco.dql(query);

            //Cliente
            tb_idcliente.Text = dt.Rows[0].Field<Int64>("n_idcliente").ToString();
            tb_nomecliente.Text = dt.Rows[0].Field<string>("t_nomecliente");
            mb_cpf.Text = dt.Rows[0].Field<string>("t_cpf");
            mb_celular.Text = dt.Rows[0].Field<string>("t_telefone");

            //Animal
            tb_idanimal.Text = dt.Rows[0].Field<Int64>("n_idanimal").ToString();
            tb_nomeanimal.Text = dt.Rows[0].Field<string>("t_nomeanimal");

            //Consulta
            cb_veterinario.Text = dt.Rows[0].Field<string>("t_nomeveterinario");
            cb_horario.Text = dt.Rows[0].Field<string>("t_horario");
            dtp_consulta.Text = dt.Rows[0].Field<string>("t_data");

        }

        public static void Agendar()
        {

        }

    }
}
