using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_ResidenciasCBTa20.Interfaz;
using System.Windows.Forms;
using Proyecto_ResidenciasCBTa20.Logica;
using Proyecto_ResidenciasCBTa20.Datos;

namespace Proyecto_ResidenciasCBTa20.Interfaz
{
    public partial class ModificarEquipo : Form
    {
        public ModificarEquipo()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnActualizarE_Click(object sender, EventArgs e)
        {
            if (CmbTipo.Text != "" && CmbArea.Text != "" && TxtMarca.Text != "" && TxtModelo.Text != ""
              && TxtEncargado.Text != "" && CmbEstado.Text != "" && TxtDescripcion.Text != "")
            {
                try
                {
                    Equipo mEquipo = new Equipo();
                    mEquipo.Marca = TxtMarca.Text;
                    mEquipo.Modelo = TxtModelo.Text;
                    mEquipo.Tipo = CmbTipo.Text;
                    mEquipo.Descripcion = TxtDescripcion.Text;
                    mEquipo.Area = CmbArea.Text;
                    mEquipo.Encargado = TxtEncargado.Text;
                    mEquipo.Estado = CmbEstado.Text;



                    ControlEquipo mControlEquipo = new ControlEquipo();
                    mControlEquipo.ModificarEquipo(mEquipo);
                    MessageBox.Show("Equipo Actualizado");

                    this.Hide();
                    Menu_Principal mMenu_Principal = new Menu_Principal();
                    mMenu_Principal.Show();
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
