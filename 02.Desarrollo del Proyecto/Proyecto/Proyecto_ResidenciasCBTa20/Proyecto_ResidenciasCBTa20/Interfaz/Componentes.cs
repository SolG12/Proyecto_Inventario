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
using Proyecto_ResidenciasCBTa20.Logica;

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

        private void Componentes_Load(object sender, EventArgs e)
        {

        }

        private void Componentes_Activated(object sender, EventArgs e)
        {
            ControlComponente mControlComponente = new ControlComponente();
            try
            {
                DgvComp.DataSource = mControlComponente.ConsultarComponentes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text !="")
            {
                ControlComponente mControlComponente = new ControlComponente();
                try
                {
                    DgvComp.DataSource = mControlComponente.ConsultarComponente(TxtNombre.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("¡Favor de llenar Campos Vacios!");
            }
        }

           

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_Componente = int.Parse(DgvComp.SelectedRows[0].Cells[0].Value.ToString());
                ControlComponente mControlComponente = new ControlComponente();
                mControlComponente.EliminarComponente(id_Componente);
                MessageBox.Show("Componente Eliminado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error.ToString());
            }
        }
    }
}
