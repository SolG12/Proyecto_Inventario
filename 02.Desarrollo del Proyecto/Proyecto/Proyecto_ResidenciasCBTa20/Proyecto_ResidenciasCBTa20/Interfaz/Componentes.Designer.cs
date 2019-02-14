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
            this.BtnGenerarRepCostos = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(57, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 159);
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
            // BtnGenerarRepCostos
            // 
            this.BtnGenerarRepCostos.Location = new System.Drawing.Point(57, 223);
            this.BtnGenerarRepCostos.Name = "BtnGenerarRepCostos";
            this.BtnGenerarRepCostos.Size = new System.Drawing.Size(112, 36);
            this.BtnGenerarRepCostos.TabIndex = 1;
            this.BtnGenerarRepCostos.Text = "Generar Reporte de Costos";
            this.BtnGenerarRepCostos.UseVisualStyleBackColor = true;
            this.BtnGenerarRepCostos.Click += new System.EventHandler(this.BtnGenerarRepCostos_Click);
            // 
            // BtnAgregarComp
            // 
            this.BtnAgregarComp.Location = new System.Drawing.Point(274, 223);
            this.BtnAgregarComp.Name = "BtnAgregarComp";
            this.BtnAgregarComp.Size = new System.Drawing.Size(95, 36);
            this.BtnAgregarComp.TabIndex = 2;
            this.BtnAgregarComp.Text = "Agregar Componentes";
            this.BtnAgregarComp.UseVisualStyleBackColor = true;
            this.BtnAgregarComp.Click += new System.EventHandler(this.BtnAgregarComp_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(502, 230);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 304);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregarComp);
            this.Controls.Add(this.BtnGenerarRepCostos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Componentes";
            this.Text = "Componentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGenerarRepCostos;
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