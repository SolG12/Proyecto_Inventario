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

namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    public partial class Componentes : Form
    {
        public Componentes()
        {
            InitializeComponent();
        }
        private void BtnAgregarComp_Click(object sender, EventArgs e)
        {
            Agregar_Componente mAgregar_Componente = new Agregar_Componente();
            this.Hide();
            mAgregar_Componente.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Menu_Principal mMenu_Principal = new Menu_Principal();
            this.Hide();
            mMenu_Principal.Show();
        }

        private void BtnRepCostos_Click(object sender, EventArgs e)
        {

        }

        private void Componentes_Load(object sender, EventArgs e)
        {

        }

    }
}
