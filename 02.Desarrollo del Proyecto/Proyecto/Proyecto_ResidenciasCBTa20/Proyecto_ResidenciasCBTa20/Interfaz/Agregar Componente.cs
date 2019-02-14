using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_ResidenciasCBTa20.BD;
using Proyecto_ResidenciasCBTa20.Datos;
using Proyecto_ResidenciasCBTa20.Logica;
using Proyecto_ResidenciasCBTa20.Interfaz;


namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    public partial class Agregar_Componente : Form
    {
        public Agregar_Componente()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (TxtNombre.Text != "" && TxtCantidad.Text != "" && TxtCosto.Text != "" && TxtFecha_Ingreso.Text != "" && CmbEstado.Text != "")
            {
                try
                {
                    Componente mComponente = new Componente();
                    mComponente.Nombre = TxtNombre.Text;
                    mComponente.Cantidad = int.Parse(TxtCantidad.Text);
                    mComponente.Costo = int.Parse(TxtCosto.Text);

                    ControlComponente mControlComponente = new ControlComponente();
                    mControlComponente.AgregarComponente(mComponente);
                    MessageBox.Show("Equipo Guardado");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al Actualizar: " + e);

                }

            }
            else
            {
                MessageBox.Show("¡Favor de llenar campos vacíos!");
            }
        }

    }
}

