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
    }
}
