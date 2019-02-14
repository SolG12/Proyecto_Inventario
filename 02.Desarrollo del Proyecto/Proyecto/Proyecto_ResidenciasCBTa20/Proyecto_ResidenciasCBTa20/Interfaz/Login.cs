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
using Proyecto_ResidenciasCBTa20.Interfaz;

namespace Proyecto_ResidenciasCBTa20
{
    public partial class Login : Form
    {
        int Contador = 0;

        Conexión mConexion;

        public Login()
        {
                InitializeComponent();
                mConexion = new Conexión();
                mConexion.Conectar("MySQL ODBC 5.2w Driver", "localhost",
                    "mantenimientobd", "root", "");
            }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if ((TxtUsuario.Text != "") && (TxtContraseña.Text != ""))
            {
                if ((TxtUsuario.Text == "admin") && (TxtContraseña.Text == "1234"))
                {
                    Menu_Principal mMenu_Principal = new Menu_Principal();
                    mMenu_Principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                    Contador++;
                    if (Contador == 3)
                    {
                        MessageBox.Show("¡Número de intentos excedido!");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Favor de llenar campos vacíos!");

            }
        }
    }
}
