namespace Gestor_De_Clientes
{
    partial class FAgregarDispositivo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ttipo = new System.Windows.Forms.TextBox();
            this.Tmarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tfalla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tcomentario = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbuscarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Ttelefono = new System.Windows.Forms.TextBox();
            this.Tapellido = new System.Windows.Forms.TextBox();
            this.Tnombre = new System.Windows.Forms.TextBox();
            this.CHagregar = new System.Windows.Forms.CheckBox();
            this.Bagregar = new System.Windows.Forms.Button();
            this.epValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.CHcomentario = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de dispositivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca / Modelo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Ttipo
            // 
            this.Ttipo.Location = new System.Drawing.Point(16, 35);
            this.Ttipo.Name = "Ttipo";
            this.Ttipo.Size = new System.Drawing.Size(100, 20);
            this.Ttipo.TabIndex = 2;
            // 
            // Tmarca
            // 
            this.Tmarca.Location = new System.Drawing.Point(16, 100);
            this.Tmarca.Name = "Tmarca";
            this.Tmarca.Size = new System.Drawing.Size(100, 20);
            this.Tmarca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Falla";
            // 
            // Tfalla
            // 
            this.Tfalla.Location = new System.Drawing.Point(16, 166);
            this.Tfalla.Name = "Tfalla";
            this.Tfalla.Size = new System.Drawing.Size(100, 20);
            this.Tfalla.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado";
            // 
            // CBestado
            // 
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Items.AddRange(new object[] {
            "A reparar",
            "Reparado"});
            this.CBestado.Location = new System.Drawing.Point(16, 235);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(121, 21);
            this.CBestado.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHcomentario);
            this.groupBox1.Controls.Add(this.Tcomentario);
            this.groupBox1.Controls.Add(this.Ttipo);
            this.groupBox1.Controls.Add(this.CBestado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tfalla);
            this.groupBox1.Controls.Add(this.Tmarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 387);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del dispositivo";
            // 
            // Tcomentario
            // 
            this.Tcomentario.Location = new System.Drawing.Point(16, 294);
            this.Tcomentario.Name = "Tcomentario";
            this.Tcomentario.Size = new System.Drawing.Size(214, 78);
            this.Tcomentario.TabIndex = 10;
            this.Tcomentario.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbuscarCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Ttelefono);
            this.groupBox2.Controls.Add(this.Tapellido);
            this.groupBox2.Controls.Add(this.Tnombre);
            this.groupBox2.Controls.Add(this.CHagregar);
            this.groupBox2.Location = new System.Drawing.Point(298, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 291);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente ";
            // 
            // TbuscarCliente
            // 
            this.TbuscarCliente.Location = new System.Drawing.Point(89, 15);
            this.TbuscarCliente.Name = "TbuscarCliente";
            this.TbuscarCliente.Size = new System.Drawing.Size(90, 23);
            this.TbuscarCliente.TabIndex = 12;
            this.TbuscarCliente.Text = "Buscar Cliente";
            this.TbuscarCliente.UseVisualStyleBackColor = true;
            this.TbuscarCliente.Click += new System.EventHandler(this.TbuscarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre:";
            // 
            // Ttelefono
            // 
            this.Ttelefono.Location = new System.Drawing.Point(6, 205);
            this.Ttelefono.Name = "Ttelefono";
            this.Ttelefono.Size = new System.Drawing.Size(127, 20);
            this.Ttelefono.TabIndex = 10;
            // 
            // Tapellido
            // 
            this.Tapellido.Location = new System.Drawing.Point(6, 146);
            this.Tapellido.Name = "Tapellido";
            this.Tapellido.Size = new System.Drawing.Size(127, 20);
            this.Tapellido.TabIndex = 9;
            // 
            // Tnombre
            // 
            this.Tnombre.Location = new System.Drawing.Point(6, 81);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.Size = new System.Drawing.Size(127, 20);
            this.Tnombre.TabIndex = 8;
            // 
            // CHagregar
            // 
            this.CHagregar.AutoSize = true;
            this.CHagregar.Location = new System.Drawing.Point(20, 19);
            this.CHagregar.Name = "CHagregar";
            this.CHagregar.Size = new System.Drawing.Size(63, 17);
            this.CHagregar.TabIndex = 0;
            this.CHagregar.Text = "Agregar";
            this.CHagregar.UseVisualStyleBackColor = true;
            this.CHagregar.CheckedChanged += new System.EventHandler(this.CHagregar_CheckedChanged);
            // 
            // Bagregar
            // 
            this.Bagregar.Location = new System.Drawing.Point(481, 320);
            this.Bagregar.Name = "Bagregar";
            this.Bagregar.Size = new System.Drawing.Size(75, 23);
            this.Bagregar.TabIndex = 11;
            this.Bagregar.Text = "Agregar";
            this.Bagregar.UseVisualStyleBackColor = true;
            this.Bagregar.Click += new System.EventHandler(this.Bagregar_Click);
            // 
            // epValidacion
            // 
            this.epValidacion.ContainerControl = this;
            // 
            // CHcomentario
            // 
            this.CHcomentario.AutoSize = true;
            this.CHcomentario.Location = new System.Drawing.Point(16, 271);
            this.CHcomentario.Name = "CHcomentario";
            this.CHcomentario.Size = new System.Drawing.Size(125, 17);
            this.CHcomentario.TabIndex = 15;
            this.CHcomentario.Text = "Comentario Adicional";
            this.CHcomentario.UseVisualStyleBackColor = true;
            this.CHcomentario.CheckedChanged += new System.EventHandler(this.CHcomentario_CheckedChanged);
            // 
            // FAgregarDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bagregar);
            this.Name = "FAgregarDispositivo";
            this.Text = "Agregar Dispositivo";
            this.Load += new System.EventHandler(this.FAgregarDispositivo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ttipo;
        private System.Windows.Forms.TextBox Tmarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tfalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CHagregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Bagregar;
        private System.Windows.Forms.TextBox Ttelefono;
        private System.Windows.Forms.TextBox Tapellido;
        private System.Windows.Forms.TextBox Tnombre;
        private System.Windows.Forms.ErrorProvider epValidacion;
        private System.Windows.Forms.RichTextBox Tcomentario;
        private System.Windows.Forms.Button TbuscarCliente;
        private System.Windows.Forms.CheckBox CHcomentario;
    }
}