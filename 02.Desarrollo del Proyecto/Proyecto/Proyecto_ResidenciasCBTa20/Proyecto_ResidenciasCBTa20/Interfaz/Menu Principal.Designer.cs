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
            this.BtnAgregarEq.Location = new System.Drawing.Point(45, 60);
            this.BtnAgregarEq.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAgregarEq.Name = "BtnAgregarEq";
            this.BtnAgregarEq.Size = new System.Drawing.Size(151, 34);
            this.BtnAgregarEq.TabIndex = 0;
            this.BtnAgregarEq.Text = "Agregar Equipo";
            this.BtnAgregarEq.UseVisualStyleBackColor = true;
            this.BtnAgregarEq.Click += new System.EventHandler(this.BtnAgregarEq_Click);
            // 
            // BtnConsularEquipo
            // 
            this.BtnConsularEquipo.Location = new System.Drawing.Point(45, 121);
            this.BtnConsularEquipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnConsularEquipo.Name = "BtnConsularEquipo";
            this.BtnConsularEquipo.Size = new System.Drawing.Size(151, 43);
            this.BtnConsularEquipo.TabIndex = 1;
            this.BtnConsularEquipo.Text = "Consultar Equipo";
            this.BtnConsularEquipo.UseVisualStyleBackColor = true;
            this.BtnConsularEquipo.Click += new System.EventHandler(this.BtnConsularEquipo_Click);
            // 
            // BtnAgregarComp
            // 
            this.BtnAgregarComp.Location = new System.Drawing.Point(261, 60);
            this.BtnAgregarComp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAgregarComp.Name = "BtnAgregarComp";
            this.BtnAgregarComp.Size = new System.Drawing.Size(174, 34);
            this.BtnAgregarComp.TabIndex = 2;
            this.BtnAgregarComp.Text = "Agregar Componente";
            this.BtnAgregarComp.UseVisualStyleBackColor = true;
            this.BtnAgregarComp.Click += new System.EventHandler(this.BtnAgregarComp_Click);
            // 
            // BtnConsultarComp
            // 
            this.BtnConsultarComp.Location = new System.Drawing.Point(261, 121);
            this.BtnConsultarComp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnConsultarComp.Name = "BtnConsultarComp";
            this.BtnConsultarComp.Size = new System.Drawing.Size(174, 43);
            this.BtnConsultarComp.TabIndex = 3;
            this.BtnConsultarComp.Text = "Consultar  Componente";
            this.BtnConsultarComp.UseVisualStyleBackColor = true;
            this.BtnConsultarComp.Click += new System.EventHandler(this.BtnConsultarComp_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.Location = new System.Drawing.Point(154, 189);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(151, 40);
            this.BtnInventario.TabIndex = 4;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(685, 249);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnConsultarComp);
            this.Controls.Add(this.BtnAgregarComp);
            this.Controls.Add(this.BtnConsularEquipo);
            this.Controls.Add(this.BtnAgregarEq);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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