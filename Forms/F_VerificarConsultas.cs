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
    public partial class F_VerificarConsultas : Form
    {

        string vquery = "";
        string searchID = "";

        public F_VerificarConsultas()
        {
            InitializeComponent();
            lb_nivelacesso.Text = Globais.nivel;
        }


        private void F_VerificarConsultas_Load(object sender, EventArgs e)
        {

            //Corrigir query para listar DIA
            vquery = @"SELECT a.n_idagenda as 'ID Agenda', 
            a.t_data as 'Data',
            a.t_horario as 'Horário',
            a.t_status as 'Status',
            c.t_nomecliente as 'Nome do Cliente',
            animais.t_nomeanimal as 'Nome do Animal',
            v.t_nomeveterinario as 'Veterinário(a)'
            FROM tb_agenda a
            LEFT JOIN tb_clientes c ON a.n_idcliente = c.n_idcliente
            LEFT JOIN tb_animais animais ON a.n_idanimal = animais.n_idanimal
            LEFT JOIN tb_veterinarios v ON a.n_idveterinario = v.n_idveterinario
            ORDER BY a.t_data";
            dgv_vConsulta.DataSource = Banco.dql(vquery);
            dgv_vConsulta.Columns[0].Width = 50;
            dgv_vConsulta.Columns[1].Width = 70;
            dgv_vConsulta.Columns[2].Width = 50;
            dgv_vConsulta.Columns[3].Width = 60;
            dgv_vConsulta.Columns[4].Width = 140;
            dgv_vConsulta.Columns[5].Width = 100;
            dgv_vConsulta.Columns[6].Width = 90;
        }

        private void dgv_vConsulta_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int cont = dgv.SelectedRows.Count;

            if (cont > 0)
            {
                searchID = dgv_vConsulta.Rows[dgv_vConsulta.SelectedRows[0].Index].Cells[0].Value.ToString();
                ConsultaRepository.listarDia(searchID,tb_idagenda, tb_idanimal, tb_idcliente, tb_nomeanimal, tb_nomecliente, cb_nomeveterinario, cb_status, tb_idconsulta);
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if(cb_status.Text == "Presente")
            {
                searchID = dgv_vConsulta.Rows[dgv_vConsulta.SelectedRows[0].Index].Cells[0].Value.ToString();
                ConsultaRepository.CriarConsulta(searchID, cb_status); //corrigir
                dgv_vConsulta.DataSource = Banco.dql(vquery);
            }
            else
            {

            }
        }

    }
}
