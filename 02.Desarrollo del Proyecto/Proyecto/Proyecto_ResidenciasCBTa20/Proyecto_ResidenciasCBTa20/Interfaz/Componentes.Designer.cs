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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Componentes));
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
            this.button1 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 208);
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
            this.BtnRepCostos.Image = ((System.Drawing.Image)(resources.GetObject("BtnRepCostos.Image")));
            this.BtnRepCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRepCostos.Location = new System.Drawing.Point(31, 318);
            this.BtnRepCostos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnRepCostos.Name = "BtnRepCostos";
            this.BtnRepCostos.Size = new System.Drawing.Size(206, 35);
            this.BtnRepCostos.TabIndex = 1;
            this.BtnRepCostos.Text = "Generar Reporte de Costos";
            this.BtnRepCostos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRepCostos.UseVisualStyleBackColor = true;
            this.BtnRepCostos.Click += new System.EventHandler(this.BtnRepCostos_Click);
            // 
            // BtnAgregarComp
            // 
            this.BtnAgregarComp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarComp.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarComp.Image")));
            this.BtnAgregarComp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarComp.Location = new System.Drawing.Point(283, 318);
            this.BtnAgregarComp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAgregarComp.Name = "BtnAgregarComp";
            this.BtnAgregarComp.Size = new System.Drawing.Size(179, 35);
            this.BtnAgregarComp.TabIndex = 2;
            this.BtnAgregarComp.Text = "Agregar Componentes";
            this.BtnAgregarComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarComp.UseVisualStyleBackColor = true;
            this.BtnAgregarComp.Click += new System.EventHandler(this.BtnAgregarComp_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.Location = new System.Drawing.Point(524, 318);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(81, 35);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(692, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 214);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\Luis\\Documents\\GitHub\\Proyecto_Inventario\\02.Desarrollo del Proyecto\\Pro" +
    "yecto\\Proyecto_ResidenciasCBTa20\\Proyecto_ResidenciasCBTa20\\SKIN NET 2010 WIN 7\\" +
    "SkinVS.NET\\Emerald\\EmeraldColor2.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(482, 30);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(77, 25);
            this.BtnBuscar.TabIndex = 21;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre del Componente";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(182, 30);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(218, 25);
            this.TxtNombre.TabIndex = 23;
            // 
            // Componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 367);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.button1);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}