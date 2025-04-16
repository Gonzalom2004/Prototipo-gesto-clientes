namespace Gestor_De_Clientes
{
    partial class FBuscadorCliente
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
            this.LBbuscador = new System.Windows.Forms.ListBox();
            this.Bseleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBbuscador
            // 
            this.LBbuscador.FormattingEnabled = true;
            this.LBbuscador.Location = new System.Drawing.Point(31, 25);
            this.LBbuscador.Name = "LBbuscador";
            this.LBbuscador.Size = new System.Drawing.Size(455, 199);
            this.LBbuscador.TabIndex = 0;
            // 
            // Bseleccionar
            // 
            this.Bseleccionar.Location = new System.Drawing.Point(361, 262);
            this.Bseleccionar.Name = "Bseleccionar";
            this.Bseleccionar.Size = new System.Drawing.Size(75, 23);
            this.Bseleccionar.TabIndex = 1;
            this.Bseleccionar.Text = "Seleccionar";
            this.Bseleccionar.UseVisualStyleBackColor = true;
            this.Bseleccionar.Click += new System.EventHandler(this.Bseleccionar_Click);
            // 
            // FBuscadorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 317);
            this.Controls.Add(this.Bseleccionar);
            this.Controls.Add(this.LBbuscador);
            this.Name = "FBuscadorCliente";
            this.Text = "FBuscadorCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBuscadorCliente_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBuscadorCliente_FormClosed);
            this.Load += new System.EventHandler(this.FBuscadorCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBbuscador;
        private System.Windows.Forms.Button Bseleccionar;
    }
}