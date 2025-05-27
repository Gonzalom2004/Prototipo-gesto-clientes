namespace Gestor_De_Clientes
{
    partial class Detalles_Modificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bconfirmar_dispositivo = new System.Windows.Forms.Button();
            this.CBmodificar_dispositivo = new System.Windows.Forms.CheckBox();
            this.Tcomentario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Ttipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DTPingreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tfalla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TmarcaModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bconfirmar_cliente = new System.Windows.Forms.Button();
            this.CBmodificar_cliente = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Ttelefono = new System.Windows.Forms.TextBox();
            this.DTPfecha_alta = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Tapellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tnombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tid_cliente = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID dispositivo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tid
            // 
            this.Tid.Enabled = false;
            this.Tid.Location = new System.Drawing.Point(125, 25);
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(32, 20);
            this.Tid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "//Aca podria ir una imagen del dispositivo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Bconfirmar_dispositivo);
            this.groupBox1.Controls.Add(this.CBmodificar_dispositivo);
            this.groupBox1.Controls.Add(this.Tcomentario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Ttipo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DTPingreso);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CBestado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Tfalla);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TmarcaModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 380);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle dispositivo:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Bconfirmar_dispositivo
            // 
            this.Bconfirmar_dispositivo.Location = new System.Drawing.Point(205, 343);
            this.Bconfirmar_dispositivo.Name = "Bconfirmar_dispositivo";
            this.Bconfirmar_dispositivo.Size = new System.Drawing.Size(75, 23);
            this.Bconfirmar_dispositivo.TabIndex = 15;
            this.Bconfirmar_dispositivo.Text = "Confirmar";
            this.Bconfirmar_dispositivo.UseVisualStyleBackColor = true;
            // 
            // CBmodificar_dispositivo
            // 
            this.CBmodificar_dispositivo.AutoSize = true;
            this.CBmodificar_dispositivo.Location = new System.Drawing.Point(10, 347);
            this.CBmodificar_dispositivo.Name = "CBmodificar_dispositivo";
            this.CBmodificar_dispositivo.Size = new System.Drawing.Size(69, 17);
            this.CBmodificar_dispositivo.TabIndex = 14;
            this.CBmodificar_dispositivo.Text = "Modificar";
            this.CBmodificar_dispositivo.UseVisualStyleBackColor = true;
            this.CBmodificar_dispositivo.CheckedChanged += new System.EventHandler(this.CBmodificar_CheckedChanged);
            // 
            // Tcomentario
            // 
            this.Tcomentario.Location = new System.Drawing.Point(30, 271);
            this.Tcomentario.Multiline = true;
            this.Tcomentario.Name = "Tcomentario";
            this.Tcomentario.Size = new System.Drawing.Size(226, 59);
            this.Tcomentario.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Comentario:";
            // 
            // Ttipo
            // 
            this.Ttipo.Location = new System.Drawing.Point(125, 60);
            this.Ttipo.Name = "Ttipo";
            this.Ttipo.Size = new System.Drawing.Size(91, 20);
            this.Ttipo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tipo:";
            // 
            // DTPingreso
            // 
            this.DTPingreso.Enabled = false;
            this.DTPingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPingreso.Location = new System.Drawing.Point(125, 212);
            this.DTPingreso.Name = "DTPingreso";
            this.DTPingreso.Size = new System.Drawing.Size(131, 20);
            this.DTPingreso.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de ingreso:";
            // 
            // CBestado
            // 
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Items.AddRange(new object[] {
            "A reparar",
            "Reparado"});
            this.CBestado.Location = new System.Drawing.Point(125, 175);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(121, 21);
            this.CBestado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado:";
            // 
            // Tfalla
            // 
            this.Tfalla.Location = new System.Drawing.Point(125, 135);
            this.Tfalla.Name = "Tfalla";
            this.Tfalla.Size = new System.Drawing.Size(91, 20);
            this.Tfalla.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Falla:";
            // 
            // TmarcaModelo
            // 
            this.TmarcaModelo.Location = new System.Drawing.Point(125, 97);
            this.TmarcaModelo.Name = "TmarcaModelo";
            this.TmarcaModelo.Size = new System.Drawing.Size(91, 20);
            this.TmarcaModelo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca/Modelo:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.Bconfirmar_cliente);
            this.groupBox2.Controls.Add(this.CBmodificar_cliente);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Ttelefono);
            this.groupBox2.Controls.Add(this.DTPfecha_alta);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Tapellido);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Tnombre);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Tid_cliente);
            this.groupBox2.Location = new System.Drawing.Point(342, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del propietario";
            // 
            // Bconfirmar_cliente
            // 
            this.Bconfirmar_cliente.Location = new System.Drawing.Point(215, 159);
            this.Bconfirmar_cliente.Name = "Bconfirmar_cliente";
            this.Bconfirmar_cliente.Size = new System.Drawing.Size(75, 23);
            this.Bconfirmar_cliente.TabIndex = 16;
            this.Bconfirmar_cliente.Text = "Confirmar";
            this.Bconfirmar_cliente.UseVisualStyleBackColor = true;
            // 
            // CBmodificar_cliente
            // 
            this.CBmodificar_cliente.AutoSize = true;
            this.CBmodificar_cliente.Location = new System.Drawing.Point(29, 165);
            this.CBmodificar_cliente.Name = "CBmodificar_cliente";
            this.CBmodificar_cliente.Size = new System.Drawing.Size(69, 17);
            this.CBmodificar_cliente.TabIndex = 16;
            this.CBmodificar_cliente.Text = "Modificar";
            this.CBmodificar_cliente.UseVisualStyleBackColor = true;
            this.CBmodificar_cliente.CheckedChanged += new System.EventHandler(this.CBmodificar_cliente_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Telefono:";
            // 
            // Ttelefono
            // 
            this.Ttelefono.Enabled = false;
            this.Ttelefono.Location = new System.Drawing.Point(124, 97);
            this.Ttelefono.Name = "Ttelefono";
            this.Ttelefono.Size = new System.Drawing.Size(91, 20);
            this.Ttelefono.TabIndex = 21;
            // 
            // DTPfecha_alta
            // 
            this.DTPfecha_alta.Enabled = false;
            this.DTPfecha_alta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPfecha_alta.Location = new System.Drawing.Point(124, 123);
            this.DTPfecha_alta.Name = "DTPfecha_alta";
            this.DTPfecha_alta.Size = new System.Drawing.Size(105, 20);
            this.DTPfecha_alta.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Fecha de alta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.label11.Location = new System.Drawing.Point(26, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Apellido:";
            // 
            // Tapellido
            // 
            this.Tapellido.Enabled = false;
            this.Tapellido.Location = new System.Drawing.Point(124, 71);
            this.Tapellido.Name = "Tapellido";
            this.Tapellido.Size = new System.Drawing.Size(91, 20);
            this.Tapellido.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nombre:";
            // 
            // Tnombre
            // 
            this.Tnombre.Enabled = false;
            this.Tnombre.Location = new System.Drawing.Point(124, 45);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.Size = new System.Drawing.Size(91, 20);
            this.Tnombre.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID cliente:";
            // 
            // Tid_cliente
            // 
            this.Tid_cliente.Enabled = false;
            this.Tid_cliente.Location = new System.Drawing.Point(124, 19);
            this.Tid_cliente.Name = "Tid_cliente";
            this.Tid_cliente.Size = new System.Drawing.Size(32, 20);
            this.Tid_cliente.TabIndex = 15;
            // 
            // Detalles_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Detalles_Modificar";
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.Detalles_Modificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tfalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TmarcaModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPingreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Ttipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tcomentario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tid_cliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Ttelefono;
        private System.Windows.Forms.DateTimePicker DTPfecha_alta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Tapellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tnombre;
        private System.Windows.Forms.Button Bconfirmar_dispositivo;
        private System.Windows.Forms.CheckBox CBmodificar_dispositivo;
        private System.Windows.Forms.Button Bconfirmar_cliente;
        private System.Windows.Forms.CheckBox CBmodificar_cliente;
    }
}