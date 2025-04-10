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
        public F_Secretaria()
        {
            InitializeComponent();
        }

        private void agenderConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void F_Secretaria_Load(object sender, EventArgs e)
        {

        }

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
            mb_celular.Clear();
            mb_cep.Clear();
            mb_cpf.Clear();
            np_numero.Value = 0;
            tb_cidade.Clear();
            
            //Campos Animais
            tb_idanimal.Clear();
            tb_nomeanimal.Clear();
            tb_especieanimal.Clear();
            tb_racaanimal.Clear();
            cb_generoanimal.Text = "";
            np_idadeanimal.Value = 0;
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
