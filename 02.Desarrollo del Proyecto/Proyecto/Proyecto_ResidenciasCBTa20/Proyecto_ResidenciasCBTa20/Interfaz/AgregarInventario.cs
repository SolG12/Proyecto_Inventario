using Proyecto_ResidenciasCBTa20.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    public partial class AgregarInventario : Form
    {
        public int idComponente;

        public AgregarInventario()
        {
            InitializeComponent();
        }

        private void lblComponente_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ControlInventario mControlInventario = new ControlInventario();
            mControlInventario.AgregarComponente(idComponente, int.Parse(txtCantidad.Text));
            MessageBox.Show("Inventario agregado exitosamente!");
            this.Close();
        }
    }
}
