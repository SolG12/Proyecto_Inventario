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
using Proyecto_ResidenciasCBTa20.Logica;
using Proyecto_ResidenciasCBTa20.Datos;
using Proyecto_ResidenciasCBTa20.Interfaz;

namespace Proyecto_ResidenciasCBTa20
{
    public partial class Agregar_Equipo : Form
    {
        public Agregar_Equipo()
        {
            InitializeComponent();
        }

      

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (CmbTipo.Text != "" && CmbArea.Text != "" && TxtMarca.Text != "" && TxtModelo.Text != "" 
                && TxtEncargado.Text != "" && CmbEstado.Text != "" && TxtDescripcion.Text !="")
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
                    mControlEquipo.AgregarEquipo(mEquipo);
                    MessageBox.Show("Equipo Guardado");

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

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Menu_Principal mMenu_Principal = new Menu_Principal();
            this.Hide();
            mMenu_Principal.Show();
        }

        private void Agregar_Equipo_Load(object sender, EventArgs e)
        {

        }
    }
}
