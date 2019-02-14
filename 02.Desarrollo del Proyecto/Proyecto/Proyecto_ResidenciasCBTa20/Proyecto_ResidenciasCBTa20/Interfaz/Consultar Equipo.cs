using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using System.Diagnostics;

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
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Reporte.pdf", FileMode.Create));
            doc.Open();
            PdfPTable table = new PdfPTable(DgvEquipos.Columns.Count);
            table.AddCell(new Phrase("Codigo_Barras"));
            table.AddCell(new Phrase("Marca"));
            table.AddCell(new Phrase("Modelo"));
            table.AddCell(new Phrase("Funcionalidad"));
            table.AddCell(new Phrase("Tipo"));
            table.AddCell(new Phrase("Encargado"));
            table.AddCell(new Phrase("Estado"));
            table.HeaderRows = 1;
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
            doc.Add(table);
            doc.Close();
            Process.Start("Reporte Mantenimiento.pdf");
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            Inventario mConsultar_Inventario = new Inventario();
            this.Hide();
            mConsultar_Inventario.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Equipo_Load(object sender, EventArgs e)
        {

        }
    }
    }

