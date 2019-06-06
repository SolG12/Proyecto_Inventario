namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    partial class AgregarInventario
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblComponente = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(27, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar al Inventario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblComponente
            // 
            this.lblComponente.AutoSize = true;
            this.lblComponente.Location = new System.Drawing.Point(71, 34);
            this.lblComponente.Name = "lblComponente";
            this.lblComponente.Size = new System.Drawing.Size(35, 13);
            this.lblComponente.TabIndex = 1;
            this.lblComponente.Text = "label1";
            this.lblComponente.Click += new System.EventHandler(this.lblComponente_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(38, 66);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // AgregarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 158);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblComponente);
            this.Controls.Add(this.btnAgregar);
            this.Name = "AgregarInventario";
            this.Text = "AgregarInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblComponente;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.TextBox txtCantidad;
    }
}