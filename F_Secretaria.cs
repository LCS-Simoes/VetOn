using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace VetOn
{
    public partial class F_Secretaria : Form
    {

        Funcoes funcoes = new Funcoes();
        //Variaveis
        string query = "";
        string vquery = "";
        string searchID;
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

        public F_Secretaria()
        {
            InitializeComponent();
        }

        private void F_Secretaria_Load(object sender, EventArgs e)
        {
            vquery = @"SELECT c.n_idcliente as 'ID Cliente', c.t_nomecliente as 'Nome Cliente',
            a.n_idanimal as 'ID Animal', a.t_nomeanimal as 'Nome Animal', a.t_especie as 'Espécie'
            FROM tb_clientes c
            LEFT JOIN tb_animais a ON c.n_idcliente = a.n_idcliente
            ORDER BY c.t_nomecliente";
            dgv_clientes.DataSource = Banco.dql(vquery);
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
                searchID = dgv_clientes.Rows[dgv_clientes.SelectedRows[0].Index].Cells[0].Value.ToString();
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
                }
                else {
                    //Otimizar
                    tb_idanimal.Clear();
                    tb_nomeanimal.Clear();
                    tb_especieanimal.Clear();
                    tb_racaanimal.Clear();
                    cb_generoanimal.Text = "";
                    np_idadeanimal.Value = 0;
                    pb_animal.ImageLocation = @"D:\VetOn\images\user.png";
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
            int atualizou = 0;
            ValidacoesClientes();
            if(tb_idcliente.Text == "")
            {
                query = String.Format(@"INSERT INTO tb_clientes (t_nomecliente, t_cpf, t_telefone, t_cep, n_numerocasa, t_rua, t_cidade, t_bairro) VALUES ('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}')",
                tb_nomecliente.Text,
                mb_cpf.Text,
                mb_celular.Text,
                mb_cep.Text,
                np_numero.Value,
                tb_rua.Text,
                tb_cidade.Text,
                tb_bairro.Text
                );
                MessageBox.Show("Novo Cliente Cadastrado");
            }
            else
            {
                query = String.Format(@"UPDATE tb_clientes SET t_nomecliente='{0}', t_cpf='{1}', t_telefone='{2}', t_cep='{3}', n_numerocasa={4}, t_rua='{5}', t_cidade='{6}', t_bairro='{7}', WHERE n_idcliente={8}",
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
                atualizou = 1;
            }
            Banco.dml(query);
            int linha = dgv_clientes.SelectedRows[0].Index;

            if(atualizou == 1)
            {
                dgv_clientes[1, linha].Value = tb_nomecliente.Text;
            }
            else
            {
                dgv_clientes.DataSource = Banco.dql(vquery);
            }
        }

        private void btn_salvarAnimal_Click(object sender, EventArgs e)
        {
            int atualizou = 0;

            //Verificando fotos
            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_animal.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar foto, deseja continuar", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
                }
            }

            if (tb_idanimal.Text == "")
            {
                query = String.Format(@"INSERT INTO tb_animais (n_idcliente, t_nomeanimal, t_raca, n_idade, t_genero, t_especie, t_fotos)
                VALUES ({0},'{1}','{2}',{3},'{4}','{5}', '{6}')",
                tb_idcliente.Text,
                tb_nomeanimal.Text,
                tb_racaanimal.Text,
                np_idadeanimal.Value,
                cb_generoanimal.Text,
                tb_especieanimal.Text,
                destinoCompleto
                );
            }
            else
            {
                query = String.Format(@"UPDATE tb_animais SET t_nomeanimal='{0}', t_raca='{1}', n_idade={2}, t_genero='{3}', t_especie='{4}', t_fotos='{5}', n_idcliente={6} WHERE n_idanimal={7}",
                tb_nomeanimal.Text,
                tb_racaanimal.Text,
                np_idadeanimal.Value,
                cb_generoanimal.Text,
                tb_especieanimal.Text,
                destinoCompleto,
                tb_idcliente.Text,
                tb_idanimal.Text
                );
                atualizou = 1;
            }
            Banco.dml(query);

            int linha = dgv_clientes.SelectedRows[0].Index;

            if (atualizou == 1)
            {
                dgv_clientes[2, linha].Value = tb_idanimal.Text;
                dgv_clientes[3, linha].Value = tb_nomeanimal.Text;
                dgv_clientes[4, linha].Value = tb_especieanimal.Text;
            }
            else
            {
                dgv_clientes.DataSource = Banco.dql(vquery);
            }
        }

        private void btn_cadastrargeral_Click(object sender, EventArgs e)
        {
            
            if(tb_idanimal.Text == "" && tb_idcliente.Text == "")
            {
                //Solução PROVISÓRIA
                try
                {
                    string inserirCliente = String.Format(@"INSERT INTO tb_clientes (t_nomecliente, t_cpf, t_telefone, t_cep, n_numerocasa, t_rua, t_cidade, t_bairro)
                    VALUES ('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}');
                    SELECT SCOPE_IDENTITY()",
                    tb_nomecliente.Text,
                    mb_cpf.Text,
                    mb_celular.Text,
                    mb_cep.Text,
                    np_numero.Value,
                    tb_rua.Text,
                    tb_cidade.Text,
                    tb_bairro.Text
                    );

                    //Jeito de recuperar o ID do cliente criado
                    object result = Banco.getScalar(inserirCliente);
                    int idCliente = Convert.ToInt32(result);


                    //Verificação de fotos
                    if (destinoCompleto == "")
                    {
                        if (MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
                    }
                    if (destinoCompleto != "")
                    {
                        System.IO.File.Copy(origemCompleto,destinoCompleto, true);
                        if (File.Exists(destinoCompleto))
                        {
                            pb_animal.ImageLocation = destinoCompleto;
                        }
                        else
                        {
                            if (MessageBox.Show("Erro ao localizar foto, deseja continuar", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
                        }

                    }

                    //Inserindo Animal com o ID do cliente 
                    string inserirAnimal = String.Format(@"INSERT INTO tb_animais (n_idcliente, t_nomeanimal, t_raca, n_idade, t_genero, t_especie, t_fotos)
                    VALUES ({0},'{1}','{2}',{3},'{4}','{5}','{6}')",
                    idCliente,
                    tb_nomeanimal.Text,
                    tb_racaanimal.Text,
                    np_idadeanimal.Value,
                    cb_generoanimal.Text,
                    tb_especieanimal.Text,
                    destinoCompleto
                    );

                    Banco.dml(inserirAnimal);
                    dgv_clientes.DataSource = Banco.dql(vquery);
                    MessageBox.Show("Cliente e animal cadastrados com sucesso!");


                }catch(Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }

            }else
            {
                MessageBox.Show("Impossível realizar ação: cliente ou animal já existem");
            }
        }

        private void btn_addFoto_Click(object sender, EventArgs e)
        {
        
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName; 
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }

            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Susbstituir", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            }
             pb_animal.ImageLocation = destinoCompleto;    
        }
        //OBSERVÃÇÕES CLASSES --> Atualizar todos os SQL depois para um repository para cada classe 
    }
}
