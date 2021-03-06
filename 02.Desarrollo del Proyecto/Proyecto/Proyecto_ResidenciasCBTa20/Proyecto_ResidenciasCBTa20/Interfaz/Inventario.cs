﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Proyecto_ResidenciasCBTa20.Datos;
using Proyecto_ResidenciasCBTa20.Logica;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;

namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ControlInventario mControlInventario = new ControlInventario();
            try
            {
                DgvInventario.DataSource = mControlInventario.ConsultarComponentes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu_Principal mMenu_Principal = new Menu_Principal();
            this.Hide();
            mMenu_Principal.Show();
        }

        private void BtnConsultarComp_Click(object sender, EventArgs e)
        {
            Componentes mConsultar_Componentes = new Componentes();
            this.Hide();
            mConsultar_Componentes.Show();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void BtnRepCostos_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Reporte.pdf", FileMode.Create));
            doc.Open();

            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("c:/Users/Luis/Documents/GitHub/Proyecto_Inventario/02.Desarrollo del Proyecto/Proyecto/Proyecto_ResidenciasCBTa20/Proyecto_ResidenciasCBTa20/bin/Debug/img/Logo1.png");
            imagen.BorderWidth = 0;
            imagen.SetAbsolutePosition(460, 720);
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 100 / imagen.Width;
            imagen.ScalePercent(percentage * 70);

            Paragraph Encabezado = new Paragraph(string.Format("\n" +
                "CENTRO DE BACHILLERATO TECNOLOGICO AGROPECUARIO No. 20 " + "\n"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD));
            Encabezado.Alignment = Element.ALIGN_CENTER;
            doc.Add(Encabezado);

            Paragraph title = new Paragraph(string.Format("\n" +
                "Reporte de Ingresos " + "\n"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            PdfPTable table = new PdfPTable(DgvInventario.Columns.Count);
            table.AddCell(new Phrase("Numero"));
            table.AddCell(new Phrase("Nombre"));
            table.AddCell(new Phrase("Descripcion"));
            table.AddCell(new Phrase("Estado"));
            table.AddCell(new Phrase("Fecha"));
            table.AddCell(new Phrase("Equipo"));
            table.AddCell(new Phrase("Costo"));


            for (int i = 0; i < DgvInventario.Rows.Count; i++)
            {
                for (int k = 0; k < DgvInventario.Columns.Count; k++)
                {
                    if (DgvInventario[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(DgvInventario[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            doc.Close();
            Process.Start("Reporte.pdf");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text != "")
            {
                ControlComponente mControlComponente = new ControlComponente();
                try
                {
                    DgvInventario.DataSource = mControlComponente.ConsultarComponente(TxtNombre.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("¡Favor de ingresar un Componente!");
            }
        }

        private void Inventario_Activated(object sender, EventArgs e)
        {
            ControlInventario mControlInventario = new ControlInventario();
            try
            {
                DgvInventario.DataSource = mControlInventario.ConsultarComponentes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAsignarEquipo_Click(object sender, EventArgs e)
        {
            AsignarEquipo mAsignarEquipo = new AsignarEquipo();
            mAsignarEquipo.idComponente = 0;                    
            mAsignarEquipo.lblComponente.Text = DgvInventario.SelectedRows[0].Cells[1].Value.ToString();
            mAsignarEquipo.idComponente = int.Parse(DgvInventario.SelectedRows[0].Cells[0].Value.ToString());
            mAsignarEquipo.Show();
        }
    }
}
    


