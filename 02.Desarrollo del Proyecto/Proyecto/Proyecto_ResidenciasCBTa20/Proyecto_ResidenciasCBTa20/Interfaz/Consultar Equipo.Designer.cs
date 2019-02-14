﻿namespace Proyecto_ResidenciasCBTa20.Interfaz
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
            this.LblCodigo.Location = new System.Drawing.Point(12, 23);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(105, 20);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo de Barras";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(135, 18);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(178, 25);
            this.TxtCodigo.TabIndex = 1;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Location = new System.Drawing.Point(366, 18);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(34, 20);
            this.LblArea.TabIndex = 2;
            this.LblArea.Text = "Area";
            // 
            // TxtArea
            // 
            this.TxtArea.Location = new System.Drawing.Point(427, 18);
            this.TxtArea.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(116, 25);
            this.TxtArea.TabIndex = 3;
            // 
            // BtnBuscarEquipo
            // 
            this.BtnBuscarEquipo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarEquipo.Location = new System.Drawing.Point(623, 11);
            this.BtnBuscarEquipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnBuscarEquipo.Name = "BtnBuscarEquipo";
            this.BtnBuscarEquipo.Size = new System.Drawing.Size(87, 35);
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
            this.DgvEquipos.Location = new System.Drawing.Point(16, 56);
            this.DgvEquipos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DgvEquipos.Name = "DgvEquipos";
            this.DgvEquipos.Size = new System.Drawing.Size(750, 282);
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
            this.BtnModificar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(12, 373);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(87, 35);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(146, 373);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(87, 35);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(293, 373);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(87, 35);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRepMantenimiento
            // 
            this.BtnRepMantenimiento.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRepMantenimiento.Location = new System.Drawing.Point(427, 373);
            this.BtnRepMantenimiento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnRepMantenimiento.Name = "BtnRepMantenimiento";
            this.BtnRepMantenimiento.Size = new System.Drawing.Size(247, 35);
            this.BtnRepMantenimiento.TabIndex = 9;
            this.BtnRepMantenimiento.Text = "Generar Reporte de Mantenimiento";
            this.BtnRepMantenimiento.UseVisualStyleBackColor = true;
            this.BtnRepMantenimiento.Click += new System.EventHandler(this.BtnRepMantenimiento_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.Location = new System.Drawing.Point(721, 373);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(157, 35);
            this.BtnInventario.TabIndex = 10;
            this.BtnInventario.Text = "Consultar Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // Consultar_Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1004, 416);
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
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Consultar_Equipo";
            this.Text = "Consultar Equipo";
            this.Load += new System.EventHandler(this.Consultar_Equipo_Load);
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