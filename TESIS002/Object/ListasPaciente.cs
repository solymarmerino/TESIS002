using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TESIS002.Models;

namespace TESIS002.Object
{
	public class ListasPaciente
	{
		List<PacienteModel> ListaPaciente = new List<PacienteModel>();

		public ListasPaciente()
		{

		}

		public void addListaPaciente(PacienteModel paciente)
		{
			string rutaCompleta = @"E:\Paciente.txt";

			using (StreamWriter file = new StreamWriter(rutaCompleta, true))
			{
				string texto = $"{paciente.IdPaciente};" +
							   $"{paciente.HistoriaClinicaPaciente};" +
							   $"{paciente.NombrePaciente};" +
				               $"{paciente.CedulaPaciente};" +
							   $"{paciente.DireccionPaciente};" +
							   $"{paciente.TelefonoPaciente};" +
				               $"{paciente.FechaNacimientoPaciente};" +
				               $"{paciente.GeneroPaciente};" +
							   $"{paciente.EstadoCivilPaciente};" +
							   $"{paciente.TipoSangrePaciente};" +
							   $"{paciente.NombreContactoEmergenciaPaciente};" +
							   $"{paciente.AfinidadContactoEmergenciaPaciente};" +
							   $"{paciente.TelefonoContatoEmergenciaPaciente};" +
							   $"{paciente.AntecedentesPaciente}";
				file.WriteLine(texto);
				file.Close();
			}
		}

		public List<PacienteModel> getListaPaciente()
		{
			string rutacompleta = @"E:\Paciente.txt";
			string[] renglones = File.ReadAllLines(rutacompleta);

			try
			{
				foreach (var linea in renglones)
				{
					PacienteModel paciente = new PacienteModel();
					string[] datos = linea.Split(';');
					paciente.IdPaciente = datos[0];
					paciente.HistoriaClinicaPaciente = datos[1];
					paciente.NombrePaciente = datos[2];
					paciente.CedulaPaciente = datos[3];
					paciente.DireccionPaciente = datos[4];
					paciente.TelefonoPaciente = datos[5];
					paciente.FechaNacimientoPaciente = datos[6];
					paciente.GeneroPaciente = datos[7];
					paciente.EstadoCivilPaciente = datos[8];
					paciente.TipoSangrePaciente = datos[9];
					paciente.NombreContactoEmergenciaPaciente = datos[10];
					paciente.AfinidadContactoEmergenciaPaciente = datos[11];
					paciente.TelefonoContatoEmergenciaPaciente = datos[12];
					paciente.AntecedentesPaciente = datos[13];
					
					this.ListaPaciente.Add(paciente);

				}
				return this.ListaPaciente;
			}

			catch (Exception e)
			{
				return this.ListaPaciente;
			}
		}

		public PacienteModel searchPaciente(string idPaciente)
		{
			this.ListaPaciente = this.getListaPaciente();
			PacienteModel pacienteEncontrado = new PacienteModel();
			foreach (var paciente in ListaPaciente)
			{
				if (paciente.IdPaciente.Equals(idPaciente))
				{
					pacienteEncontrado = paciente;
				}
			}
			return pacienteEncontrado;
		}

		public PacienteModel buscarPacienteNombre(string nombrePaciente)
		{
			this.ListaPaciente = this.getListaPaciente();
			PacienteModel pacienteEncontrado = new PacienteModel();
			foreach (var paciente in ListaPaciente)
			{
				if (paciente.NombrePaciente.Equals(nombrePaciente))
				{
					pacienteEncontrado = paciente;
				}
			}
			return pacienteEncontrado;
		}

		public PacienteModel buscarPacienteHCPaciente(string historiaClinicaPaciente)
		{
			this.ListaPaciente = this.getListaPaciente();
			PacienteModel pacienteEncontrado = new PacienteModel();
			foreach (var paciente in ListaPaciente)
			{
				if (paciente.HistoriaClinicaPaciente.Equals(historiaClinicaPaciente))
				{
					pacienteEncontrado = paciente;
				}
			}
			return pacienteEncontrado;
		}

		public PacienteModel searchPacienteCedula(string cedulaPaciente)
		{
			this.ListaPaciente = this.getListaPaciente();
			PacienteModel pacienteEncontrado = new PacienteModel();
			foreach (var paciente in ListaPaciente)
			{
				if (paciente.CedulaPaciente.Equals(cedulaPaciente))
				{
					pacienteEncontrado = paciente;
				}
			}
			return pacienteEncontrado;
		}

		public void modificarPaciente(PacienteModel paciente)
		{
			string rutacompleta = @"E:\Paciente.txt";
			string[] renglones = File.ReadAllLines(rutacompleta);
			this.ListaPaciente = this.getListaPaciente();
			PacienteModel pacienteEncontrado = new PacienteModel();
			int cont = 0;
			foreach (var persona in ListaPaciente)
			{
				if (persona.IdPaciente.Equals(paciente.IdPaciente))
				{
					renglones[cont] = $"{paciente.IdPaciente};" +
							   $"{paciente.HistoriaClinicaPaciente};" +
							   $"{paciente.NombrePaciente};" +
							   $"{paciente.CedulaPaciente};" +
							   $"{paciente.DireccionPaciente};" +
							   $"{paciente.TelefonoPaciente};" +
							   $"{paciente.FechaNacimientoPaciente};" +
							   $"{paciente.GeneroPaciente};" +
							   $"{paciente.EstadoCivilPaciente};" +
							   $"{paciente.TipoSangrePaciente};" +
							   $"{paciente.NombreContactoEmergenciaPaciente};" +
							   $"{paciente.AfinidadContactoEmergenciaPaciente};" +
							   $"{paciente.TelefonoContatoEmergenciaPaciente};" +
							   $"{paciente.AntecedentesPaciente}";
				}
				cont++;
			}
			File.WriteAllLines(rutacompleta, renglones);
		}

		public int numberOfPaciente()
		{
			this.ListaPaciente = this.getListaPaciente();
			int numero = this.ListaPaciente.Count() - 1;
			int siguienteId = Int32.Parse(this.ListaPaciente[numero].IdPaciente);
			return siguienteId;
		}

	}
}