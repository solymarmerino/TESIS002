using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TESIS002.Conexion
{
    public class ConexionBD
    {
        //Parametros para la conexión hacia la bese de datos
        private string stringConexion = "data source = 192.168.56.101; initial catalog = VACARI; user id = sa; password = Tesis2018";
        
        public ConexionBD()
        {

        }

        public SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection(stringConexion);
            return conexion;
        }

        //Envia a ejecutar una consulta hacia la base de datos
        public DataTable Consultar(string sql)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);
            conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conexion);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            conexion.Close();
            return dataTable;
        }

        public void Insertar(SqlCommand sentenciaSQL)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);
            sentenciaSQL.Connection = conexion;
            conexion.Open();
            sentenciaSQL.ExecuteNonQuery();
        }

        public void Desconectar()
        {

        }
    }
}