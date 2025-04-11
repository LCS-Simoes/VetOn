using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetOn
{
    public partial class F_Secretaria : Form
    {

        Funcoes funcoes = new Funcoes();
        string query = "";

        public F_Secretaria()
        {
            InitializeComponent();
        }

        private void F_Secretaria_Load(object sender, EventArgs e)
        {
            //FASE DE TESTES
            query = @"SELECT c.n_idcliente as 'ID Cliente', c.t_nomecliente as 'Nome Cliente',
            a.n_idanimal as 'ID Animal', a.t_nomeanimal as 'Nome Animal', a.t_especie as 'Espécie'
            FROM tb_clientes c
            LEFT JOIN tb_animais a ON c.n_idcliente = a.n_idcliente
            ORDER BY c.t_nomecliente";
            dgv_clientes.DataSource = Banco.dql(query);
            dgv_clientes.Columns[0].Width = 70; 
            dgv_clientes.Columns[1].Width = 100; 
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender; 
            int cont = dgv.SelectedRows.Count;


            if(cont > 0)
            {
                DataTable dt = new DataTable();
                string searchID = dgv.SelectedRows[0].Cells[0].Value.ToString();
                query = @"SELECT * FROM tb_clientes WHERE n_idcliente=" + searchID;
                dt = Banco.dql(query);

                tb_idcliente.Text = dt.Rows[0].Field<Int64>("n_idcliente").ToString();
                tb_nomecliente.Text = dt.Rows[0].Field<string>("t_nomecliente");
                tb_rua.Text = dt.Rows[0].Field<string>("t_rua");
                tb_cidade.Text = dt.Rows[0].Field<string>("t_cidade");
                tb_bairro.Text = dt.Rows[0].Field<string>("t_bairro");
                mb_celular.Text = dt.Rows[0].Field<string>("t_telefone");
                mb_cep.Text = dt.Rows[0].Field<string>("t_cep");
                mb_cpf.Text = dt.Rows[0].Field<string>("t_cpf");
                np_numero.Value = dt.Rows[0].Field<Int64>("n_numerocasa");


                DataTable dtAnimal = Banco.dql(@"SELECT * FROM tb_animais WHERE n_idcliente = " + searchID);
                if (dtAnimal.Rows.Count > 0)
                {
                    tb_idanimal.Text = dt.Rows[0].Field<Int64>("n_idanimal").ToString();
                    tb_especieanimal.Text = dt.Rows[0].Field<string>("t_especie");
                    tb_racaanimal.Text = dt.Rows[0].Field<string>("t_raca");
                    cb_generoanimal.Text = dt.Rows[0].Field<string>("t_genero");
                    np_idadeanimal.Value = dt.Rows[0].Field<Int64>("n_idade");

                    //Talvez otimizar posteriormente
                }
                else {
                    //Otimizar
                    tb_idanimal.Clear();
                    tb_nomeanimal.Clear();
                    tb_especieanimal.Clear();
                    tb_racaanimal.Clear();
                    cb_generoanimal.Text = "";
                    np_idadeanimal.Value = 0;
                    return;
                }
            }
        }

        //Validações -- Otimizar depois ou passar para classe Funções
        private void ValidacoesClientes()
        {
            bool resultadoCPF = funcoes.ValidarCPF(mb_cpf.Text);
            bool celular = funcoes.ValidarTelefone(mb_celular.Text);
            bool cep = funcoes.ValidarCEP(mb_cep.Text);
        }

        //MenuStrip
        private void agenderConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Funções Buttons
        private void btn_novoanimal_Click(object sender, EventArgs e)
        {
            tb_idanimal.Clear();
            tb_nomeanimal.Clear();
            tb_especieanimal.Clear();
            tb_racaanimal.Clear();
            cb_generoanimal.Text = "";
            np_idadeanimal.Value = 0;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            //Campos Clientes
            tb_idcliente.Clear();
            tb_nomecliente.Clear();
            tb_cidade.Clear();
            tb_bairro.Clear();
            tb_rua.Clear();
            mb_celular.Clear();
            mb_cep.Clear();
            mb_cpf.Clear();
            np_numero.Value = 0;
            
            //Campos Animais
            tb_idanimal.Clear();
            tb_nomeanimal.Clear();
            tb_especieanimal.Clear();
            tb_racaanimal.Clear();
            cb_generoanimal.Text = "";
            np_idadeanimal.Value = 0;
        }

        private void btn_salvarCliente_Click(object sender, EventArgs e)
        {
            ValidacoesClientes();
            if(tb_idcliente.Text == "")
            {
                query = String.Format($"INSERT ");
                Banco.dml(query);
            }
            else
            {
                query = String.Format($"UPDATE");
                Banco.dml(query);
            }

        }

        private void btn_salvarAnimal_Click(object sender, EventArgs e)
        {
            if (tb_idanimal.Text == "")
            {
                query = String.Format(@"INSERT INTO tb_animais (n_idcliente, t_nomeanimal, t_raca, n_idade, t_genero, t_especie)
                VALUES ({0},'{1}','{2}',{3},'{4}'),'{5}'",
                tb_idcliente.Text
                //Continuar depois
                
                );
                Banco.dml(query);
            }
            else
            {
                query = String.Format($"UPDATE");
                Banco.dml(query);
            }
        }
    }
}
