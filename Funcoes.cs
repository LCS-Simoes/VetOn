using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
