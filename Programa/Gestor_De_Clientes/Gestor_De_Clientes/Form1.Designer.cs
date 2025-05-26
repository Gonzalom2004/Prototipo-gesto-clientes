namespace Gestor_De_Clientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewPendientes = new System.Windows.Forms.ListView();
            this.LVbuscador = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.RBdispositivo = new System.Windows.Forms.RadioButton();
            this.RBcliente = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GBfiltros_cliente = new System.Windows.Forms.GroupBox();
            this.CBfecha_alta = new System.Windows.Forms.CheckBox();
            this.DTPfecha_alta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tid_clientefiltro = new System.Windows.Forms.TextBox();
            this.Tnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tapellido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Ttelefono = new System.Windows.Forms.TextBox();
            this.GBDispositivo = new System.Windows.Forms.GroupBox();
            this.DTPfecha_ingreso_Dispositivo = new System.Windows.Forms.DateTimePicker();
            this.Lid_cliente = new System.Windows.Forms.Label();
            this.Lfechaingreso = new System.Windows.Forms.Label();
            this.Lid = new System.Windows.Forms.Label();
            this.Tcomentario = new System.Windows.Forms.TextBox();
            this.Tid_Dispositivo = new System.Windows.Forms.TextBox();
            this.Lcomentario = new System.Windows.Forms.Label();
            this.Tid_cliente = new System.Windows.Forms.TextBox();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.Ltipo = new System.Windows.Forms.Label();
            this.Lestado = new System.Windows.Forms.Label();
            this.Ttipo = new System.Windows.Forms.TextBox();
            this.Tfalla = new System.Windows.Forms.TextBox();
            this.Lmodelo_marca = new System.Windows.Forms.Label();
            this.Lfalla = new System.Windows.Forms.Label();
            this.Tmodelo = new System.Windows.Forms.TextBox();
            this.Bmodificar = new System.Windows.Forms.Button();
            this.Belminar = new System.Windows.Forms.Button();
            this.Bmostar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.BMostrarCantPendiente = new System.Windows.Forms.Button();
            this.NUDCantPendientes = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBfiltros_cliente.SuspendLayout();
            this.GBDispositivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantPendientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.dispositivoToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // dispositivoToolStripMenuItem
            // 
            this.dispositivoToolStripMenuItem.Name = "dispositivoToolStripMenuItem";
            this.dispositivoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.dispositivoToolStripMenuItem.Text = "Dispositivo";
            this.dispositivoToolStripMenuItem.Click += new System.EventHandler(this.dispositivoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // listViewPendientes
            // 
            this.listViewPendientes.HideSelection = false;
            this.listViewPendientes.Location = new System.Drawing.Point(23, 28);
            this.listViewPendientes.Name = "listViewPendientes";
            this.listViewPendientes.Size = new System.Drawing.Size(554, 380);
            this.listViewPendientes.TabIndex = 3;
            this.listViewPendientes.UseCompatibleStateImageBehavior = false;
            this.listViewPendientes.SelectedIndexChanged += new System.EventHandler(this.listViewPendientes_SelectedIndexChanged);
            this.listViewPendientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPendientes_MouseDoubleClick);
            // 
            // LVbuscador
            // 
            this.LVbuscador.HideSelection = false;
            this.LVbuscador.Location = new System.Drawing.Point(6, 126);
            this.LVbuscador.Name = "LVbuscador";
            this.LVbuscador.Size = new System.Drawing.Size(595, 282);
            this.LVbuscador.TabIndex = 4;
            this.LVbuscador.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar por:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RBdispositivo
            // 
            this.RBdispositivo.AutoSize = true;
            this.RBdispositivo.Checked = true;
            this.RBdispositivo.Location = new System.Drawing.Point(98, 19);
            this.RBdispositivo.Name = "RBdispositivo";
            this.RBdispositivo.Size = new System.Drawing.Size(76, 17);
            this.RBdispositivo.TabIndex = 6;
            this.RBdispositivo.TabStop = true;
            this.RBdispositivo.Text = "Dispositivo";
            this.RBdispositivo.UseVisualStyleBackColor = true;
            this.RBdispositivo.CheckedChanged += new System.EventHandler(this.RBdispositivo_CheckedChanged);
            // 
            // RBcliente
            // 
            this.RBcliente.AutoSize = true;
            this.RBcliente.Location = new System.Drawing.Point(198, 19);
            this.RBcliente.Name = "RBcliente";
            this.RBcliente.Size = new System.Drawing.Size(57, 17);
            this.RBcliente.TabIndex = 7;
            this.RBcliente.Text = "Cliente";
            this.RBcliente.UseVisualStyleBackColor = true;
            this.RBcliente.CheckedChanged += new System.EventHandler(this.RBcliente_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.GBfiltros_cliente);
            this.groupBox1.Controls.Add(this.GBDispositivo);
            this.groupBox1.Controls.Add(this.Bmodificar);
            this.groupBox1.Controls.Add(this.Belminar);
            this.groupBox1.Controls.Add(this.Bmostar);
            this.groupBox1.Controls.Add(this.LVbuscador);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RBcliente);
            this.groupBox1.Controls.Add(this.RBdispositivo);
            this.groupBox1.Location = new System.Drawing.Point(652, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 494);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador:";
            // 
            // GBfiltros_cliente
            // 
            this.GBfiltros_cliente.Controls.Add(this.CBfecha_alta);
            this.GBfiltros_cliente.Controls.Add(this.DTPfecha_alta);
            this.GBfiltros_cliente.Controls.Add(this.label3);
            this.GBfiltros_cliente.Controls.Add(this.label5);
            this.GBfiltros_cliente.Controls.Add(this.Tid_clientefiltro);
            this.GBfiltros_cliente.Controls.Add(this.Tnombre);
            this.GBfiltros_cliente.Controls.Add(this.label7);
            this.GBfiltros_cliente.Controls.Add(this.Tapellido);
            this.GBfiltros_cliente.Controls.Add(this.label9);
            this.GBfiltros_cliente.Controls.Add(this.Ttelefono);
            this.GBfiltros_cliente.Location = new System.Drawing.Point(6, 42);
            this.GBfiltros_cliente.Name = "GBfiltros_cliente";
            this.GBfiltros_cliente.Size = new System.Drawing.Size(595, 67);
            this.GBfiltros_cliente.TabIndex = 27;
            this.GBfiltros_cliente.TabStop = false;
            this.GBfiltros_cliente.Text = "Filtros:";
            // 
            // CBfecha_alta
            // 
            this.CBfecha_alta.AutoSize = true;
            this.CBfecha_alta.Location = new System.Drawing.Point(394, 13);
            this.CBfecha_alta.Name = "CBfecha_alta";
            this.CBfecha_alta.Size = new System.Drawing.Size(92, 17);
            this.CBfecha_alta.TabIndex = 27;
            this.CBfecha_alta.Text = "Fecha de Alta";
            this.CBfecha_alta.UseVisualStyleBackColor = true;
            this.CBfecha_alta.CheckedChanged += new System.EventHandler(this.CBfecha_alta_CheckedChanged);
            // 
            // DTPfecha_alta
            // 
            this.DTPfecha_alta.Location = new System.Drawing.Point(394, 36);
            this.DTPfecha_alta.Name = "DTPfecha_alta";
            this.DTPfecha_alta.Size = new System.Drawing.Size(148, 20);
            this.DTPfecha_alta.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID:";
            // 
            // Tid_clientefiltro
            // 
            this.Tid_clientefiltro.Location = new System.Drawing.Point(46, 36);
            this.Tid_clientefiltro.Name = "Tid_clientefiltro";
            this.Tid_clientefiltro.Size = new System.Drawing.Size(22, 20);
            this.Tid_clientefiltro.TabIndex = 12;
            // 
            // Tnombre
            // 
            this.Tnombre.Location = new System.Drawing.Point(121, 36);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.Size = new System.Drawing.Size(39, 20);
            this.Tnombre.TabIndex = 14;
            this.Tnombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apellido:";
            // 
            // Tapellido
            // 
            this.Tapellido.Location = new System.Drawing.Point(226, 36);
            this.Tapellido.Name = "Tapellido";
            this.Tapellido.Size = new System.Drawing.Size(39, 20);
            this.Tapellido.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telefono:";
            // 
            // Ttelefono
            // 
            this.Ttelefono.Location = new System.Drawing.Point(329, 36);
            this.Ttelefono.Name = "Ttelefono";
            this.Ttelefono.Size = new System.Drawing.Size(39, 20);
            this.Ttelefono.TabIndex = 18;
            // 
            // GBDispositivo
            // 
            this.GBDispositivo.Controls.Add(this.DTPfecha_ingreso_Dispositivo);
            this.GBDispositivo.Controls.Add(this.Lid_cliente);
            this.GBDispositivo.Controls.Add(this.Lfechaingreso);
            this.GBDispositivo.Controls.Add(this.Lid);
            this.GBDispositivo.Controls.Add(this.Tcomentario);
            this.GBDispositivo.Controls.Add(this.Tid_Dispositivo);
            this.GBDispositivo.Controls.Add(this.Lcomentario);
            this.GBDispositivo.Controls.Add(this.Tid_cliente);
            this.GBDispositivo.Controls.Add(this.CBestado);
            this.GBDispositivo.Controls.Add(this.Ltipo);
            this.GBDispositivo.Controls.Add(this.Lestado);
            this.GBDispositivo.Controls.Add(this.Ttipo);
            this.GBDispositivo.Controls.Add(this.Tfalla);
            this.GBDispositivo.Controls.Add(this.Lmodelo_marca);
            this.GBDispositivo.Controls.Add(this.Lfalla);
            this.GBDispositivo.Controls.Add(this.Tmodelo);
            this.GBDispositivo.Location = new System.Drawing.Point(6, 42);
            this.GBDispositivo.Name = "GBDispositivo";
            this.GBDispositivo.Size = new System.Drawing.Size(595, 67);
            this.GBDispositivo.TabIndex = 10;
            this.GBDispositivo.TabStop = false;
            this.GBDispositivo.Text = "Filtros:";
            // 
            // DTPfecha_ingreso_Dispositivo
            // 
            this.DTPfecha_ingreso_Dispositivo.Location = new System.Drawing.Point(432, 36);
            this.DTPfecha_ingreso_Dispositivo.Name = "DTPfecha_ingreso_Dispositivo";
            this.DTPfecha_ingreso_Dispositivo.Size = new System.Drawing.Size(148, 20);
            this.DTPfecha_ingreso_Dispositivo.TabIndex = 26;
            // 
            // Lid_cliente
            // 
            this.Lid_cliente.AutoSize = true;
            this.Lid_cliente.Location = new System.Drawing.Point(74, 16);
            this.Lid_cliente.Name = "Lid_cliente";
            this.Lid_cliente.Size = new System.Drawing.Size(59, 13);
            this.Lid_cliente.TabIndex = 13;
            this.Lid_cliente.Text = "ID_Cliente:";
            // 
            // Lfechaingreso
            // 
            this.Lfechaingreso.AutoSize = true;
            this.Lfechaingreso.Location = new System.Drawing.Point(429, 16);
            this.Lfechaingreso.Name = "Lfechaingreso";
            this.Lfechaingreso.Size = new System.Drawing.Size(92, 13);
            this.Lfechaingreso.TabIndex = 25;
            this.Lfechaingreso.Text = "Fecha de ingreso:";
            // 
            // Lid
            // 
            this.Lid.AutoSize = true;
            this.Lid.Location = new System.Drawing.Point(19, 16);
            this.Lid.Name = "Lid";
            this.Lid.Size = new System.Drawing.Size(21, 13);
            this.Lid.TabIndex = 11;
            this.Lid.Text = "ID:";
            // 
            // Tcomentario
            // 
            this.Tcomentario.Location = new System.Drawing.Point(357, 39);
            this.Tcomentario.Name = "Tcomentario";
            this.Tcomentario.Size = new System.Drawing.Size(59, 20);
            this.Tcomentario.TabIndex = 24;
            // 
            // Tid_Dispositivo
            // 
            this.Tid_Dispositivo.Location = new System.Drawing.Point(46, 13);
            this.Tid_Dispositivo.Name = "Tid_Dispositivo";
            this.Tid_Dispositivo.Size = new System.Drawing.Size(22, 20);
            this.Tid_Dispositivo.TabIndex = 12;
            // 
            // Lcomentario
            // 
            this.Lcomentario.AutoSize = true;
            this.Lcomentario.Location = new System.Drawing.Point(296, 46);
            this.Lcomentario.Name = "Lcomentario";
            this.Lcomentario.Size = new System.Drawing.Size(63, 13);
            this.Lcomentario.TabIndex = 23;
            this.Lcomentario.Text = "Comentario:";
            // 
            // Tid_cliente
            // 
            this.Tid_cliente.Location = new System.Drawing.Point(136, 13);
            this.Tid_cliente.Name = "Tid_cliente";
            this.Tid_cliente.Size = new System.Drawing.Size(39, 20);
            this.Tid_cliente.TabIndex = 14;
            this.Tid_cliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CBestado
            // 
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Items.AddRange(new object[] {
            "A reparar",
            "Reparado"});
            this.CBestado.Location = new System.Drawing.Point(202, 41);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(79, 21);
            this.CBestado.TabIndex = 22;
            // 
            // Ltipo
            // 
            this.Ltipo.AutoSize = true;
            this.Ltipo.Location = new System.Drawing.Point(181, 16);
            this.Ltipo.Name = "Ltipo";
            this.Ltipo.Size = new System.Drawing.Size(31, 13);
            this.Ltipo.TabIndex = 15;
            this.Ltipo.Text = "Tipo:";
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.Location = new System.Drawing.Point(153, 46);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(43, 13);
            this.Lestado.TabIndex = 21;
            this.Lestado.Text = "Estado:";
            // 
            // Ttipo
            // 
            this.Ttipo.Location = new System.Drawing.Point(217, 13);
            this.Ttipo.Name = "Ttipo";
            this.Ttipo.Size = new System.Drawing.Size(39, 20);
            this.Ttipo.TabIndex = 16;
            // 
            // Tfalla
            // 
            this.Tfalla.Location = new System.Drawing.Point(57, 39);
            this.Tfalla.Name = "Tfalla";
            this.Tfalla.Size = new System.Drawing.Size(76, 20);
            this.Tfalla.TabIndex = 20;
            // 
            // Lmodelo_marca
            // 
            this.Lmodelo_marca.AutoSize = true;
            this.Lmodelo_marca.Location = new System.Drawing.Point(271, 16);
            this.Lmodelo_marca.Name = "Lmodelo_marca";
            this.Lmodelo_marca.Size = new System.Drawing.Size(80, 13);
            this.Lmodelo_marca.TabIndex = 17;
            this.Lmodelo_marca.Text = "Modelo/Marca:";
            // 
            // Lfalla
            // 
            this.Lfalla.AutoSize = true;
            this.Lfalla.Location = new System.Drawing.Point(19, 46);
            this.Lfalla.Name = "Lfalla";
            this.Lfalla.Size = new System.Drawing.Size(32, 13);
            this.Lfalla.TabIndex = 19;
            this.Lfalla.Text = "Falla:";
            // 
            // Tmodelo
            // 
            this.Tmodelo.Location = new System.Drawing.Point(357, 13);
            this.Tmodelo.Name = "Tmodelo";
            this.Tmodelo.Size = new System.Drawing.Size(39, 20);
            this.Tmodelo.TabIndex = 18;
            // 
            // Bmodificar
            // 
            this.Bmodificar.Location = new System.Drawing.Point(526, 418);
            this.Bmodificar.Name = "Bmodificar";
            this.Bmodificar.Size = new System.Drawing.Size(75, 23);
            this.Bmodificar.TabIndex = 10;
            this.Bmodificar.Text = "Modificar";
            this.Bmodificar.UseVisualStyleBackColor = true;
            // 
            // Belminar
            // 
            this.Belminar.Location = new System.Drawing.Point(445, 418);
            this.Belminar.Name = "Belminar";
            this.Belminar.Size = new System.Drawing.Size(75, 23);
            this.Belminar.TabIndex = 9;
            this.Belminar.Text = "Eliminar";
            this.Belminar.UseVisualStyleBackColor = true;
            // 
            // Bmostar
            // 
            this.Bmostar.Location = new System.Drawing.Point(359, 418);
            this.Bmostar.Name = "Bmostar";
            this.Bmostar.Size = new System.Drawing.Size(75, 23);
            this.Bmostar.TabIndex = 9;
            this.Bmostar.Text = "Mostrar";
            this.Bmostar.UseVisualStyleBackColor = true;
            this.Bmostar.Click += new System.EventHandler(this.Bmostar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "¿Cuantos deseas ver?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BMostrarCantPendiente
            // 
            this.BMostrarCantPendiente.Location = new System.Drawing.Point(129, 441);
            this.BMostrarCantPendiente.Name = "BMostrarCantPendiente";
            this.BMostrarCantPendiente.Size = new System.Drawing.Size(75, 23);
            this.BMostrarCantPendiente.TabIndex = 28;
            this.BMostrarCantPendiente.Text = "Mostrar";
            this.BMostrarCantPendiente.UseVisualStyleBackColor = true;
            this.BMostrarCantPendiente.Click += new System.EventHandler(this.BMostrarCantPendiente_Click);
            // 
            // NUDCantPendientes
            // 
            this.NUDCantPendientes.Location = new System.Drawing.Point(33, 444);
            this.NUDCantPendientes.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDCantPendientes.Name = "NUDCantPendientes";
            this.NUDCantPendientes.Size = new System.Drawing.Size(76, 20);
            this.NUDCantPendientes.TabIndex = 29;
            this.NUDCantPendientes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.listViewPendientes);
            this.groupBox2.Controls.Add(this.NUDCantPendientes);
            this.groupBox2.Controls.Add(this.BMostrarCantPendiente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(31, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 494);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reparaciones Pendiente:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1299, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBfiltros_cliente.ResumeLayout(false);
            this.GBfiltros_cliente.PerformLayout();
            this.GBDispositivo.ResumeLayout(false);
            this.GBDispositivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantPendientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispositivoToolStripMenuItem;
        private System.Windows.Forms.ListView listViewPendientes;
        private System.Windows.Forms.ListView LVbuscador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBdispositivo;
        private System.Windows.Forms.RadioButton RBcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Bmostar;
        private System.Windows.Forms.Button Bmodificar;
        private System.Windows.Forms.Button Belminar;
        private System.Windows.Forms.TextBox Tid_cliente;
        private System.Windows.Forms.Label Lid_cliente;
        private System.Windows.Forms.TextBox Tid_Dispositivo;
        private System.Windows.Forms.Label Lid;
        private System.Windows.Forms.TextBox Tmodelo;
        private System.Windows.Forms.Label Lmodelo_marca;
        private System.Windows.Forms.TextBox Ttipo;
        private System.Windows.Forms.Label Ltipo;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.TextBox Tfalla;
        private System.Windows.Forms.Label Lfalla;
        private System.Windows.Forms.DateTimePicker DTPfecha_ingreso_Dispositivo;
        private System.Windows.Forms.Label Lfechaingreso;
        private System.Windows.Forms.TextBox Tcomentario;
        private System.Windows.Forms.Label Lcomentario;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox GBDispositivo;
        private System.Windows.Forms.GroupBox GBfiltros_cliente;
        private System.Windows.Forms.DateTimePicker DTPfecha_alta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tid_clientefiltro;
        private System.Windows.Forms.TextBox Tnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tapellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Ttelefono;
        private System.Windows.Forms.CheckBox CBfecha_alta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BMostrarCantPendiente;
        private System.Windows.Forms.NumericUpDown NUDCantPendientes;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

