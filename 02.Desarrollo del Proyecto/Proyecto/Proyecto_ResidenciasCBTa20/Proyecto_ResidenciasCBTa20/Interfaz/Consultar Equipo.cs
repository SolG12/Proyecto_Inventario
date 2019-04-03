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

        private void Consultar_Equipo_Load(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarEquipo_Click(object sender, EventArgs e)
        {

        }
    }
}

