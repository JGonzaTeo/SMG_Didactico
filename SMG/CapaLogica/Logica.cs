using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Odbc;
namespace CapaLogica
{
    public class Logica
    {
        Sentencias sn = new Sentencias();
        public OdbcDataReader TestTabla(string tabla)
        {
            return sn.ProbarTabla(tabla);
        }

        public void pruebaTabla()
        {
            throw new NotImplementedException();
        }
        public OdbcDataReader verificacionCUI(string tabla)
        {
            return sn.consultaCUI(tabla);
        }
        public OdbcDataReader verificacionOrnato(string numero)
        {
            return sn.consultaOrnato(numero);
        }
        public OdbcDataReader verificacionBanco(string numero)
        {
            return sn.consultaBanco(numero);
        }

        public OdbcDataReader InsertarSolicitante(string CUI, string Nombre, string Apellido, string Nacionalidad, string Pais, string Sexo, string Fecha, string ornato, string banco)
        {
            return sn.InsertarSolicitante(CUI, Nombre, Apellido, Nacionalidad, Pais, Sexo, Fecha, ornato, banco);
        }

        public OdbcDataReader InsertarSolicitanteH(string CUI, string Nombre, string Apellido, string Nacionalidad, string Pais, string Sexo, string Fecha, string cui_padre,string cui_madre,string documento, string banco)
        {
            return sn.InsertarSolicitanteH(CUI, Nombre, Apellido, Nacionalidad, Pais, Sexo, Fecha, cui_padre,cui_madre, documento, banco);
        }

        public OdbcDataReader consultaCitas(string fecha)
        {
            return sn.consultaCitas(fecha);
        }

        public OdbcDataReader insertarTicket(string cui, string numcita,string fecha)
        {
            return sn.insertarTicket(cui, numcita, fecha);
        }
    }
}
