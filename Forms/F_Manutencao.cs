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

namespace VetOn.Forms
{
    public partial class F_Manutencao : Form
    {

        string globalQuery;

        public F_Manutencao()
        {
            InitializeComponent();
        }

        
        private void F_Manutencao_Load(object sender, EventArgs e)
        {
            globalQuery = @"SELECT * FROM tb_usuarios";
            dgv_usuarios.DataSource = Banco.dql(globalQuery);
            dgv_usuarios.Columns[0].Width = 10;
            dgv_usuarios.Columns[1].Width = 50;
            dgv_usuarios.Columns[2].Width = 50;
            dgv_usuarios.Columns[3].Width = 10;
            dgv_usuarios.Columns[4].Width = 30;
        }
    }
}
