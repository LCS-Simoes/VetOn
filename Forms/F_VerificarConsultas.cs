using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetOn.Forms
{
    public partial class F_VerificarConsultas : Form
    {
        public F_VerificarConsultas()
        {
            InitializeComponent();
            lb_nivelacesso.Text = Globais.nivel;
        }


        private void F_VerificarConsultas_Load(object sender, EventArgs e)
        {

        }

        private void dgv_vConsulta_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

        }

    }
}
