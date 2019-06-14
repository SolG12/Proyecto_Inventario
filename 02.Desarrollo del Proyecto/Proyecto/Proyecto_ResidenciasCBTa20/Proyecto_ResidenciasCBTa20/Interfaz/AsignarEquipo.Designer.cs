namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    partial class AsignarEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarEquipo));
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.lblComponente = new System.Windows.Forms.Label();
            this.btnAsignarEquipo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(91, 79);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(93, 21);
            this.cmbEquipo.TabIndex = 0;
            // 
            // lblComponente
            // 
            this.lblComponente.AutoSize = true;
            this.lblComponente.Location = new System.Drawing.Point(114, 44);
            this.lblComponente.Name = "lblComponente";
            this.lblComponente.Size = new System.Drawing.Size(35, 13);
            this.lblComponente.TabIndex = 2;
            this.lblComponente.Text = "label1";
            // 
            // btnAsignarEquipo
            // 
            this.btnAsignarEquipo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarEquipo.Image")));
            this.btnAsignarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarEquipo.Location = new System.Drawing.Point(66, 126);
            this.btnAsignarEquipo.Name = "btnAsignarEquipo";
            this.btnAsignarEquipo.Size = new System.Drawing.Size(136, 31);
            this.btnAsignarEquipo.TabIndex = 29;
            this.btnAsignarEquipo.Text = "Asignar Equipo";
            this.btnAsignarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarEquipo.UseVisualStyleBackColor = true;
            this.btnAsignarEquipo.Click += new System.EventHandler(this.btnAsignarEquipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id Equipo";
            // 
            // AsignarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsignarEquipo);
            this.Controls.Add(this.lblComponente);
            this.Controls.Add(this.cmbEquipo);
            this.Name = "AsignarEquipo";
            this.Text = "AsignarEquipo";
            this.Activated += new System.EventHandler(this.AsignarEquipo_Activated);
            this.Load += new System.EventHandler(this.AsignarEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEquipo;
        public System.Windows.Forms.Label lblComponente;
        private System.Windows.Forms.Button btnAsignarEquipo;
        private System.Windows.Forms.Label label1;
    }
}