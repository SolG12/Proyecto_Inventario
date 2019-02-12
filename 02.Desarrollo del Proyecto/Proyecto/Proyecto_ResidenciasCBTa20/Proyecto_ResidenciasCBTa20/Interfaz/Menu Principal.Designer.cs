namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    partial class Menu_Principal
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
            this.BtnAgregarEq = new System.Windows.Forms.Button();
            this.BtnConsularEquipo = new System.Windows.Forms.Button();
            this.BtnAgregarComp = new System.Windows.Forms.Button();
            this.BtnConsultarComp = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAgregarEq
            // 
            this.BtnAgregarEq.Location = new System.Drawing.Point(102, 53);
            this.BtnAgregarEq.Name = "BtnAgregarEq";
            this.BtnAgregarEq.Size = new System.Drawing.Size(113, 22);
            this.BtnAgregarEq.TabIndex = 0;
            this.BtnAgregarEq.Text = "Agregar Equipo";
            this.BtnAgregarEq.UseVisualStyleBackColor = true;
            // 
            // BtnConsularEquipo
            // 
            this.BtnConsularEquipo.Location = new System.Drawing.Point(102, 99);
            this.BtnConsularEquipo.Name = "BtnConsularEquipo";
            this.BtnConsularEquipo.Size = new System.Drawing.Size(113, 28);
            this.BtnConsularEquipo.TabIndex = 1;
            this.BtnConsularEquipo.Text = "Consultar Equipo";
            this.BtnConsularEquipo.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarComp
            // 
            this.BtnAgregarComp.Location = new System.Drawing.Point(102, 149);
            this.BtnAgregarComp.Name = "BtnAgregarComp";
            this.BtnAgregarComp.Size = new System.Drawing.Size(113, 36);
            this.BtnAgregarComp.TabIndex = 2;
            this.BtnAgregarComp.Text = "Agregar Componente";
            this.BtnAgregarComp.UseVisualStyleBackColor = true;
            // 
            // BtnConsultarComp
            // 
            this.BtnConsultarComp.Location = new System.Drawing.Point(102, 201);
            this.BtnConsultarComp.Name = "BtnConsultarComp";
            this.BtnConsultarComp.Size = new System.Drawing.Size(113, 36);
            this.BtnConsultarComp.TabIndex = 3;
            this.BtnConsultarComp.Text = "Consultar  Componente";
            this.BtnConsultarComp.UseVisualStyleBackColor = true;
            // 
            // BtnInventario
            // 
            this.BtnInventario.Location = new System.Drawing.Point(102, 255);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(113, 26);
            this.BtnInventario.TabIndex = 4;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 348);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnConsultarComp);
            this.Controls.Add(this.BtnAgregarComp);
            this.Controls.Add(this.BtnConsularEquipo);
            this.Controls.Add(this.BtnAgregarEq);
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarEq;
        private System.Windows.Forms.Button BtnConsularEquipo;
        private System.Windows.Forms.Button BtnAgregarComp;
        private System.Windows.Forms.Button BtnConsultarComp;
        private System.Windows.Forms.Button BtnInventario;
    }
}