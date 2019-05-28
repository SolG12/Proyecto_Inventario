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
            mConexion.Conectar("MySQL ODBC 5.2w Driver", "localhost", "equipos", "root", "");
        }

        public void AgregarComponente(Componente mComponente)
        {
            String SQL = "insert into componente values (null, '?1', '?2', '?3', '?4')";
            SQL = SQL.Replace("?1", mComponente.Nombre);
            SQL = SQL.Replace("?2", mComponente.Fecha_Ingreso.ToString());
            SQL = SQL.Replace("?3", mComponente.Costo.ToString());
            SQL = SQL.Replace("?4", mComponente.Descripcion);

            mConexion.EjecutarActualizacion(SQL);
        }

        public void ModificarComponente(Componente mComponente)
        {
            String SQL = "update componente set Costo='?1', Fecha_Ingreso='?2', Nombre='?3', Descripcion='?4'  where idComponente='?5'";
            SQL = SQL.Replace("?1", mComponente.Costo.ToString());
            SQL = SQL.Replace("?2", mComponente.Fecha_Ingreso.ToString());
            SQL = SQL.Replace("?3", mComponente.Nombre);
            SQL = SQL.Replace("?4", mComponente.Descripcion);
            SQL = SQL.Replace("?5", mComponente.idComponente.ToString());

            mConexion.EjecutarActualizacion(SQL);

        }

        public DataTable ConsultarComponentes()
        {
            String SQL = "select * from componente";
            DataTable ListaComponentes = mConexion.EjecutarConsulta(SQL);
            return ListaComponentes;
        }

        public DataTable ConsultarComponente(string Nombre)
        {
            String SQL = "select * from componente where Nombre='?1'";
            SQL = SQL.Replace("?1",Nombre);
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }

        public void EliminarComponente(int idComponente)
        {
            String SQL = "delete from componente where idComponente='?1'";
            SQL = SQL.Replace("?1", idComponente.ToString());
            mConexion.EjecutarActualizacion(SQL);
        }
    }
}
