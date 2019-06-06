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

            if (TxtNombre.Text != "" && TxtDescipcion.Text != "" && TxtCosto.Text != "" && TxtFecha_Ingreso.Text != "")
            {
                    Componente mComponente = new Componente();
                    mComponente.Nombre = TxtNombre.Text;
                    mComponente.Descripcion = TxtDescipcion.Text;
                    mComponente.Costo = int.Parse(TxtCosto.Text);
                mComponente.Fecha_Ingreso = TxtFecha_Ingreso.Value;

                    ControlComponente mControlComponente = new ControlComponente();
                    
                    
                    mControlComponente.AgregarComponente(mComponente);
                    MessageBox.Show("Componente Guardado");

                this.Hide();
                Menu_Principal mMenu_Principal = new Menu_Principal();
                mMenu_Principal.Show();
            }
            else
            {
                MessageBox.Show("¡Favor de llenar campos vacíos!");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Menu_Principal mMenu_Principal = new Menu_Principal();
            this.Hide();
            mMenu_Principal.Show();
        }
    }
}

