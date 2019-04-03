namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    partial class Componentes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRepCostos = new System.Windows.Forms.Button();
            this.BtnAgregarComp = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Componente,
            this.Nombre,
            this.Cantidad,
            this.Costo,
            this.Estado,
            this.Fecha_Ingreso});
            this.dataGridView1.Location = new System.Drawing.Point(14, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id_Componente
            // 
            this.Id_Componente.HeaderText = "Id";
            this.Id_Componente.Name = "Id_Componente";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Fecha_Ingreso
            // 
            this.Fecha_Ingreso.HeaderText = "Fecha de Ingreso";
            this.Fecha_Ingreso.Name = "Fecha_Ingreso";
            // 
            // BtnRepCostos
            // 
            this.BtnRepCostos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRepCostos.Location = new System.Drawing.Point(32, 273);
            this.BtnRepCostos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnRepCostos.Name = "BtnRepCostos";
            this.BtnRepCostos.Size = new System.Drawing.Size(190, 35);
            this.BtnRepCostos.TabIndex = 1;
            this.BtnRepCostos.Text = "Generar Reporte de Costos";
            this.BtnRepCostos.UseVisualStyleBackColor = true;
            this.BtnRepCostos.Click += new System.EventHandler(this.BtnRepCostos_Click);
            // 
            // BtnAgregarComp
            // 
            this.BtnAgregarComp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarComp.Location = new System.Drawing.Point(284, 273);
            this.BtnAgregarComp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAgregarComp.Name = "BtnAgregarComp";
            this.BtnAgregarComp.Size = new System.Drawing.Size(153, 35);
            this.BtnAgregarComp.TabIndex = 2;
            this.BtnAgregarComp.Text = "Agregar Componentes";
            this.BtnAgregarComp.UseVisualStyleBackColor = true;
            this.BtnAgregarComp.Click += new System.EventHandler(this.BtnAgregarComp_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(551, 273);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(87, 35);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(934, 315);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregarComp);
            this.Controls.Add(this.BtnRepCostos);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Componentes";
            this.Text = "Componentes";
            this.Load += new System.EventHandler(this.Componentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnRepCostos;
        private System.Windows.Forms.Button BtnAgregarComp;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Componente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ingreso;
    }
}