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
            String SQL = "insert into equipo values (null, '?1', '?2', '?3', '?4')";
            SQL = SQL.Replace("?1", mComponente.id_Componente.ToString());
            SQL = SQL.Replace("?2", mComponente.Descripcion);
            SQL = SQL.Replace("?3", mComponente.Nombre);
            SQL = SQL.Replace("?4", mComponente.Fecha_Ingreso.ToString());

            mConexion.EjecutarActualizacion(SQL);
        }

        public void ModificarComponente(Componente mComponente)
        {
            String SQL = "update componente set costo='?1', descripcion='?2', nombre='?3',  where id='?4'";
            SQL = SQL.Replace("?1", mComponente.Costo.ToString());
            SQL = SQL.Replace("?2", mComponente.Descripcion);
            SQL = SQL.Replace("?3", mComponente.Nombre);
            SQL = SQL.Replace("?4", mComponente.id_Componente.ToString());

            mConexion.EjecutarActualizacion(SQL);

        }

        public DataTable ConsultarComponentes(int id_Componente)
        {
            String SQL = "select id_componente, descripcion, nombre, fecha_ingreso";
            SQL = SQL.Replace("?1", id_Componente.ToString());
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }

        public DataTable ConsultarComponente()
        {
            String SQL = "select id_componente, descripcion, nombre, fecha_ingreso";
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
