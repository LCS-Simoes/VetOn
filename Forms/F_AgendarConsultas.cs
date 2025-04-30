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

namespace VetOn
{
    public partial class F_AgendarConsultas : Form
    {
        string vquery = "";
        string searchID = "";

        public F_AgendarConsultas()
        {
            InitializeComponent();
        }

        private void F_AgendarConsultas_Load(object sender, EventArgs e)
        {
  
            vquery = @"SELECT a.n_idagenda as 'ID Agenda', 
            a.t_data as 'Data',
            a.t_horario as 'Horário',
            c.t_nomecliente as 'Nome do Cliente',
            animais.t_nomeanimal as 'Nome do Animal',
            v.t_nomeveterinario as 'Veterinário(a)'
            FROM tb_agenda a
            LEFT JOIN tb_clientes c ON a.n_idcliente = c.n_idcliente
            LEFT JOIN tb_animais animais ON a.n_idanimal = animais.n_idanimal
            LEFT JOIN tb_veterinarios v ON a.n_idveterinario = v.n_idveterinario
            ORDER BY a.t_data";
            dgv_consultas.DataSource = Banco.dql(vquery);
            dgv_consultas.Columns[0].Width = 50;
            dgv_consultas.Columns[1].Width = 70;
            dgv_consultas.Columns[2].Width = 50;
            dgv_consultas.Columns[3].Width = 140;
            dgv_consultas.Columns[4].Width = 100;
            dgv_consultas.Columns[5].Width = 90;
        }

        private void dgv_consultas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;    
            int cont = dgv.SelectedRows.Count;

            if(cont > 0)
            {
               searchID = dgv_consultas.Rows[dgv_consultas.SelectedRows[0].Index].Cells[0].Value.ToString();
               AgendaRepository.listarAgendas(searchID, tb_idagenda, tb_idcliente, tb_idanimal, tb_nomeanimal, tb_nomecliente, cb_horario, cb_nomeveterinario, mb_cpf, mb_celular, dtp_consulta);
            }
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            if(tb_idagenda.Text == "")
            {
                AgendaRepository.Agendar(tb_idcliente, tb_idanimal, cb_horario, cb_nomeveterinario, dtp_consulta);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btn_remarcar_Click(object sender, EventArgs e)
        {

        }

        private void btn_desmarcar_Click(object sender, EventArgs e)
        {

        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            AgendaRepository.Procurar(tb_nomecliente, tb_idcliente, mb_cpf, mb_celular, tb_idanimal, tb_nomeanimal);   
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_idagenda.Clear();
            tb_idcliente.Clear();
            tb_nomecliente.Clear();
            mb_celular.Clear();
            mb_cpf.Clear();
            tb_idanimal.Clear();
            tb_nomeanimal.Clear();
            tb_idconsulta.Clear();
            cb_horario.Text = "";
            cb_nomeveterinario.Text = "";

        }
    }
}
