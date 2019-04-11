using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_ResidenciasCBTa20.BD
{
    class Conexión
    {
        OdbcConnection ConexionMYSQL;

        public void Conectar(string  Controlador, string Servidor, String BaseDatos, string Usuario, string Password)
        {
            ConexionMYSQL = new OdbcConnection("DRIVER={" + Controlador + "};SERVER=" + Servidor + ";DATABASE=" + BaseDatos + ";UID=root;PWD=;");
            ConexionMYSQL.Open();
        }

        public DataTable EjecutarConsulta(string SQL)
        {
            try
            {
                OdbcDataAdapter AdaptadorDatos = new OdbcDataAdapter(SQL, ConexionMYSQL);
                DataTable Result = new DataTable();
                AdaptadorDatos.Fill(Result);
                return Result;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
 
        }
        public void EjecutarActualizacion(string SQL)
        {
            OdbcCommand Comando = new OdbcCommand(SQL, ConexionMYSQL);
            Comando.ExecuteNonQuery();
        }

        public void Desconectar()
        {
            ConexionMYSQL.Close();
        }
    }
}
