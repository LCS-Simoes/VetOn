using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace VetOn
{
    public class Funcoes
    {
        
        //Validações Clientes
        public bool ValidarCPF(string cpf)
        {

            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
            {
                MessageBox.Show("Preencha o CPF por completo");
                return false;     
            }

            bool numerosIguais = cpf.All(d => d == cpf[0]);
            if (numerosIguais)
            {
                MessageBox.Show("CPF Inválido");
                return false;
            }
            int[] multiplicadoresPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplciadoresSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * multiplicadoresPrimeiroDigito[i];
            }
            int resto = soma % 11;
            int digitoVerificador = resto < 2 ? 0 : 11 - resto;
            if (int.Parse(cpf[9].ToString()) != digitoVerificador)
            {
                MessageBox.Show("CPF Inválido");
                return false;
            }

            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * multiplciadoresSegundoDigito[i];
            }

            resto = soma % 11;
            digitoVerificador = resto < 2 ? 0 : 11 - resto;

            if (int.Parse(cpf[10].ToString()) != digitoVerificador)
            {
                MessageBox.Show("CPF Inválido");
                return false;
            }

            return true;
        }

        public bool ValidarTelefone(string telefone)
        {
            telefone = new string(telefone.Where(char.IsDigit).ToArray());

            if(telefone.Length != 11)
            {
                MessageBox.Show("Preencha o campo de Celular");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarCEP(string cep)
        {
            cep = new string(cep.Where(char.IsDigit).ToArray());
            if (cep.Length != 8)
            {
                MessageBox.Show("Preencha o campo de CEP");
                return false;
            }
            else
            {
                return true;
            }
        }

        //provisorio testes depois adicionar repositores

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
    }
}
