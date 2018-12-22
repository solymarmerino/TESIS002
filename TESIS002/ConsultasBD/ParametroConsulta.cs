using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TESIS002.Conexion;
using TESIS002.Models;

namespace TESIS002.ConsultasBD
{
    public class ParametroConsulta
    {
        ConexionBD conexion = new Conexion.ConexionBD();
        public ParametroConsulta()
        {

        }

        public List<ParametroModel> comboBoxGenero()
        {
            List<ParametroModel> listaComboBoxEnviar = new List<ParametroModel>();

            string sql = "select idParametro,valorParametro " +
                         "from Parametro " +
                         "where tipoParametro like 'genero'";

            DataTable datos = this.conexion.Consultar(sql);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                ParametroModel parametroEnviar = new ParametroModel();
                parametroEnviar.idParametro = datos.Rows[i].Field<int>("idParametro");
                parametroEnviar.valorParametro = datos.Rows[i].Field<string>("valorParametro");

                listaComboBoxEnviar.Add(parametroEnviar);
            }

            return listaComboBoxEnviar;
        }

        public List<ParametroModel> comboBoxEstadoCivil()
        {
            List<ParametroModel> listaComboBoxEnviar = new List<ParametroModel>();

            string sql = "select idParametro,valorParametro " +
                         "from Parametro " +
                         "where tipoParametro like 'estado civil'";

            DataTable datos = this.conexion.Consultar(sql);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                ParametroModel parametroEnviar = new ParametroModel();
                parametroEnviar.idParametro = datos.Rows[i].Field<int>("idParametro");
                parametroEnviar.valorParametro = datos.Rows[i].Field<string>("valorParametro").Replace("_"," ");

                listaComboBoxEnviar.Add(parametroEnviar);
            }

            return listaComboBoxEnviar;
        }

        public List<ParametroModel> comboBoxTipoSangre()
        {
            List<ParametroModel> listaComboBoxEnviar = new List<ParametroModel>();

            string sql = "select idParametro,valorParametro " +
                         "from Parametro " +
                         "where tipoParametro like 'tipo sangre'";

            DataTable datos = this.conexion.Consultar(sql);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                ParametroModel parametroEnviar = new ParametroModel();
                parametroEnviar.idParametro = datos.Rows[i].Field<int>("idParametro");
                parametroEnviar.valorParametro = datos.Rows[i].Field<string>("valorParametro").Replace("_", " ");

                listaComboBoxEnviar.Add(parametroEnviar);
            }

            return listaComboBoxEnviar;
        }
    }
}