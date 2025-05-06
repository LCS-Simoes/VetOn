namespace VetOn.Forms
{
    partial class F_VerificarConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_VerificarConsultas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nivelacesso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_nomeusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_vConsulta = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_idagenda = new System.Windows.Forms.TextBox();
            this.tb_nomecliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_idcliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_idanimal = new System.Windows.Forms.TextBox();
            this.tb_nomeanimal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_nomeveterinario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_idconsulta = new System.Windows.Forms.TextBox();
            this.tb_fila = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_nivelacesso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_nomeusuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 32);
            this.panel1.TabIndex = 0;
            // 
            // lb_nivelacesso
            // 
            this.lb_nivelacesso.AutoSize = true;
            this.lb_nivelacesso.Location = new System.Drawing.Point(232, 13);
            this.lb_nivelacesso.Name = "lb_nivelacesso";
            this.lb_nivelacesso.Size = new System.Drawing.Size(19, 13);
            this.lb_nivelacesso.TabIndex = 11;
            this.lb_nivelacesso.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nível de Acesso:";
            // 
            // lb_nomeusuario
            // 
            this.lb_nomeusuario.AutoSize = true;
            this.lb_nomeusuario.Location = new System.Drawing.Point(98, 14);
            this.lb_nomeusuario.Name = "lb_nomeusuario";
            this.lb_nomeusuario.Size = new System.Drawing.Size(19, 13);
            this.lb_nomeusuario.TabIndex = 9;
            this.lb_nomeusuario.Text = "----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_vConsulta
            // 
            this.dgv_vConsulta.AllowUserToAddRows = false;
            this.dgv_vConsulta.AllowUserToDeleteRows = false;
            this.dgv_vConsulta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_vConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vConsulta.Location = new System.Drawing.Point(463, 12);
            this.dgv_vConsulta.Name = "dgv_vConsulta";
            this.dgv_vConsulta.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vConsulta.Size = new System.Drawing.Size(604, 471);
            this.dgv_vConsulta.TabIndex = 1;
            this.dgv_vConsulta.SelectionChanged += new System.EventHandler(this.dgv_vConsulta_SelectionChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1057, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(10, 472);
            this.vScrollBar1.TabIndex = 2;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.MintCream;
            this.btn_confirmar.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(11, 267);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(111, 25);
            this.btn_confirmar.TabIndex = 38;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "ID Agenda";
            // 
            // tb_idagenda
            // 
            this.tb_idagenda.Location = new System.Drawing.Point(11, 51);
            this.tb_idagenda.Name = "tb_idagenda";
            this.tb_idagenda.ReadOnly = true;
            this.tb_idagenda.Size = new System.Drawing.Size(85, 20);
            this.tb_idagenda.TabIndex = 56;
            this.tb_idagenda.TabStop = false;
            // 
            // tb_nomecliente
            // 
            this.tb_nomecliente.Location = new System.Drawing.Point(127, 102);
            this.tb_nomecliente.Name = "tb_nomecliente";
            this.tb_nomecliente.Size = new System.Drawing.Size(233, 20);
            this.tb_nomecliente.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Nome Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "ID Cliente";
            // 
            // tb_idcliente
            // 
            this.tb_idcliente.Location = new System.Drawing.Point(12, 102);
            this.tb_idcliente.Name = "tb_idcliente";
            this.tb_idcliente.ReadOnly = true;
            this.tb_idcliente.Size = new System.Drawing.Size(85, 20);
            this.tb_idcliente.TabIndex = 52;
            this.tb_idcliente.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "ID Animal";
            // 
            // tb_idanimal
            // 
            this.tb_idanimal.Location = new System.Drawing.Point(12, 167);
            this.tb_idanimal.Name = "tb_idanimal";
            this.tb_idanimal.ReadOnly = true;
            this.tb_idanimal.Size = new System.Drawing.Size(85, 20);
            this.tb_idanimal.TabIndex = 60;
            this.tb_idanimal.TabStop = false;
            // 
            // tb_nomeanimal
            // 
            this.tb_nomeanimal.Location = new System.Drawing.Point(127, 167);
            this.tb_nomeanimal.Name = "tb_nomeanimal";
            this.tb_nomeanimal.Size = new System.Drawing.Size(233, 20);
            this.tb_nomeanimal.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Nome do Animalzino";
            // 
            // cb_nomeveterinario
            // 
            this.cb_nomeveterinario.FormattingEnabled = true;
            this.cb_nomeveterinario.Location = new System.Drawing.Point(11, 225);
            this.cb_nomeveterinario.Name = "cb_nomeveterinario";
            this.cb_nomeveterinario.Size = new System.Drawing.Size(122, 21);
            this.cb_nomeveterinario.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nome Veterinário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Presente",
            "Atraso",
            "Não compareceu"});
            this.cb_status.Location = new System.Drawing.Point(152, 225);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(122, 21);
            this.cb_status.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "ID Consulta";
            // 
            // tb_idconsulta
            // 
            this.tb_idconsulta.Location = new System.Drawing.Point(13, 326);
            this.tb_idconsulta.Name = "tb_idconsulta";
            this.tb_idconsulta.ReadOnly = true;
            this.tb_idconsulta.Size = new System.Drawing.Size(85, 20);
            this.tb_idconsulta.TabIndex = 67;
            this.tb_idconsulta.TabStop = false;
            // 
            // tb_fila
            // 
            this.tb_fila.Location = new System.Drawing.Point(127, 326);
            this.tb_fila.Name = "tb_fila";
            this.tb_fila.ReadOnly = true;
            this.tb_fila.Size = new System.Drawing.Size(85, 20);
            this.tb_fila.TabIndex = 69;
            this.tb_fila.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Posição Fila";
            // 
            // F_VerificarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1074, 521);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_fila);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_idconsulta);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_nomeveterinario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_idanimal);
            this.Controls.Add(this.tb_nomeanimal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_idagenda);
            this.Controls.Add(this.tb_nomecliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_idcliente);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dgv_vConsulta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_VerificarConsultas";
            this.Text = "Consultas Diaria";
            this.Load += new System.EventHandler(this.F_VerificarConsultas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lb_nivelacesso;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_nomeusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_vConsulta;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_idagenda;
        private System.Windows.Forms.TextBox tb_nomecliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_idcliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_idanimal;
        private System.Windows.Forms.TextBox tb_nomeanimal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_nomeveterinario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_idconsulta;
        private System.Windows.Forms.TextBox tb_fila;
        private System.Windows.Forms.Label label8;
    }
}