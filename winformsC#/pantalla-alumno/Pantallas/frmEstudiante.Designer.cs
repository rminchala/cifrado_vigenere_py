namespace practica_al.Pantallas
{
    partial class frmEstudiante
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblpaterno = new System.Windows.Forms.Label();
            this.lblmaterno = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnok = new System.Windows.Forms.Button();
            this.textConsulta = new System.Windows.Forms.TextBox();
            this.lblconsulta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textgenero = new System.Windows.Forms.TextBox();
            this.cmbgenero = new System.Windows.Forms.ComboBox();
            this.textmaterno = new System.Windows.Forms.TextBox();
            this.textpaterno = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnactualiza = new System.Windows.Forms.Button();
            this.btnelimina = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(121, 30);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(71, 16);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre :";
            // 
            // lblpaterno
            // 
            this.lblpaterno.AutoSize = true;
            this.lblpaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaterno.Location = new System.Drawing.Point(60, 74);
            this.lblpaterno.Name = "lblpaterno";
            this.lblpaterno.Size = new System.Drawing.Size(132, 16);
            this.lblpaterno.TabIndex = 1;
            this.lblpaterno.Text = "Apellido Paterno :";
            // 
            // lblmaterno
            // 
            this.lblmaterno.AutoSize = true;
            this.lblmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaterno.Location = new System.Drawing.Point(58, 121);
            this.lblmaterno.Name = "lblmaterno";
            this.lblmaterno.Size = new System.Drawing.Size(134, 16);
            this.lblmaterno.TabIndex = 2;
            this.lblmaterno.Text = "Apellido Materno :";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.Location = new System.Drawing.Point(125, 166);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(67, 16);
            this.lblgenero.TabIndex = 3;
            this.lblgenero.Text = "Género :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.textConsulta);
            this.panel1.Controls.Add(this.lblconsulta);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textgenero);
            this.panel1.Controls.Add(this.cmbgenero);
            this.panel1.Controls.Add(this.textmaterno);
            this.panel1.Controls.Add(this.textpaterno);
            this.panel1.Controls.Add(this.textnombre);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Controls.Add(this.lblgenero);
            this.panel1.Controls.Add(this.lblpaterno);
            this.panel1.Controls.Add(this.lblmaterno);
            this.panel1.Location = new System.Drawing.Point(67, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 241);
            this.panel1.TabIndex = 4;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(416, 206);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(31, 23);
            this.btnok.TabIndex = 13;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Visible = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // textConsulta
            // 
            this.textConsulta.Location = new System.Drawing.Point(335, 207);
            this.textConsulta.Name = "textConsulta";
            this.textConsulta.Size = new System.Drawing.Size(78, 20);
            this.textConsulta.TabIndex = 12;
            this.textConsulta.Visible = false;
            // 
            // lblconsulta
            // 
            this.lblconsulta.AutoSize = true;
            this.lblconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsulta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblconsulta.Location = new System.Drawing.Point(125, 208);
            this.lblconsulta.Name = "lblconsulta";
            this.lblconsulta.Size = new System.Drawing.Size(204, 16);
            this.lblconsulta.TabIndex = 11;
            this.lblconsulta.Text = "Ingrese Código a Consultar :";
            this.lblconsulta.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(678, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textgenero
            // 
            this.textgenero.Enabled = false;
            this.textgenero.Location = new System.Drawing.Point(198, 165);
            this.textgenero.Name = "textgenero";
            this.textgenero.Size = new System.Drawing.Size(108, 20);
            this.textgenero.TabIndex = 9;
            // 
            // cmbgenero
            // 
            this.cmbgenero.DisplayMember = "3";
            this.cmbgenero.FormattingEnabled = true;
            this.cmbgenero.Items.AddRange(new object[] {
            "",
            "MASCULINO",
            "FEMENINO"});
            this.cmbgenero.Location = new System.Drawing.Point(314, 165);
            this.cmbgenero.Name = "cmbgenero";
            this.cmbgenero.Size = new System.Drawing.Size(141, 21);
            this.cmbgenero.TabIndex = 8;
            this.cmbgenero.ValueMember = "3";
            // 
            // textmaterno
            // 
            this.textmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textmaterno.Location = new System.Drawing.Point(198, 120);
            this.textmaterno.Name = "textmaterno";
            this.textmaterno.Size = new System.Drawing.Size(335, 20);
            this.textmaterno.TabIndex = 6;
            // 
            // textpaterno
            // 
            this.textpaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textpaterno.Location = new System.Drawing.Point(198, 73);
            this.textpaterno.Name = "textpaterno";
            this.textpaterno.Size = new System.Drawing.Size(335, 20);
            this.textpaterno.TabIndex = 5;
            // 
            // textnombre
            // 
            this.textnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textnombre.Location = new System.Drawing.Point(198, 28);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(335, 20);
            this.textnombre.TabIndex = 4;
            this.textnombre.TextChanged += new System.EventHandler(this.textnombre_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(67, 314);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(792, 182);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(207, 502);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(120, 34);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // btnactualiza
            // 
            this.btnactualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiza.Location = new System.Drawing.Point(337, 502);
            this.btnactualiza.Name = "btnactualiza";
            this.btnactualiza.Size = new System.Drawing.Size(120, 34);
            this.btnactualiza.TabIndex = 7;
            this.btnactualiza.Text = "Actualizar";
            this.btnactualiza.UseVisualStyleBackColor = true;
            this.btnactualiza.Click += new System.EventHandler(this.Btnactualiza_Click);
            // 
            // btnelimina
            // 
            this.btnelimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnelimina.Location = new System.Drawing.Point(726, 502);
            this.btnelimina.Name = "btnelimina";
            this.btnelimina.Size = new System.Drawing.Size(120, 34);
            this.btnelimina.TabIndex = 8;
            this.btnelimina.Text = "Eliminar";
            this.btnelimina.UseVisualStyleBackColor = true;
            this.btnelimina.Click += new System.EventHandler(this.btnelimina_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(597, 502);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(120, 34);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.Location = new System.Drawing.Point(467, 502);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(120, 34);
            this.btnconsultar.TabIndex = 10;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "ESTUDIANTES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(293, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 36);
            this.panel2.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 9000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Mostrar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnelimina);
            this.Controls.Add(this.btnactualiza);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTUDIANTE";
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblpaterno;
        private System.Windows.Forms.Label lblmaterno;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textmaterno;
        private System.Windows.Forms.TextBox textpaterno;
        private System.Windows.Forms.ComboBox cmbgenero;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnactualiza;
        private System.Windows.Forms.Button btnelimina;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textgenero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox textConsulta;
        private System.Windows.Forms.Label lblconsulta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}