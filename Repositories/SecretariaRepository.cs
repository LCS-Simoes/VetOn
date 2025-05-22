    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetOn.Repositories
{
    internal class SecretariaRepository
    {
        public static void listarClientes(string searchID, TextBox tb_idcliente, TextBox tb_nomecliente, TextBox tb_rua, TextBox tb_cidade,
        TextBox tb_bairro, MaskedTextBox mb_celular, MaskedTextBox mb_cep, MaskedTextBox mb_cpf, NumericUpDown np_numero)
        {

            //Clientes
            DataTable dt = new DataTable();

            string QueryClientes = @"SELECT * FROM tb_clientes WHERE n_idcliente=" + searchID;
            dt = Banco.dql(QueryClientes);

            tb_idcliente.Text = dt.Rows[0].Field<Int64>("n_idcliente").ToString();
            tb_nomecliente.Text = dt.Rows[0].Field<string>("t_nomecliente");
            tb_rua.Text = dt.Rows[0].Field<string>("t_rua");
            tb_cidade.Text = dt.Rows[0].Field<string>("t_cidade");
            tb_bairro.Text = dt.Rows[0].Field<string>("t_bairro");
            mb_celular.Text = dt.Rows[0].Field<string>("t_telefone");
            mb_cep.Text = dt.Rows[0].Field<string>("t_cep");
            mb_cpf.Text = dt.Rows[0].Field<string>("t_cpf");
            np_numero.Value = dt.Rows[0].Field<Int64>("n_numerocasa");
        }

        public static bool listarAnimais(string searchID, TextBox tb_idanimal, TextBox tb_nomeanimal, TextBox tb_especieanimal, TextBox tb_racaanimal, 
        ComboBox cb_generoanimal, NumericUpDown np_idadeanimal, PictureBox pb_animal)
        {
            DataTable dtAnimal = Banco.dql(@"SELECT * FROM tb_animais WHERE n_idcliente =" + searchID);
            if (dtAnimal.Rows.Count > 0)
            {
                tb_idanimal.Text = dtAnimal.Rows[0].Field<Int64>("n_idanimal").ToString();
                tb_nomeanimal.Text = dtAnimal.Rows[0].Field<string>("t_nomeanimal");
                tb_especieanimal.Text = dtAnimal.Rows[0].Field<string>("t_especie");
                tb_racaanimal.Text = dtAnimal.Rows[0].Field<string>("t_raca");
                cb_generoanimal.Text = dtAnimal.Rows[0].Field<string>("t_genero");
                np_idadeanimal.Value = dtAnimal.Rows[0].Field<Int64>("n_idade");
                pb_animal.ImageLocation = dtAnimal.Rows[0].Field<string>("t_fotos");

                return true;
            }
            else
            {
                return false;
            }
        }

        public static void cadastrarCliente(TextBox tb_nomecliente, MaskedTextBox mb_cpf, MaskedTextBox mb_celular, MaskedTextBox mb_cep, NumericUpDown np_numero,
        TextBox tb_rua, TextBox tb_cidade, TextBox tb_bairro)
        {
            string query = String.Format(@"INSERT INTO tb_clientes (t_nomecliente, t_cpf, t_telefone, t_cep, n_numerocasa, t_rua, t_cidade, t_bairro) VALUES ('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}')",
            tb_nomecliente.Text,
            mb_cpf.Text,
            mb_celular.Text,
            mb_cep.Text,
            np_numero.Value,
            tb_rua.Text,
            tb_cidade.Text,
            tb_bairro.Text
            );

            Banco.dql(query);
            MessageBox.Show("Novo Cliente Cadastrado");
        }

        public static void atualizarCliente(string searchID, TextBox tb_nomecliente, MaskedTextBox mb_cpf, MaskedTextBox mb_celular, MaskedTextBox mb_cep, NumericUpDown np_numero,
        TextBox tb_rua, TextBox tb_cidade, TextBox tb_bairro)
        {
            string query = String.Format(@"UPDATE tb_clientes SET t_nomecliente='{0}', t_cpf='{1}', t_telefone='{2}', t_cep='{3}', n_numerocasa={4}, t_rua='{5}', t_cidade='{6}', t_bairro='{7}' WHERE n_idcliente={8}",
            tb_nomecliente.Text,
            mb_cpf.Text,
            mb_celular.Text,
            mb_cep.Text,
            np_numero.Value,
            tb_rua.Text,
            tb_cidade.Text,
            tb_bairro.Text,
            searchID
            );
            Banco.dql(query);
            MessageBox.Show("Cliente atualizado");
        }

        public static void cadastrarAnimal(TextBox tb_idcliente, TextBox tb_nomeanimal, TextBox tb_racaanimal, NumericUpDown np_idadeanimal, ComboBox cb_generoanimal, TextBox tb_especieanimal,
        string destinoCompleto)
        {
            string query = String.Format(@"INSERT INTO tb_animais (n_idcliente, t_nomeanimal, t_raca, n_idade, t_genero, t_especie, t_fotos)
            VALUES ({0},'{1}','{2}',{3},'{4}','{5}', '{6}')",
            tb_idcliente.Text,
            tb_nomeanimal.Text,
            tb_racaanimal.Text,
            np_idadeanimal.Value,
            cb_generoanimal.Text,
            tb_especieanimal.Text,
            destinoCompleto
            );
            Banco.dql(query);
            MessageBox.Show("Animal Cadastrado");
        }

        public static void atualizarAnimal(TextBox tb_idcliente, TextBox tb_nomeanimal, TextBox tb_racaanimal, NumericUpDown np_idadeanimal, ComboBox cb_generoanimal, TextBox tb_especieanimal,
        string destinoCompleto, TextBox tb_idanimal)
        {
            string query = String.Format(@"UPDATE tb_animais SET t_nomeanimal='{0}', t_raca='{1}', n_idade={2}, t_genero='{3}', t_especie='{4}', t_fotos='{5}', n_idcliente={6} WHERE n_idanimal={7}",
            tb_nomeanimal.Text,
            tb_racaanimal.Text,
            np_idadeanimal.Value,
            cb_generoanimal.Text,
            tb_especieanimal.Text,
            destinoCompleto,
            tb_idcliente.Text,
            tb_idanimal.Text
            );
            Banco.dql(query);
            MessageBox.Show("Animal atualizado");
        }
    }
}
