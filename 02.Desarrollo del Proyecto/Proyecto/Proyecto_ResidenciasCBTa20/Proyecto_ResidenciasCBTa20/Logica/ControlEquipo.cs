using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_ResidenciasCBTa20.BD;
using Proyecto_ResidenciasCBTa20.Datos;
using System.Windows.Forms;

namespace Proyecto_ResidenciasCBTa20.Logica
{
    class ControlEquipo
    {
        Conexión mConexion;

        public ControlEquipo()
        {
            mConexion = new Conexión();
            mConexion.Conectar("MySQL ODBC 5.2w Driver", "localhost", "equipos", "root", "");
        }

        public void AgregarEquipo(Equipo mEquipo)
        {
            String SQL = "insert into equipo values (null, '?1', '?2', '?3', '?4', '?5', '?6', '?7')";
            SQL = SQL.Replace("?1", mEquipo.Marca);
            SQL = SQL.Replace("?2", mEquipo.Modelo);
            SQL = SQL.Replace("?3", mEquipo.Estado);
            SQL = SQL.Replace("?4", mEquipo.Tipo);
            SQL = SQL.Replace("?5", mEquipo.Descripcion);
            SQL = SQL.Replace("?6", mEquipo.Area);
            SQL = SQL.Replace("?7", mEquipo.Encargado);
       



            mConexion.EjecutarActualizacion(SQL);
        }

        public void ModificarEquipo(Equipo mEquipo)
        {
            String SQL = "update equipo set marca='?1', modelo='?2', estado='?3', tipo='?4', descripcion='?5', area='?6', encargado='?7' where idEquipo='?8'";
            SQL = SQL.Replace("?1", mEquipo.Marca);
            SQL = SQL.Replace("?2", mEquipo.Modelo);
            SQL = SQL.Replace("?3", mEquipo.Estado);
            SQL = SQL.Replace("?4", mEquipo.Tipo);
            SQL = SQL.Replace("?5", mEquipo.Descripcion);
            SQL = SQL.Replace("?6", mEquipo.Area);
            SQL = SQL.Replace("?7", mEquipo.Encargado);
            SQL = SQL.Replace("?8", mEquipo.id_Equipo.ToString());

            mConexion.EjecutarActualizacion(SQL);

        }

        public DataTable ConsultarEquipo(string area)
        {
            String SQL = "select * from equipo where area='?1'";
            SQL = SQL.Replace("?1", area);
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }

        public DataTable ConsultarEquipos()
        {
            String SQL = "select * from equipo";
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }


        public void EliminarEquipo(int id_Equipo)
        {
            String SQL = "delete from equipo where idEquipo='?1'";
            SQL = SQL.Replace("?1", id_Equipo.ToString());
            mConexion.EjecutarActualizacion(SQL);
        }
    }
}



