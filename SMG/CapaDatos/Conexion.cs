using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaDatos
{
   public class Conexion
    {
        public OdbcConnection conexionbd()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=cine");// creacion de la conexion via ODBC

            try
            {

                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No se pudo realizar la conexión");
            }
            return conn;
        }

    }
}
