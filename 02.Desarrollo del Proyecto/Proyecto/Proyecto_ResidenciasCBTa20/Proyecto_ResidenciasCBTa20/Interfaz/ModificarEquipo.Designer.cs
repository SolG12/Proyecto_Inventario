namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    partial class ModificarEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEquipo));
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.TxtEncargado = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.CmbArea = new System.Windows.Forms.ComboBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.LblEncargado = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblFuncionalidad = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnActualizarE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(53, 309);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(367, 118);
            this.TxtDescripcion.TabIndex = 43;
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Funcional ",
            "No Funcional",
            "En reparación"});
            this.CmbEstado.Location = new System.Drawing.Point(143, 236);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(121, 21);
            this.CmbEstado.TabIndex = 42;
            // 
            // TxtEncargado
            // 
            this.TxtEncargado.Location = new System.Drawing.Point(143, 193);
            this.TxtEncargado.Name = "TxtEncargado";
            this.TxtEncargado.Size = new System.Drawing.Size(121, 20);
            this.TxtEncargado.TabIndex = 41;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(143, 152);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(121, 20);
            this.TxtModelo.TabIndex = 40;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(143, 108);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(121, 20);
            this.TxtMarca.TabIndex = 39;
            // 
            // CmbArea
            // 
            this.CmbArea.FormattingEnabled = true;
            this.CmbArea.Items.AddRange(new object[] {
            "Dirección",
            "Subdirección",
            "Recursos Humanos",
            "Recursos FInancieros",
            "Servicios Escolares",
            "Formación Docente",
            "Acádemico y Competencias",
            "Orientación",
            "Biblioteca",
            "Almácen",
            "Vinculación",
            "Subdirección Acádemica",
            "Planeación",
            "Producción",
            "Subdirección Administrativa",
            "Sala 1",
            "Sala 2",
            "Sala Interactiva"});
            this.CmbArea.Location = new System.Drawing.Point(143, 60);
            this.CmbArea.Name = "CmbArea";
            this.CmbArea.Size = new System.Drawing.Size(121, 21);
            this.CmbArea.TabIndex = 38;
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Laptop",
            "Escritorio"});
            this.CmbTipo.Location = new System.Drawing.Point(143, 13);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 21);
            this.CmbTipo.TabIndex = 37;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.Location = new System.Drawing.Point(48, 276);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(76, 20);
            this.LblDesc.TabIndex = 33;
            this.LblDesc.Text = "Descripción";
            // 
            // LblEncargado
            // 
            this.LblEncargado.AutoSize = true;
            this.LblEncargado.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncargado.Location = new System.Drawing.Point(48, 196);
            this.LblEncargado.Name = "LblEncargado";
            this.LblEncargado.Size = new System.Drawing.Size(70, 20);
            this.LblEncargado.TabIndex = 32;
            this.LblEncargado.Text = "Encargado";
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.Location = new System.Drawing.Point(45, 60);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(34, 20);
            this.LblArea.TabIndex = 31;
            this.LblArea.Text = "Área";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(44, 13);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(35, 20);
            this.LblTipo.TabIndex = 30;
            this.LblTipo.Text = "Tipo";
            // 
            // LblFuncionalidad
            // 
            this.LblFuncionalidad.AutoSize = true;
            this.LblFuncionalidad.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFuncionalidad.Location = new System.Drawing.Point(48, 239);
            this.LblFuncionalidad.Name = "LblFuncionalidad";
            this.LblFuncionalidad.Size = new System.Drawing.Size(47, 20);
            this.LblFuncionalidad.TabIndex = 29;
            this.LblFuncionalidad.Text = "Estado";
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModelo.Location = new System.Drawing.Point(48, 152);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(51, 20);
            this.LblModelo.TabIndex = 28;
            this.LblModelo.Text = "Modelo";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(48, 108);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(45, 20);
            this.LblMarca.TabIndex = 27;
            this.LblMarca.Text = "Marca";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(338, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 217);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.Location = new System.Drawing.Point(73, 457);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(101, 35);
            this.BtnRegresar.TabIndex = 35;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnActualizarE
            // 
            this.BtnActualizarE.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarE.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizarE.Image")));
            this.BtnActualizarE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizarE.Location = new System.Drawing.Point(295, 457);
            this.BtnActualizarE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnActualizarE.Name = "BtnActualizarE";
            this.BtnActualizarE.Size = new System.Drawing.Size(104, 35);
            this.BtnActualizarE.TabIndex = 34;
            this.BtnActualizarE.Text = "Actualizar";
            this.BtnActualizarE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizarE.UseVisualStyleBackColor = true;
            this.BtnActualizarE.Click += new System.EventHandler(this.BtnActualizarE_Click);
            // 
            // ModificarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 504);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.TxtEncargado);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.CmbArea);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnActualizarE);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.LblEncargado);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblFuncionalidad);
            this.Controls.Add(this.LblModelo);
            this.Controls.Add(this.LblMarca);
            this.Name = "ModificarEquipo";
            this.Text = "ModificarEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtDescripcion;
        public System.Windows.Forms.ComboBox CmbEstado;
        public System.Windows.Forms.TextBox TxtEncargado;
        public System.Windows.Forms.TextBox TxtModelo;
        public System.Windows.Forms.TextBox TxtMarca;
        public System.Windows.Forms.ComboBox CmbArea;
        public System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnActualizarE;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Label LblEncargado;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblFuncionalidad;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label LblMarca;
    }
}