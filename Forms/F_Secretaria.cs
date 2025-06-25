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
using VetOn.Forms;
using VetOn.Repositories;

namespace VetOn
{
    public partial class F_Secretaria : Form
    {

        Funcoes funcoes = new Funcoes();
        //Variaveis
        //string query = "";
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
            cb_generoanimal.Items.Add("Macho");
            cb_generoanimal.Items.Add("Fêmea");
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender; 
            int cont = dgv.SelectedRows.Count;

            if(cont > 0)
            {
                searchID = dgv_clientes.Rows[dgv_clientes.SelectedRows[0].Index].Cells[0].Value.ToString(); 
                SecretariaRepository.listarClientes(searchID, tb_idcliente, tb_nomecliente, tb_rua, tb_cidade, tb_bairro, mb_celular, mb_cep, mb_cpf, np_numero);
                if (SecretariaRepository.listarAnimais(searchID, tb_idanimal, tb_nomeanimal, tb_especieanimal, tb_racaanimal, cb_generoanimal, np_idadeanimal, pb_animal))
                {
                    //Apenas para o uso do IF ELSE
                }
                else
                {
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
        
        private void ValidacoesClientes()
        {
            bool resultadoCPF = funcoes.ValidarCPF(mb_cpf.Text);
            bool celular = funcoes.ValidarTelefone(mb_celular.Text);
            bool cep = funcoes.ValidarCEP(mb_cep.Text);
        }

        //MenuStrip
        private void agenderConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_AgendarConsultas f_agendar = new F_AgendarConsultas();
            string nome = lb_nomeusuario.Text;
            f_agendar.lb_nomeusuario.Text = nome;
            f_agendar.Show();
        }

        private void verificarConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_VerificarConsultas f_verificarConsultas = new F_VerificarConsultas();
            string nome = lb_nomeusuario.Text;
            f_verificarConsultas.lb_nomeusuario.Text = nome;
            f_verificarConsultas.Show();
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
                SecretariaRepository.cadastrarCliente(tb_nomecliente, mb_cpf, mb_celular, mb_cep, np_numero, tb_rua, tb_cidade, tb_bairro);
            }
            else
            {
                SecretariaRepository.atualizarCliente(searchID, tb_nomecliente, mb_cpf, mb_celular, mb_cep, np_numero, tb_rua, tb_cidade, tb_bairro);
                atualizou = 1;
            }
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

            //Validação provisoria
            if (cb_generoanimal.Text == "Macho")
            {
                cb_generoanimal.Text = "M";
            }
            else
            {
                cb_generoanimal.Text = "F";
            }

            if (tb_idanimal.Text == "")
            {
                SecretariaRepository.cadastrarAnimal(tb_idcliente, tb_nomeanimal, tb_racaanimal, np_idadeanimal, cb_generoanimal, tb_especieanimal, destinoCompleto);
            }
            else
            {
                SecretariaRepository.atualizarAnimal(tb_idcliente,tb_nomeanimal, tb_racaanimal, np_idadeanimal, cb_generoanimal, tb_especieanimal, destinoCompleto, tb_idanimal);
                atualizou = 1;
            }
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


        //Prestar atenção depois
        private void btn_cadastrargeral_Click(object sender, EventArgs e)
        {
            if (tb_idanimal.Text == "" && tb_idcliente.Text == "")
            {
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
                SecretariaRepository.cadastroGeral(tb_nomecliente, mb_cpf, mb_celular, mb_cep, np_numero, tb_rua, tb_cidade, tb_bairro, tb_idcliente, 
                tb_nomeanimal, tb_racaanimal, np_idadeanimal, cb_generoanimal, tb_especieanimal, destinoCompleto);
            }else
            {
                MessageBox.Show("Impossível realizar ação: cliente ou animal seus campos preenchidos");
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
    }
}
