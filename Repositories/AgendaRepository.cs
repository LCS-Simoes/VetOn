using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetOn.Repositories
{
    internal class AgendaRepository : Form
    {
        
        static string globalQuery = ""; 
        public static void listarAgendas(string id, TextBox tb_idagenda, TextBox tb_idcliente, TextBox tb_idanimal, TextBox tb_nomeanimal, TextBox tb_nomecliente, ComboBox cb_horario, ComboBox cb_veterinario, MaskedTextBox mb_cpf, MaskedTextBox mb_celular, DateTimePicker dtp_consulta)
        {
            DataTable dt = new DataTable();

            globalQuery = @"SELECT * FROM tb_agenda a
            JOIN tb_clientes c ON a.n_idcliente = c.n_idcliente
            JOIN tb_veterinarios v ON a.n_idveterinario = v.n_idveterinario
            JOIN tb_animais an ON a.n_idanimal = an.n_idanimal";
            dt = Banco.dql(globalQuery);

            //Agenda
            tb_idagenda.Text = dt.Rows[0].Field<Int64>("n_idagenda").ToString();

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

        public static void Agendar(TextBox tb_idcliente, TextBox tb_idanimal, ComboBox cb_horario, ComboBox cb_veterinario, DateTimePicker dtp_consulta)
        {
            string query = String.Format(@"INSERT INTO (tb_idcliente, tb_idanimal, cb_horario, cb_veterinario, dtp_consulta) VALUES ({0}, {1}, '{2}','{3}','{4}')",
            tb_idcliente.Text,
            tb_idanimal.Text,
            cb_horario.Text,
            cb_veterinario.Text,
            dtp_consulta.Text
            );
            Banco.dml(query);
            MessageBox.Show("Consulta agendada");
            Banco.dql(globalQuery);
        }

        public static bool Desmarcar(string id)
        {
            DialogResult res = MessageBox.Show("Deseja desmarcar essa consulta?", "Desmarcar", MessageBoxButtons.YesNo);
            string query = @"DELETE FROM tb_agenda WHERE n_idagenda=" + id;
            Banco.dml(query);
            return true;
        }

        public static void Remarcar(string id, ComboBox cb_veterinario, DateTimePicker dtp_consulta, ComboBox cb_horario)
        {
            string query = String.Format(@"UPDATE tb_agenda SET t_veterinario='{0}', t_data='{1}', t_horario='{2}' WHERE n_idagenda={3}",
                cb_veterinario,
                dtp_consulta,
                cb_horario.Text,
                id
            );
            MessageBox.Show("Atualizado com sucesso");
        }

        public static bool Procurar(TextBox tb_nomecliente, TextBox tb_idcliente, MaskedTextBox mb_cpf, MaskedTextBox mb_celular, TextBox tb_idanimal, TextBox tb_nomeanimal)
        {
            if(tb_nomecliente.Text != "")
            {
                DataTable dt = new DataTable();
                string nome = tb_nomecliente.Text.Replace("'", "''");
                string query = $"SELECT * FROM tb_clientes WHERE t_nomecliente = '{nome}'";
                dt = Banco.dql(query);

                //Cliente
                tb_idcliente.Text = dt.Rows[0].Field<Int64>("n_idcliente").ToString();
                tb_nomecliente.Text = dt.Rows[0].Field<string>("t_nomecliente");
                mb_cpf.Text = dt.Rows[0].Field<string>("t_cpf");
                mb_celular.Text = dt.Rows[0].Field<string>("t_telefone");

                //Animal Cliente
                query = @"SELECT * FROM tb_animais WHERE n_idcliente=" + tb_idcliente.Text;
                dt = Banco.dql(query);

                tb_idanimal.Text = dt.Rows[0].Field<Int64>("n_idanimal").ToString();
                tb_nomeanimal.Text = dt.Rows[0].Field<string>("t_nomeanimal");

                return true;
            }
            else
            {
                MessageBox.Show("Nome do cliente incorreto ou inexistente");
                return false;
            } 
        }
    }
}
