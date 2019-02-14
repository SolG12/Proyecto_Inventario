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

        private void BtnGenerarRepCostos_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarComp_Click(object sender, EventArgs e)
        {
            Agregar_Componente mAgregar_Componente = new Agregar_Componente();
            this.Hide();
            mAgregar_Componente.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
