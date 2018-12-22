using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TESIS002.Conexion;
using TESIS002.Models;

namespace TESIS002.ConsultasBD
{
    public class DiagnosticoConsulta
    {
        ConexionBD conexion = new ConexionBD();

        public DiagnosticoConsulta()
        {

        }

        public void IngresarDiagnostico(DiagnosticoModel diagnostico)
        {
            string sql = "INSERT INTO DIAGNOSTICO ()" +
                         "VALUES () ";
            SqlCommand sentenciaSQL = new SqlCommand(sql);

            this.conexion.Insertar(sentenciaSQL);
        }
    }
}