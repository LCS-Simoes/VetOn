using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetOn.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VetOn
{
    public partial class F_Principal : Form
    {

        DataTable dt = new DataTable();

        public F_Principal()
        {
            InitializeComponent();
        }


        private void VerificarNivel(string nivel)
        {
            if (Globais.nivel == "secretaria")
            {
                F_Secretaria f_secretaria = new F_Secretaria();

                // Componentes extras
                f_secretaria.lb_nomeusuario.Text = dt.Rows[0].Field<string>("t_nomeusuario");
                f_secretaria.lb_nivelacesso.Text = nivel;

                this.Hide(); 
                f_secretaria.ShowDialog(); 
                this.Close(); 
            }
            else if (Globais.nivel == "veterinaria")
            {
               
            }
            else if (Globais.nivel == "farmacia")
            {
              
            }
            else if (Globais.nivel == "manutencao")
            {
                F_Manutencao f_manutencao = new F_Manutencao();
                f_manutencao.lb_nome.Text = dt.Rows[0].Field<string>("t_nomeusuario");

                this.Hide();
                f_manutencao.ShowDialog();
                this.Close();
            }
            else if (Globais.nivel == "gerente")
            {
            }

            else
            {
                MessageBox.Show("Usuário incorreto ou não existe");
            }
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;

            if (tb_usuario.Text == "" || tb_senha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                tb_usuario.Focus();
                return;
            }
            else
            {
                string sql = "SELECT * FROM tb_usuarios WHERE t_username = '" + usuario + "'AND t_senhausuario = '" + senha + "'";
                dt = Banco.dql(sql);

                if(dt.Rows.Count == 1)
                {
                    string nivel = dt.Rows[0].Field<string>("t_nivel");
                    
                    Globais.nivel = nivel;
                    VerificarNivel(nivel);
                }
                else
                {
                    MessageBox.Show("Senha ou Usuário digitado incorretamente");
                }
                
            }

        }
    }
}
