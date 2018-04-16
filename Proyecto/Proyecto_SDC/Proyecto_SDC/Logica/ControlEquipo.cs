using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_SDC.BD;
using Proyecto_SDC.Datos;

namespace Proyecto_SDC.Logica
{
    class ControlEquipo
    {
        Conexion mConexion;

        public ControlEquipo()
        {
            mConexion = new Conexion();
            mConexion.Conectar("MySQL ODBC 5.2w Driver", "localhost", "mantenimiento", "admin", "1234");
        }

        public void AgregarEquipo(Equipo mEquipo)
        {
            String SQL = "insert into equipo values (null, '?1', '?2', '?3', '?4', '?5')";
            SQL = SQL.Replace("?1", mEquipo.Marca);
            SQL = SQL.Replace("?2", mEquipo.Modelo);
            SQL = SQL.Replace("?3", mEquipo.Funcionalidad);
            SQL = SQL.Replace("?4", mEquipo.No_Orden);
            SQL = SQL.Replace("?5", mEquipo.Descripcion);

            mConexion.EjecutarActualizacion(SQL);
        }

        public void ModificarEquipo(Equipo mEquipo)
        {
            String SQL = "update equipo set marca='?1', modelo='?2', funcionalidad='?3', descripcion='?4',  where id='?5'";
            SQL = SQL.Replace("?1", mEquipo.Marca);
            SQL = SQL.Replace("?2", mEquipo.Modelo);
            SQL = SQL.Replace("?3", mEquipo.Funcionalidad);
            SQL = SQL.Replace("?4", mEquipo.Descripcion);
            SQL = SQL.Replace("?5", mEquipo.ID.ToString());

            mConexion.EjecutarActualizacion(SQL);

        }

        public void EliminarEquipo(int ID)
        {
            String SQL = "delete from equipo where id='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
        }
    }
}
