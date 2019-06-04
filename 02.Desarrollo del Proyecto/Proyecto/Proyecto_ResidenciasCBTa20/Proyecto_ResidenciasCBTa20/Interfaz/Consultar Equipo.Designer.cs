namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    partial class Consultar_Equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Equipo));
            this.LblArea = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.BtnBuscarEquipo = new System.Windows.Forms.Button();
            this.DgvEquipos = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRepMantenimiento = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.BtnAEquipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Location = new System.Drawing.Point(14, 21);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(34, 20);
            this.LblArea.TabIndex = 2;
            this.LblArea.Text = "Área";
            // 
            // TxtArea
            // 
            this.TxtArea.Location = new System.Drawing.Point(75, 21);
            this.TxtArea.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(116, 25);
            this.TxtArea.TabIndex = 3;
            // 
            // BtnBuscarEquipo
            // 
            this.BtnBuscarEquipo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarEquipo.Image")));
            this.BtnBuscarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarEquipo.Location = new System.Drawing.Point(271, 14);
            this.BtnBuscarEquipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnBuscarEquipo.Name = "BtnBuscarEquipo";
            this.BtnBuscarEquipo.Size = new System.Drawing.Size(98, 35);
            this.BtnBuscarEquipo.TabIndex = 4;
            this.BtnBuscarEquipo.Text = "Buscar";
            this.BtnBuscarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarEquipo.UseVisualStyleBackColor = true;
            this.BtnBuscarEquipo.Click += new System.EventHandler(this.BtnBuscarEquipo_Click);
            // 
            // DgvEquipos
            // 
            this.DgvEquipos.AllowUserToAddRows = false;
            this.DgvEquipos.AllowUserToDeleteRows = false;
            this.DgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEquipos.Location = new System.Drawing.Point(16, 56);
            this.DgvEquipos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DgvEquipos.MultiSelect = false;
            this.DgvEquipos.Name = "DgvEquipos";
            this.DgvEquipos.ReadOnly = true;
            this.DgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEquipos.Size = new System.Drawing.Size(843, 282);
            this.DgvEquipos.TabIndex = 5;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.Location = new System.Drawing.Point(200, 373);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(92, 35);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(317, 373);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 35);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Menú";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRepMantenimiento
            // 
            this.BtnRepMantenimiento.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRepMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("BtnRepMantenimiento.Image")));
            this.BtnRepMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRepMantenimiento.Location = new System.Drawing.Point(443, 373);
            this.BtnRepMantenimiento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnRepMantenimiento.Name = "BtnRepMantenimiento";
            this.BtnRepMantenimiento.Size = new System.Drawing.Size(258, 35);
            this.BtnRepMantenimiento.TabIndex = 9;
            this.BtnRepMantenimiento.Text = "Generar Reporte de Mantenimiento";
            this.BtnRepMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRepMantenimiento.UseVisualStyleBackColor = true;
            this.BtnRepMantenimiento.Click += new System.EventHandler(this.BtnRepMantenimiento_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventario.Image")));
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInventario.Location = new System.Drawing.Point(724, 373);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(171, 35);
            this.BtnInventario.TabIndex = 10;
            this.BtnInventario.Text = "Consultar Inventario";
            this.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(887, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 219);
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
            // BtnAEquipo
            // 
            this.BtnAEquipo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAEquipo.Image = ((System.Drawing.Image)(resources.GetObject("BtnAEquipo.Image")));
            this.BtnAEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAEquipo.Location = new System.Drawing.Point(18, 373);
            this.BtnAEquipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAEquipo.Name = "BtnAEquipo";
            this.BtnAEquipo.Size = new System.Drawing.Size(154, 35);
            this.BtnAEquipo.TabIndex = 22;
            this.BtnAEquipo.Text = "Actualizar Equipo";
            this.BtnAEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAEquipo.UseVisualStyleBackColor = true;
           
            // 
            // Consultar_Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1068, 437);
            this.Controls.Add(this.BtnAEquipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnRepMantenimiento);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DgvEquipos);
            this.Controls.Add(this.BtnBuscarEquipo);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.LblArea);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Consultar_Equipo";
            this.Text = "Consultar Equipo";
            this.Activated += new System.EventHandler(this.Consultar_Equipo_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Button BtnBuscarEquipo;
        private System.Windows.Forms.DataGridView DgvEquipos;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRepMantenimiento;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button button1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button BtnAEquipo;
    }
}