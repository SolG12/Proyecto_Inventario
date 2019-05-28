using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using System.Diagnostics;
using Proyecto_ResidenciasCBTa20.Datos;
using Proyecto_ResidenciasCBTa20.Logica;

namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    public partial class Consultar_Equipo : Form
    {
        public Consultar_Equipo()
        {
            InitializeComponent();
        }

        private void BtnRepMantenimiento_Click(object sender, EventArgs e)
        {

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Reporte de Mantenimiento.pdf", FileMode.Create));
            doc.Open();

            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("c:/Users/Luis/Documents/GitHub/Proyecto_Inventario/02.Desarrollo del Proyecto/Proyecto/Proyecto_ResidenciasCBTa20/Proyecto_ResidenciasCBTa20/bin/Debug/img/Logo1.png");
            imagen.BorderWidth = 0;
            imagen.SetAbsolutePosition(460, 720);
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 100 / imagen.Width;
            imagen.ScalePercent(percentage * 70);

            Paragraph title = new Paragraph(string.Format("\n" +
                "Reporte de Equipos " + "\n"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
         



            PdfPTable table = new PdfPTable(DgvEquipos.Columns.Count);
            
            table.AddCell(new Phrase("idEquipo"));
            table.AddCell(new Phrase("Marca"));
            table.AddCell(new Phrase("Modelo"));
            table.AddCell(new Phrase("Estado"));
            table.AddCell(new Phrase("Tipo"));
            table.AddCell(new Phrase("Descripcion"));
            table.AddCell(new Phrase("Area"));
            table.AddCell(new Phrase("Encargado"));
            //table.AddCell(new Phrase("idEquipo"));
            for (int i = 0; i < DgvEquipos.Rows.Count; i++)
            {
                for (int k = 0; k < DgvEquipos.Columns.Count; k++)
                {
                    if (DgvEquipos[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(DgvEquipos[k, i].Value.ToString()));
                    }
                }
            }

            doc.Add(imagen);
            doc.Add(table);
            doc.Close();
            Process.Start("Reporte de Mantenimiento.pdf");
        }
        private void BtnInventario_Click(object sender, EventArgs e)
        {
            Inventario mConsultar_Inventario = new Inventario();
            this.Hide();
            mConsultar_Inventario.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Menu_Principal mMenu_Principal = new Menu_Principal();
            this.Hide();
            mMenu_Principal.Show();
        }

       

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Equipo mEquipo = new Equipo();
                int id_Equipo = int.Parse(DgvEquipos.SelectedRows[0].Cells[0].Value.ToString());
                ControlEquipo mControlEquipo = new ControlEquipo();
                mControlEquipo.EliminarEquipo(id_Equipo);
              
                MessageBox.Show("Equipo Eliminado");
            }
            catch (Exception error)
            {
                 MessageBox.Show("Error "+error.ToString());
               


            }
        }

        private void BtnBuscarEquipo_Click(object sender, EventArgs e)
        {
            ControlEquipo mControlEquipo = new ControlEquipo();
            try
            {
                DgvEquipos.DataSource = mControlEquipo.ConsultarEquipo(TxtArea.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }


        private void Consultar_Equipo_Activated(object sender, EventArgs e)
        {
            ControlEquipo mControlEquipo = new ControlEquipo();
            try
            {
                DgvEquipos.DataSource = mControlEquipo.ConsultarEquipos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnAEquipo_Click(object sender, EventArgs e)
        {
            ControlEquipo mControlEquipo = new ControlEquipo();
            try
            {
                DgvEquipos.DataSource = mControlEquipo.ConsultarEquipos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Actualizar!!");
            }
        }
    }
}

