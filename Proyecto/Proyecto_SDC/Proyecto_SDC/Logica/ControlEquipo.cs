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
            mConexion.Conectar("MySQL ODBC 5.2w Driver", "localhost", "mantenimientobd", "root", "");
        }

        public void ActualizarEquipo(Equipo mEquipo)
        {
            String SQL = "update equipo set marca = '?1', modelo = '?2', funcionalidad = '?3', tipo = '?4' , descripcion = '?5' where no_orden = '?6'";
            SQL = SQL.Replace("?1", mEquipo.Marca);
            SQL = SQL.Replace("?2", mEquipo.Modelo);
            SQL = SQL.Replace("?3", mEquipo.Funcionalidad);
            SQL = SQL.Replace("?4", mEquipo.Tipo);
            SQL = SQL.Replace("?5", mEquipo.Descripcion);
            SQL = SQL.Replace("?6", mEquipo.No_Orden.ToString());

            mConexion.EjecutarActualizacion(SQL);
        }

        public void AgregarEquipo(Equipo mEquipo)
        {
            String SQL = "insert into equipo values (null, '?1', '?2', '?3', '?4', '?5', null)";
            SQL = SQL.Replace("?1", mEquipo.id_cliente.ToString());
            SQL = SQL.Replace("?2", mEquipo.Marca);
            SQL = SQL.Replace("?3", mEquipo.Modelo);
            SQL = SQL.Replace("?4", mEquipo.Funcionalidad);
            SQL = SQL.Replace("?5", mEquipo.Tipo);

            mConexion.EjecutarActualizacion(SQL);
        }

        public void ModificarEquipo(Equipo mEquipo)
        {
            String SQL = "update equipo set marca='?1', modelo='?2', funcionalidad='?3', tipo='?4', descripcion='?6' where id='?5'";
            SQL = SQL.Replace("?1", mEquipo.Marca);
            SQL = SQL.Replace("?2", mEquipo.Modelo);
            SQL = SQL.Replace("?3", mEquipo.Funcionalidad);
            SQL = SQL.Replace("?4", mEquipo.Tipo);
            SQL = SQL.Replace("?5", mEquipo.ID.ToString());
            SQL = SQL.Replace("?6", mEquipo.Descripcion.ToString());

            mConexion.EjecutarActualizacion(SQL);

        }

        public DataTable ConsultarEquipo(string no_orden)
        {
            String SQL = "select no_orden, marca, modelo, funcionalidad, tipo, descripcion, nombre, direccion, telefono from cliente join equipo on cliente.id_cliente = equipo.id_cliente where no_orden = '?1'";
            SQL = SQL.Replace("?1", no_orden);
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }

        public DataTable ConsultarEquipos()
        {
            String SQL = "select no_orden, marca, modelo, funcionalidad, tipo, descripcion, nombre, direccion, telefono from cliente join equipo on cliente.id_cliente = equipo.id_cliente";
            DataTable ListaEquipos = mConexion.EjecutarConsulta(SQL);
            return ListaEquipos;
        }

        public void EliminarEquipo(int ID)
        {
            String SQL = "delete from equipo where no_orden='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mConexion.EjecutarActualizacion(SQL);
        }
    }
}
