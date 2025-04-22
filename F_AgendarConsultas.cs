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

namespace VetOn
{
    public partial class F_AgendarConsultas : Form
    {
        string vquery = "";
        string searchID;

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
                DataTable dt = new DataTable();
                searchID;
                string query = @"";
            }
        }
    }
}
