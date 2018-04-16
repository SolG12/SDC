using Proyecto_SDC.BD;
using Proyecto_SDC.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_SDC.Logica
{
    class ControlCliente
    {
        Conexion mConexion;

        public ControlCliente()
        {
            mConexion = new Conexion();
            mConexion.Conectar("MySQL ODBC 5.2w Driver", "localhost",
                "mantenimiento", "admin", "1234");
        }

        public void AgregarCliente(Cliente mCliente)
        {
            String SQL = "insert into cliente values(null, '?1', '?2', '?3')";
            SQL = SQL.Replace("?1", mCliente.Nombre);
            SQL = SQL.Replace("?2", mCliente.Direccion);
            SQL = SQL.Replace("?3", mCliente.Telefono);
            mConexion.EjecutarActualizacion(SQL);
        }

        public DataSet ConsultarCliente()
        {
            String SQL = "select * from cliente;";
            DataSet ListaCliente = mConexion.EjecutarConsulta(SQL);
            return ListaCliente;
        }
        public void ModificarCliente(Cliente mCliente)
        {
            String SQL = "update cliente set nombre='?1', direccion='?2', " + "telefono='?3'";
            SQL = SQL.Replace("?1", mCliente.Nombre);
            SQL = SQL.Replace("?2", mCliente.Direccion);
            SQL = SQL.Replace("?3", mCliente.Telefono);
            mConexion.EjecutarActualizacion(SQL);
        }
        public void EliminarCliente(int ID)
        {
            String SQL = "delete from cliente where no_orden='?1'";
            SQL = SQL.Replace("?1", ID.ToString());
            mConexion.EjecutarActualizacion(SQL);
        }
    }
}
