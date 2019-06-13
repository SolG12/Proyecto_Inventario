using Proyecto_ResidenciasCBTa20.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ResidenciasCBTa20.Logica
{
    class ControlInventario
    {
        Conexión mConexion;

        public ControlInventario()
        {
            mConexion = new Conexión();
            mConexion.Conectar("MySQL ODBC 5.2w Driver", "localhost", "equipos", "root", "");
        }

        public void AgregarComponente(int id, int cantidad)
        {
            String SQL = "insert into inventario values (null, null, '?1', 'FUNCIONAL')";
            SQL = SQL.Replace("?1", id.ToString());

            for (int i = 0; i < cantidad; i++)
            {
                mConexion.EjecutarActualizacion(SQL);
            }
        }
        public DataTable ConsultarComponentes()
            {
                String SQL = "select * from inventario";
                DataTable ListaComponentes = mConexion.EjecutarConsulta(SQL);
                return ListaComponentes;
            }
        }
    }

