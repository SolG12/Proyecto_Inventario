using System;
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
            ControlComponente mControlComponente = new ControlComponente();
            try
            {
                DgvInventario.DataSource = mControlComponente.ConsultarComponentes();
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

            PdfPTable table = new PdfPTable(DgvInventario.Columns.Count);
            table.AddCell(new Phrase("idComponente"));
            table.AddCell(new Phrase("Nombre"));
            table.AddCell(new Phrase("Costo"));
            table.AddCell(new Phrase("Descripcion"));
            table.AddCell(new Phrase("Fecha_Ingreso"));
          
         
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
    }
}


