﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_ResidenciasCBTa20.BD;
using Proyecto_ResidenciasCBTa20.Datos;

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
            String SQL = "update equipo set marca='?1', modelo='?2', funcionalidad='?3', tipo='?4',  where id='?5'";
            SQL = SQL.Replace("?1", mEquipo.Marca);
            SQL = SQL.Replace("?2", mEquipo.Modelo);
            SQL = SQL.Replace("?3", mEquipo.Estado);
            SQL = SQL.Replace("?4", mEquipo.Tipo);
            SQL = SQL.Replace("?5", mEquipo.id_Equipo.ToString());

            
            mConexion.EjecutarActualizacion(SQL);

        }

        public DataTable ConsultarEquipo(string area)
        {
            String SQL = "select id, marca, modelo, funcionalidad, tipo, encargado, area,estado";
            SQL = SQL.Replace("?1", area);
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }

        public DataTable ConsultarEquipos()
        {
            String SQL = "select id, marca, modelo, funcionalidad, tipo, encargado, area, estado";
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }

        public void EliminarEquipo(int ID)
        {
            String SQL = "delete from equipo where id='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
        }
    }
}



