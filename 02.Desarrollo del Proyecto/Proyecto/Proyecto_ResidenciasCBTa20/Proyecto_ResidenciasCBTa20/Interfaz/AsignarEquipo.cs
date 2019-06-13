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
    public partial class AsignarEquipo : Form
    {
        public int idComponente;
        public int idEquipo;

        public AsignarEquipo()
        {
            InitializeComponent();
        }

        private void AsignarEquipo_Load(object sender, EventArgs e)
        {

        }

        private void AsignarEquipo_Activated(object sender, EventArgs e)
        {
            ControlEquipo mControlEquipo = new ControlEquipo();

            cmbEquipo.DataSource = mControlEquipo.ConsultarEquipos();
            cmbEquipo.DisplayMember = "idEquipo";
            cmbEquipo.ValueMember = "idEquipo";
        }

        private void btnAsignarEquipo_Click(object sender, EventArgs e)
        {

            ControlInventario mControlInventario = new ControlInventario();
            

            mControlInventario.ModificarInventario(idEquipo, int.Parse(cmbEquipo.SelectedValue.ToString()));
            MessageBox.Show("Componente Asignado con éxito!");
            this.Close();
        }
    }
}
