using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_ResidenciasCBTa20.BD;
using Proyecto_ResidenciasCBTa20.Datos;
using Proyecto_ResidenciasCBTa20.Interfaz;

namespace Proyecto_ResidenciasCBTa20.Logica
{
    class ControlComponente
    {
        Conexión mConexion;

        public ControlComponente()
        {
            mConexion = new Conexión();
            mConexion.Conectar("MySQL ODBC 5.2w Driver", "localhost", "inventario", "root", "");
        }

        public void AgregarComponente(Componente mComponente)
        {
            String SQL = "insert into equipo values (null, '?1', '?2', '?3', '?4', '?5', '?6')";
            SQL = SQL.Replace("?1", mComponente.id_Componente.ToString());
            SQL = SQL.Replace("?2", mComponente.Cantidad.ToString());
            SQL = SQL.Replace("?3", mComponente.Costo.ToString());
            SQL = SQL.Replace("?4", mComponente.Estado);
            SQL = SQL.Replace("?5", mComponente.Nombre);
            SQL = SQL.Replace("?6", mComponente.Fecha_Ingreso.ToString());

            mConexion.EjecutarActualizacion(SQL);
        }

        public void ModificarComponente(Componente mComponente)
        {
            String SQL = "update componente set cantidad='?1', costo='?2', estado='?3', nombre='?4',  where id='?5'";
            SQL = SQL.Replace("?1", mComponente.Cantidad.ToString());
            SQL = SQL.Replace("?2", mComponente.Costo.ToString());
            SQL = SQL.Replace("?3", mComponente.Estado);
            SQL = SQL.Replace("?4", mComponente.Nombre);
            SQL = SQL.Replace("?5", mComponente.id_Componente.ToString());

            mConexion.EjecutarActualizacion(SQL);

        }

        public DataTable ConsultarComponentes(int id_Componente  )
        {
            String SQL = "select id_componente, cantidad, costo, estado, nombre, fecha_ingreso";
            SQL = SQL.Replace("?1", id_Componente.ToString());
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }

        public DataTable ConsultarComponente()
        {
            String SQL = "select id_componente, cantidad, costo, estado, nombre, fecha:ingreso";
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }

        public void EliminarComponente(int ID)
        {
            String SQL = "delete from equipo where id='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
        }
    }
}
