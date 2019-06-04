namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.DgvInventario = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnConsultarComp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnRepCostos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvInventario
            // 
            this.DgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.Estado,
            this.Fecha,
            this.Cantidad});
            this.DgvInventario.Location = new System.Drawing.Point(12, 114);
            this.DgvInventario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DgvInventario.Name = "DgvInventario";
            this.DgvInventario.Size = new System.Drawing.Size(543, 208);
            this.DgvInventario.TabIndex = 0;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "No.Parte";
            this.Numero.Name = "Numero";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha_Ingreso";
            this.Fecha.Name = "Fecha";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.Location = new System.Drawing.Point(12, 349);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(100, 35);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMenu.Location = new System.Drawing.Point(141, 349);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(94, 35);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnConsultarComp
            // 
            this.BtnConsultarComp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarComp.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultarComp.Image")));
            this.BtnConsultarComp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultarComp.Location = new System.Drawing.Point(254, 349);
            this.BtnConsultarComp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnConsultarComp.Name = "BtnConsultarComp";
            this.BtnConsultarComp.Size = new System.Drawing.Size(190, 35);
            this.BtnConsultarComp.TabIndex = 3;
            this.BtnConsultarComp.Text = "Consultar Componentes";
            this.BtnConsultarComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarComp.UseVisualStyleBackColor = true;
            this.BtnConsultarComp.Click += new System.EventHandler(this.BtnConsultarComp_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(579, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 168);
            this.button1.TabIndex = 4;
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
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(171, 37);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(222, 25);
            this.TxtNombre.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre del Componente";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(468, 34);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(87, 33);
            this.BtnBuscar.TabIndex = 24;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnRepCostos
            // 
            this.BtnRepCostos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRepCostos.Image = ((System.Drawing.Image)(resources.GetObject("BtnRepCostos.Image")));
            this.BtnRepCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRepCostos.Location = new System.Drawing.Point(468, 349);
            this.BtnRepCostos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnRepCostos.Name = "BtnRepCostos";
            this.BtnRepCostos.Size = new System.Drawing.Size(206, 35);
            this.BtnRepCostos.TabIndex = 27;
            this.BtnRepCostos.Text = "Generar Reporte de Costos";
            this.BtnRepCostos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRepCostos.UseVisualStyleBackColor = true;
            this.BtnRepCostos.Click += new System.EventHandler(this.BtnRepCostos_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(721, 395);
            this.Controls.Add(this.BtnRepCostos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnConsultarComp);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.DgvInventario);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvInventario;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnConsultarComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button button1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnRepCostos;
    }
}