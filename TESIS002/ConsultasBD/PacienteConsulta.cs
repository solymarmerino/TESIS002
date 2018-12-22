using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TESIS002.Conexion;
using TESIS002.Models;

namespace TESIS002.ConsultasBD
{
    public class PacienteConsulta
    {
        //Conexion hacia la base de datos
        ConexionBD conexion = new ConexionBD();
        public PacienteConsulta()
        {

        }

        //Devuelve una lista con los pacientes 
        public List<PacienteModelBK> listaPaciente()
        {
            List<PacienteModelBK> listaPacienteEnviar = new List<PacienteModelBK>();
            
            //string sql = "select * from Paciente";
            string sql = "select idPaciente, HistoriaClinica, Nombre, Cedula from Paciente";

            DataTable datos = this.conexion.Consultar(sql);

            for(int i=0; i < datos.Rows.Count; i++)
            {
                PacienteModelBK paciente = new PacienteModelBK();
                paciente.IdPaciente = datos.Rows[i].Field<int>("idPaciente");
                paciente.HistoriaClinicaPaciente = datos.Rows[i].Field<int>("HistoriaClinica");
                paciente.NombrePaciente = datos.Rows[i].Field<string>("Nombre");
                paciente.CedulaPaciente = datos.Rows[i].Field<string>("Cedula");
                /*paciente.DireccionPaciente = datos.Rows[i].Field<string>("Direccion");
                paciente.TelefonoPaciente = datos.Rows[i].Field<string>("Telefono");
                paciente.FechaNacimientoPaciente = datos.Rows[i].Field<DateTime>("FechaNacimiento").ToString();
                paciente.GeneroPaciente = datos.Rows[i].Field<string>("Genero");
                paciente.EstadoCivilPaciente = datos.Rows[i].Field<string>("EstadoCivil");
                paciente.TipoSangrePaciente = datos.Rows[i].Field<string>("TipoDeSangre");
                paciente.NombreContactoEmergenciaPaciente = datos.Rows[i].Field<string>("NombreContactoEmergencia");
                paciente.AfinidadContactoEmergenciaPaciente = datos.Rows[i].Field<string>("TelefonoContactoEmergencia");
                paciente.AntecedentesPaciente = datos.Rows[i].Field<string>("Antecedentes");*/

                listaPacienteEnviar.Add(paciente);
            }

            return listaPacienteEnviar;
        }

        public PacienteModelBK obtenerPaciente(string idPaciente)
        {
            PacienteModelBK pacienteEnviar = new PacienteModelBK();
            
            string sql = "select idPaciente, HistoriaClinica, Nombre, Cedula, Direccion, Telefono, FechaNacimiento, Genero, EstadoCivil, TipoDeSangre, NombreContactoEmergencia, AfinidadContactoEmergencia, TelefonoContactoEmergencia, Antecedentes " +
                         $"from Paciente where idPaciente = {int.Parse(idPaciente)}";
            DataTable datos = this.conexion.Consultar(sql);

            pacienteEnviar.IdPaciente = datos.Rows[0].Field<int>("idPaciente");
            pacienteEnviar.HistoriaClinicaPaciente = datos.Rows[0].Field<int>("HistoriaClinica");
            pacienteEnviar.NombrePaciente = datos.Rows[0].Field<string>("Nombre");
            pacienteEnviar.CedulaPaciente = datos.Rows[0].Field<string>("Cedula");
            pacienteEnviar.DireccionPaciente = datos.Rows[0].Field<string>("Direccion");
            pacienteEnviar.TelefonoPaciente = datos.Rows[0].Field<string>("Telefono");
            pacienteEnviar.FechaNacimientoPaciente = datos.Rows[0].Field<DateTime>("FechaNacimiento");
            pacienteEnviar.GeneroPaciente = datos.Rows[0].Field<int>("Genero");
            pacienteEnviar.EstadoCivilPaciente = datos.Rows[0].Field<int>("EstadoCivil");
            pacienteEnviar.TipoSangrePaciente = datos.Rows[0].Field<int>("TipoDeSangre");
            pacienteEnviar.NombreContactoEmergenciaPaciente = datos.Rows[0].Field<string>("NombreContactoEmergencia");
            pacienteEnviar.AfinidadContactoEmergenciaPaciente = datos.Rows[0].Field<string>("AfinidadContactoEmergencia");
            pacienteEnviar.TelefonoContatoEmergenciaPaciente = datos.Rows[0].Field<string>("TelefonoContactoEmergencia");
            pacienteEnviar.AntecedentesPaciente = datos.Rows[0].Field<string>("Antecedentes");

            return pacienteEnviar;
        }

