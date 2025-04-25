namespace Gestor_De_Clientes
{
    partial class FBuscar
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
            this.button1 = new System.Windows.Forms.Button();
            this.ListaBuscar = new System.Windows.Forms.ListBox();
            this.BEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tnombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaBuscar
            // 
            this.ListaBuscar.FormattingEnabled = true;
            this.ListaBuscar.Location = new System.Drawing.Point(35, 38);
            this.ListaBuscar.Name = "ListaBuscar";
            this.ListaBuscar.Size = new System.Drawing.Size(720, 342);
            this.ListaBuscar.TabIndex = 1;
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(252, 386);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 23);
            this.BEliminar.TabIndex = 2;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtros:";
            // 
            // CBestado
            // 
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Items.AddRange(new object[] {
            "A reparar",
            "Reparado"});
            this.CBestado.Location = new System.Drawing.Point(105, 14);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(121, 21);
            this.CBestado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // Tnombre
            // 
            this.Tnombre.Location = new System.Drawing.Point(300, 14);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.Size = new System.Drawing.Size(100, 20);
            this.Tnombre.TabIndex = 7;
            // 
            // FBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBestado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.ListaBuscar);
            this.Controls.Add(this.button1);
            this.Name = "FBuscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListaBuscar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBestado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tnombre;
    }
}