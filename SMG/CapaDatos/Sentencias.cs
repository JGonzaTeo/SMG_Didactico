using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;
        public OdbcDataReader ProbarTabla(string campo)
        {
            string error = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_wsrenap WHERE CUI = "+ campo +" ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                string nom1 = reader.GetString(0);
                Console.WriteLine(nom1);
                reader.Close();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }
            
        }

        public OdbcDataReader consultaCUI(string campo)
        {
            string error = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_wsrenap WHERE CUI = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                string nom1 = reader.GetString(0);
                Console.WriteLine(nom1);
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }

        public OdbcDataReader consultaOrnato(string campo)
        {
            string error = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_wsmunicipalidad WHERE doc_numero = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        public OdbcDataReader consultaBanco(string campo)
        {
            string error = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_wsbanco WHERE doc_numero = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        /*insercion de datos*/
        public OdbcDataReader InsertarSolicitante(string CUI, string Nombre, string Apellido, string Nacionalidad, string Pais,string Sexo, string Fecha, string ornato, string banco)
        { 
            try
            {
                cn.conexionbd();
                string consulta = "insert into tbl_ciudadanos_mayores values (" + CUI + ", '" + Nombre + "' ,'" + Apellido + "','" + Nacionalidad + "','" + Pais + "','" + Sexo + "','" + Fecha + "'," + ornato + "," +  banco + "," + 1 + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader InsertarSolicitanteH(string CUI, string Nombre, string Apellido, string Nacionalidad, string Pais, string Sexo, string Fecha, string cui_padre, string cui_madre,string documento, string banco)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into tbl_ciudadanos_menores values (" + CUI + ", '" + Nombre + "' ,'" + Apellido + "','" + Nacionalidad + "','" + Pais + "','" + Sexo + "','" + Fecha + "'," + cui_padre+ ","+ cui_madre+ "," + documento+ "," + banco + "," + 1 + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultaCitas(string fecha)
        {
            try
            {
                cn.conexionbd();
                string consulta = "Select COUNT(fechayhora) FROM tbl_ticket WHERE fechayhora="+fecha+";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }

            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertarTicket(string cui, string numcita, string fecha)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into tbl_ticket values (0" + cui + ", '" + numcita + "' ,'" + fecha + "1" + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


    }
}