        public PacienteModelBK obtenerPacientePorCedula(string cedula)
        {
            PacienteModelBK pacienteEnviar = new PacienteModelBK();

            string sql = "select idPaciente, HistoriaClinica, Nombre, Cedula, Direccion, Telefono, FechaNacimiento, Genero, EstadoCivil, TipoDeSangre, NombreContactoEmergencia, AfinidadContactoEmergencia, TelefonoContactoEmergencia, Antecedentes " +
                         $"from Paciente where Cedula like '{int.Parse(cedula)}' "+
                         "Limit 0,1";
            DataTable datos = this.conexion.Consultar(sql);

            pacienteEnviar.IdPaciente = datos.Rows[0].Field<int>("idPaciente");
            pacienteEnviar.HistoriaClinicaPaciente = datos.Rows[0].Field<int>("HistoriaClinica");
            pacienteEnviar.NombrePaciente = datos.Rows[0].Field<string>("Nombre");
            pacienteEnviar.CedulaPaciente = datos.Rows[0].Field<string>("Cedula");
            pacienteEnviar.DireccionPaciente = datos.Rows[0].Field<string>("Direccion");
            pacienteEnviar.TelefonoPaciente = datos.Rows[0].Field<string>("Telefono");
            pacienteEnviar.FechaNacimientoPaciente = datos.Rows[0].Field<DateTime>("FechaNacimiento");
            pacienteEnviar.GeneroPaciente = datos.Rows[0].Field<int>("Genero");
            pacienteEnviar.EstadoCivilPaciente = datos.Rows[0].Field<int>("EstadoCivil");
            pacienteEnviar.TipoSangrePaciente = datos.Rows[0].Field<int>("TipoDeSangre");
            pacienteEnviar.NombreContactoEmergenciaPaciente = datos.Rows[0].Field<string>("NombreContactoEmergencia");
            pacienteEnviar.AfinidadContactoEmergenciaPaciente = datos.Rows[0].Field<string>("AfinidadContactoEmergencia");
            pacienteEnviar.TelefonoContatoEmergenciaPaciente = datos.Rows[0].Field<string>("TelefonoContactoEmergencia");
            pacienteEnviar.AntecedentesPaciente = datos.Rows[0].Field<string>("Antecedentes");

            return pacienteEnviar;
        }

        public void ingresarPaciente(PacienteModelBK paciente)
        {
            string sql = "INSERT INTO PACIENTE (HistoriaClinica, Nombre, Cedula, Direccion, Telefono, FechaNacimiento, Genero, EstadoCivil, TipoDeSangre, NombreContactoEmergencia, AfinidadContactoEmergencia, TelefonoContactoEmergencia, Antecedentes) " +
                         "VALUES (@HistoriaClinica, @Nombre, @Cedula, @Direccion, @Telefono, @FechaNacimiento, @Genero, @EstadoCivil, @TipoDeSangre, @NombreContactoEmergencia, @AfinidadContactoEmergencia, @TelefonoContactoEmergencia, @Antecedentes)";
            SqlCommand sentenciaSQL = new SqlCommand(sql);

            sentenciaSQL.Parameters.AddWithValue("@HistoriaClinica",paciente.HistoriaClinicaPaciente);
            sentenciaSQL.Parameters.AddWithValue("@Nombre", paciente.NombrePaciente);
            sentenciaSQL.Parameters.AddWithValue("@Cedula", paciente.CedulaPaciente);
            sentenciaSQL.Parameters.AddWithValue("@Direccion", paciente.DireccionPaciente);
            sentenciaSQL.Parameters.AddWithValue("@Telefono", paciente.TelefonoPaciente);
            sentenciaSQL.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimientoPaciente);
            sentenciaSQL.Parameters.AddWithValue("@Genero", paciente.GeneroPaciente);
            sentenciaSQL.Parameters.AddWithValue("@EstadoCivil", paciente.EstadoCivilPaciente);
            sentenciaSQL.Parameters.AddWithValue("@TipoDeSangre", paciente.TipoSangrePaciente);
            sentenciaSQL.Parameters.AddWithValue("@NombreContactoEmergencia", paciente.NombreContactoEmergenciaPaciente);
            sentenciaSQL.Parameters.AddWithValue("@AfinidadContactoEmergencia", paciente.AfinidadContactoEmergenciaPaciente);
            sentenciaSQL.Parameters.AddWithValue("@TelefonoContactoEmergencia", paciente.TelefonoContatoEmergenciaPaciente);
            sentenciaSQL.Parameters.AddWithValue("@Antecedentes", paciente.AntecedentesPaciente);

            this.conexion.Insertar(sentenciaSQL);

        }

    }
}