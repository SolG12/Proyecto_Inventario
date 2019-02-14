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
                DgvInventario.DataSource = mControlComponente.ConsultarComponente();
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
    }
}


