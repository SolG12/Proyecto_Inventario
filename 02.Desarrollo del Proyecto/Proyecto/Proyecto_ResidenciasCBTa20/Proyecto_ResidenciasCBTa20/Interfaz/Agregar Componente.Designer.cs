﻿namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    partial class Agregar_Componente
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblCosto = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtFecha_Ingreso = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(28, 49);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(54, 20);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(28, 106);
            this.LblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(59, 20);
            this.LblCantidad.TabIndex = 1;
            this.LblCantidad.Text = "Cantidad";
            // 
            // LblCosto
            // 
            this.LblCosto.AutoSize = true;
            this.LblCosto.Location = new System.Drawing.Point(28, 159);
            this.LblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCosto.Name = "LblCosto";
            this.LblCosto.Size = new System.Drawing.Size(41, 20);
            this.LblCosto.TabIndex = 2;
            this.LblCosto.Text = "Costo";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(28, 219);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(106, 20);
            this.LblFecha.TabIndex = 3;
            this.LblFecha.Text = "Fecha de Ingreso";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(36, 289);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(47, 20);
            this.LblEstado.TabIndex = 4;
            this.LblEstado.Text = "Estado";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(154, 46);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(136, 25);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(154, 101);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(136, 25);
            this.TxtCantidad.TabIndex = 6;
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(150, 159);
            this.TxtCosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(140, 25);
            this.TxtCosto.TabIndex = 7;
            // 
            // TxtFecha_Ingreso
            // 
            this.TxtFecha_Ingreso.Location = new System.Drawing.Point(150, 219);
            this.TxtFecha_Ingreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFecha_Ingreso.Name = "TxtFecha_Ingreso";
            this.TxtFecha_Ingreso.Size = new System.Drawing.Size(140, 25);
            this.TxtFecha_Ingreso.TabIndex = 8;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(276, 383);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(88, 35);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(75, 383);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(88, 35);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(150, 281);
            this.CmbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(140, 28);
            this.CmbEstado.TabIndex = 12;
            // 
            // Agregar_Componente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(521, 432);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtFecha_Ingreso);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblCosto);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblNombre);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Agregar_Componente";
            this.Text = "Agregar Componente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblCosto;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtFecha_Ingreso;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ComboBox CmbEstado;
    }
}