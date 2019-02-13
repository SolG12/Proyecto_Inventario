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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblArea = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.BtnBuscarEquipo = new System.Windows.Forms.Button();
            this.DgvEquipos = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Área = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRepMantenimiento = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(23, 32);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(88, 13);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo de Barras";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(129, 29);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(153, 20);
            this.TxtCodigo.TabIndex = 1;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Location = new System.Drawing.Point(327, 32);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(29, 13);
            this.LblArea.TabIndex = 2;
            this.LblArea.Text = "Area";
            // 
            // TxtArea
            // 
            this.TxtArea.Location = new System.Drawing.Point(379, 32);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(100, 20);
            this.TxtArea.TabIndex = 3;
            // 
            // BtnBuscarEquipo
            // 
            this.BtnBuscarEquipo.Location = new System.Drawing.Point(545, 32);
            this.BtnBuscarEquipo.Name = "BtnBuscarEquipo";
            this.BtnBuscarEquipo.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarEquipo.TabIndex = 4;
            this.BtnBuscarEquipo.Text = "Buscar";
            this.BtnBuscarEquipo.UseVisualStyleBackColor = true;
            // 
            // DgvEquipos
            // 
            this.DgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Marca,
            this.Modelo,
            this.Funcionalidad,
            this.Encargado,
            this.Área,
            this.Estado});
            this.DgvEquipos.Location = new System.Drawing.Point(12, 61);
            this.DgvEquipos.Name = "DgvEquipos";
            this.DgvEquipos.Size = new System.Drawing.Size(744, 183);
            this.DgvEquipos.TabIndex = 5;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "No.";
            this.Numero.Name = "Numero";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            // 
            // Encargado
            // 
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            // 
            // Área
            // 
            this.Área.HeaderText = "Área";
            this.Área.Name = "Área";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(61, 286);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(207, 286);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(369, 286);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnRepMantenimiento
            // 
            this.BtnRepMantenimiento.Location = new System.Drawing.Point(510, 278);
            this.BtnRepMantenimiento.Name = "BtnRepMantenimiento";
            this.BtnRepMantenimiento.Size = new System.Drawing.Size(153, 39);
            this.BtnRepMantenimiento.TabIndex = 9;
            this.BtnRepMantenimiento.Text = "Generar Reporte de Mantenimiento";
            this.BtnRepMantenimiento.UseVisualStyleBackColor = true;
            // 
            // BtnInventario
            // 
            this.BtnInventario.Location = new System.Drawing.Point(762, 138);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(92, 38);
            this.BtnInventario.TabIndex = 10;
            this.BtnInventario.Text = "Consultar Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            // 
            // Consultar_Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 337);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnRepMantenimiento);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.DgvEquipos);
            this.Controls.Add(this.BtnBuscarEquipo);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Name = "Consultar_Equipo";
            this.Text = "Consultar Equipo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Button BtnBuscarEquipo;
        private System.Windows.Forms.DataGridView DgvEquipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Área;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRepMantenimiento;
        private System.Windows.Forms.Button BtnInventario;
    }
}