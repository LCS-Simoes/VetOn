namespace VetOn
{
    partial class F_AgendarConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AgendarConsultas));
            this.dgv_consultas = new System.Windows.Forms.DataGridView();
            this.mb_celular = new System.Windows.Forms.MaskedTextBox();
            this.mb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nomecliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_idcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nomeveterinario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idconsulta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dtp_consulta = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_idanimal = new System.Windows.Forms.TextBox();
            this.tb_nomeanimal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_nivelacesso = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_nomeusuario = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.btn_desmarcar = new System.Windows.Forms.Button();
            this.btn_remarcar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_idagenda = new System.Windows.Forms.TextBox();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_consultas
            // 
            this.dgv_consultas.AllowUserToAddRows = false;
            this.dgv_consultas.AllowUserToDeleteRows = false;
            this.dgv_consultas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultas.Location = new System.Drawing.Point(449, 12);
            this.dgv_consultas.MultiSelect = false;
            this.dgv_consultas.Name = "dgv_consultas";
            this.dgv_consultas.ReadOnly = true;
            this.dgv_consultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_consultas.Size = new System.Drawing.Size(595, 469);
            this.dgv_consultas.TabIndex = 0;
            this.dgv_consultas.SelectionChanged += new System.EventHandler(this.dgv_consultas_SelectionChanged);
            // 
            // mb_celular
            // 
            this.mb_celular.Location = new System.Drawing.Point(130, 128);
            this.mb_celular.Mask = "(00)00000-0000";
            this.mb_celular.Name = "mb_celular";
            this.mb_celular.Size = new System.Drawing.Size(149, 20);
            this.mb_celular.TabIndex = 25;
            // 
            // mb_cpf
            // 
            this.mb_cpf.Location = new System.Drawing.Point(15, 128);
            this.mb_cpf.Mask = "000.000.000-00";
            this.mb_cpf.Name = "mb_cpf";
            this.mb_cpf.Size = new System.Drawing.Size(85, 20);
            this.mb_cpf.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Celular ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "CPF";
            // 
            // tb_nomecliente
            // 
            this.tb_nomecliente.Location = new System.Drawing.Point(130, 76);
            this.tb_nomecliente.Name = "tb_nomecliente";
            this.tb_nomecliente.Size = new System.Drawing.Size(233, 20);
            this.tb_nomecliente.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nome Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID Cliente";
            // 
            // tb_idcliente
            // 
            this.tb_idcliente.Location = new System.Drawing.Point(15, 76);
            this.tb_idcliente.Name = "tb_idcliente";
            this.tb_idcliente.ReadOnly = true;
            this.tb_idcliente.Size = new System.Drawing.Size(85, 20);
            this.tb_idcliente.TabIndex = 18;
            this.tb_idcliente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome Veterinário";
            // 
            // cb_nomeveterinario
            // 
            this.cb_nomeveterinario.FormattingEnabled = true;
            this.cb_nomeveterinario.Location = new System.Drawing.Point(130, 236);
            this.cb_nomeveterinario.Name = "cb_nomeveterinario";
            this.cb_nomeveterinario.Size = new System.Drawing.Size(233, 21);
            this.cb_nomeveterinario.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID Consulta";
            // 
            // tb_idconsulta
            // 
            this.tb_idconsulta.Location = new System.Drawing.Point(14, 236);
            this.tb_idconsulta.Name = "tb_idconsulta";
            this.tb_idconsulta.ReadOnly = true;
            this.tb_idconsulta.Size = new System.Drawing.Size(85, 20);
            this.tb_idconsulta.TabIndex = 30;
            this.tb_idconsulta.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Data Consulta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Horários disponiveis";
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(14, 339);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(99, 21);
            this.cb_horario.TabIndex = 35;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1034, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(10, 468);
            this.vScrollBar1.TabIndex = 36;
            // 
            // dtp_consulta
            // 
            this.dtp_consulta.Location = new System.Drawing.Point(14, 292);
            this.dtp_consulta.Name = "dtp_consulta";
            this.dtp_consulta.Size = new System.Drawing.Size(243, 20);
            this.dtp_consulta.TabIndex = 37;
            this.dtp_consulta.Value = new System.DateTime(2025, 4, 29, 18, 11, 19, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "ID Animal";
            // 
            // tb_idanimal
            // 
            this.tb_idanimal.Location = new System.Drawing.Point(14, 180);
            this.tb_idanimal.Name = "tb_idanimal";
            this.tb_idanimal.ReadOnly = true;
            this.tb_idanimal.Size = new System.Drawing.Size(85, 20);
            this.tb_idanimal.TabIndex = 40;
            this.tb_idanimal.TabStop = false;
            // 
            // tb_nomeanimal
            // 
            this.tb_nomeanimal.Location = new System.Drawing.Point(129, 180);
            this.tb_nomeanimal.Name = "tb_nomeanimal";
            this.tb_nomeanimal.Size = new System.Drawing.Size(149, 20);
            this.tb_nomeanimal.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Nome do Animalzino";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lb_nivelacesso
            // 
            this.lb_nivelacesso.AutoSize = true;
            this.lb_nivelacesso.Location = new System.Drawing.Point(229, 11);
            this.lb_nivelacesso.Name = "lb_nivelacesso";
            this.lb_nivelacesso.Size = new System.Drawing.Size(19, 13);
            this.lb_nivelacesso.TabIndex = 45;
            this.lb_nivelacesso.Text = "----";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Nível de Acesso:";
            // 
            // lb_nomeusuario
            // 
            this.lb_nomeusuario.AutoSize = true;
            this.lb_nomeusuario.Location = new System.Drawing.Point(95, 12);
            this.lb_nomeusuario.Name = "lb_nomeusuario";
            this.lb_nomeusuario.Size = new System.Drawing.Size(19, 13);
            this.lb_nomeusuario.TabIndex = 43;
            this.lb_nomeusuario.Text = "----";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Usuário:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_nivelacesso);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lb_nomeusuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 27);
            this.panel1.TabIndex = 46;
            // 
            // btn_agendar
            // 
            this.btn_agendar.BackColor = System.Drawing.Color.MintCream;
            this.btn_agendar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agendar.Location = new System.Drawing.Point(15, 370);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(120, 25);
            this.btn_agendar.TabIndex = 47;
            this.btn_agendar.Text = "Agendar Consulta";
            this.btn_agendar.UseVisualStyleBackColor = false;
            this.btn_agendar.Click += new System.EventHandler(this.btn_agendar_Click);
            // 
            // btn_desmarcar
            // 
            this.btn_desmarcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.btn_desmarcar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desmarcar.Location = new System.Drawing.Point(263, 370);
            this.btn_desmarcar.Name = "btn_desmarcar";
            this.btn_desmarcar.Size = new System.Drawing.Size(117, 25);
            this.btn_desmarcar.TabIndex = 48;
            this.btn_desmarcar.Text = "Desmarcar";
            this.btn_desmarcar.UseVisualStyleBackColor = false;
            this.btn_desmarcar.Click += new System.EventHandler(this.btn_desmarcar_Click);
            // 
            // btn_remarcar
            // 
            this.btn_remarcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_remarcar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remarcar.Location = new System.Drawing.Point(140, 370);
            this.btn_remarcar.Name = "btn_remarcar";
            this.btn_remarcar.Size = new System.Drawing.Size(117, 25);
            this.btn_remarcar.TabIndex = 49;
            this.btn_remarcar.Text = "Remarcar";
            this.btn_remarcar.UseVisualStyleBackColor = false;
            this.btn_remarcar.Click += new System.EventHandler(this.btn_remarcar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "ID Agenda";
            // 
            // tb_idagenda
            // 
            this.tb_idagenda.Location = new System.Drawing.Point(14, 25);
            this.tb_idagenda.Name = "tb_idagenda";
            this.tb_idagenda.ReadOnly = true;
            this.tb_idagenda.Size = new System.Drawing.Size(85, 20);
            this.tb_idagenda.TabIndex = 50;
            this.tb_idagenda.TabStop = false;
            // 
            // btn_procurar
            // 
            this.btn_procurar.BackColor = System.Drawing.Color.MintCream;
            this.btn_procurar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurar.Location = new System.Drawing.Point(369, 74);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(25, 22);
            this.btn_procurar.TabIndex = 52;
            this.btn_procurar.Text = "🔍";
            this.btn_procurar.UseVisualStyleBackColor = false;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.MintCream;
            this.btn_limpar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(119, 335);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(58, 25);
            this.btn_limpar.TabIndex = 53;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // F_AgendarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1056, 525);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_idagenda);
            this.Controls.Add(this.btn_remarcar);
            this.Controls.Add(this.btn_desmarcar);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_idanimal);
            this.Controls.Add(this.tb_nomeanimal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtp_consulta);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_idconsulta);
            this.Controls.Add(this.cb_nomeveterinario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mb_celular);
            this.Controls.Add(this.mb_cpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nomecliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_idcliente);
            this.Controls.Add(this.dgv_consultas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_AgendarConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.F_AgendarConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_consultas;
        private System.Windows.Forms.MaskedTextBox mb_celular;
        private System.Windows.Forms.MaskedTextBox mb_cpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nomecliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_idcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nomeveterinario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idconsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DateTimePicker dtp_consulta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_idanimal;
        private System.Windows.Forms.TextBox tb_nomeanimal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lb_nivelacesso;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lb_nomeusuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_agendar;
        private System.Windows.Forms.Button btn_desmarcar;
        private System.Windows.Forms.Button btn_remarcar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_idagenda;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Button btn_limpar;
    }
}