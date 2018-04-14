using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace Proyecto_SDC
{
    class Conexion
    {
        OdbcConnection ConexionMYSQL;

        public void Conectar(string Controlador, string Servidor, String BaseDatos, string Usuario, string Password)
        {
            ConexionMYSQL = new OdbcConnection("DRIVER={" + Controlador + "};SERVER=" + Servidor + ";DATABASE=" + BaseDatos + ";UID=root;PWD=;");
            ConexionMYSQL.Open();
        }

        public DataSet EjecutarConsulta(string SQL)
        {
            OdbcDataAdapter AdaptadorDatos = new OdbcDataAdapter(SQL, ConexionMYSQL);
            DataSet Result = new DataSet();
            AdaptadorDatos.Fill(Result);
            return Result;
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
