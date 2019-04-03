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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void BtnAgregarEq_Click(object sender, EventArgs e)
        {
            Agregar_Equipo mAgregar_Equipo = new Agregar_Equipo();
            this.Hide();
            mAgregar_Equipo.Show();
        }

        private void BtnConsularEquipo_Click(object sender, EventArgs e)
        {
            Consultar_Equipo mConsultar_Equipo = new Consultar_Equipo();
            this.Hide();
            mConsultar_Equipo.Show();
        }

        private void BtnAgregarComp_Click(object sender, EventArgs e)
        {
            Agregar_Componente mAgregar_Componente = new Agregar_Componente();
            this.Hide();
            mAgregar_Componente.Show();
        }

        private void BtnConsultarComp_Click(object sender, EventArgs e)
        {
            Componentes mConsultar_Componentes = new Componentes();
            this.Hide();
            mConsultar_Componentes.Show();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            Inventario mConsultar_Inventario = new Inventario();
            this.Hide();
            mConsultar_Inventario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
