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
using VetOn.Repositories;

namespace VetOn.Forms
{
    public partial class F_Manutencao : Form
    {

        string globalQuery;
        string searchID;

        public F_Manutencao()
        {
            InitializeComponent();
        }

        
        private void F_Manutencao_Load(object sender, EventArgs e)
        {
            globalQuery = @"SELECT n_idusuario AS 'ID', t_nomeusuario AS 'Nome', t_username AS 'Username', t_status AS 'Status', t_nivel AS 'Função' FROM tb_usuarios";
            dgv_usuarios.DataSource = Banco.dql(globalQuery);
            dgv_usuarios.Columns[0].Width = 30;
            dgv_usuarios.Columns[1].Width = 50;
            dgv_usuarios.Columns[2].Width = 60;
            dgv_usuarios.Columns[3].Width = 50;
            dgv_usuarios.Columns[4].Width = 70;
        }


        private void atualizarDGV()
        {
            globalQuery = @"SELECT n_idusuario AS 'ID', t_nomeusuario AS 'Nome', t_username AS 'Username', t_status AS 'Status', t_nivel AS 'Função' FROM tb_usuarios";
            dgv_usuarios.DataSource = Banco.dql(globalQuery);
        }


        //DataGridView
        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;    
            int cont = dgv.SelectedRows.Count;

            if (cont > 0)
            {
                searchID = dgv_usuarios.Rows[dgv_usuarios.SelectedRows[0].Index].Cells[0].Value.ToString();
                ManutencaoRepository.listarUsuarios(searchID, tb_id, tb_nome, tb_senha, tb_username, cb_categoria, cb_status);
            }
        }


        //Buttons 
        private void btn_cadastro_Click(object sender, EventArgs e)
        {

            if (tb_nome.Text == "" || tb_senha.Text == "")
            {
                MessageBox.Show("Impossível cadastrar usuário, formulario com campos vazios");
            }
            else if (tb_nome.Text != "" && tb_senha.Text != "")
            {
                if(cb_status.Text !=  "" && cb_categoria.Text != "")
                {
                    if (tb_username.Text != "")
                    {
                        ManutencaoRepository.CadastrarUsuarios(tb_nome, tb_senha, tb_username, cb_categoria, cb_status);
                        atualizarDGV();
                    }
                }
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
           searchID = dgv_usuarios.Rows[dgv_usuarios.SelectedRows[0].Index].Cells[0].Value.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_username.Clear();
            tb_id.Clear();
            tb_nome.Clear();
            tb_senha.Clear();
            cb_categoria.Text = "";
            cb_status.Text = ""; 
        }
    }
}
