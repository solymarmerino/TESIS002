using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TESIS002.Models;

namespace TESIS002.Object
{
    public class Listas
    {
        List<PersonalModel> ListaPersonal = new List<PersonalModel>();
        List<ServicioPersonalModel> ListaServicioPersonal = new List<ServicioPersonalModel>();

		List<PacienteModel> ListaPaciente = new List<PacienteModel>();

        public Listas()
        {
           
        }

        public void addListaPersonal(PersonalModel empleado)
        {
            string rutaCompleta = @"E:\Personal.txt";

            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
            {
                string texto = $"{empleado.IdPersonal};{empleado.NombrePersonal};{empleado.CedulaPersonal};{empleado.TelefonoPersonal};{empleado.CargoPersonal};{empleado.UsuarioPersonal};{empleado.ContrasenaPersonal}";
                file.WriteLine(texto); 
                file.Close();
            }
        }

        public List<PersonalModel> getListaPersonal()
        {
            string rutacompleta = @"E:\Personal.txt";
            string[] renglones = File.ReadAllLines(rutacompleta);

            try
            {
                foreach (var linea in renglones)
                {
                    PersonalModel personal = new PersonalModel();
                    string[] datos = linea.Split(';');
                    personal.IdPersonal = datos[0];
                    personal.NombrePersonal = datos[1];
                    personal.CedulaPersonal = datos[2];
                    personal.TelefonoPersonal = datos[3];
                    personal.CargoPersonal = datos[4];
                    personal.UsuarioPersonal = datos[5];
                    personal.ContrasenaPersonal = datos[6];

                    this.ListaPersonal.Add(personal);
           
                }
                return this.ListaPersonal;
            }

            catch (Exception e)
            {
                return this.ListaPersonal;
            }
        }

        public PersonalModel searchPersonal(string idPersonal)
        {
            this.ListaPersonal = this.getListaPersonal();
            PersonalModel personalEncontrado = new PersonalModel();
            foreach (var personal in ListaPersonal)
            {
                if (personal.IdPersonal.Equals(idPersonal))
                {
                    personalEncontrado = personal;
                }
            }
            return personalEncontrado;
        }

        public PersonalModel searchPersonalCedula(string cedulaPersonal)
        {
            this.ListaPersonal = this.getListaPersonal();
            PersonalModel personalEncontrado = new PersonalModel();
            foreach (var personal in ListaPersonal)
            {
                if (personal.CedulaPersonal.Equals(cedulaPersonal))
                {
                    personalEncontrado = personal;
                }
            }
            return personalEncontrado;
        }

        public void modifyPersonal(PersonalModel empleado)
        {
            string rutacompleta = @"E:\Personal.txt";
            string[] renglones = File.ReadAllLines(rutacompleta);
            this.ListaPersonal = this.getListaPersonal();
            PersonalModel personalEncontrado = new PersonalModel();
            int cont = 0;
            foreach (var personal in ListaPersonal)
            {
                if (personal.IdPersonal.Equals(empleado.IdPersonal))
                {
                    renglones[cont] = $"{empleado.IdPersonal};{empleado.NombrePersonal};{empleado.CedulaPersonal};{empleado.TelefonoPersonal};{empleado.CargoPersonal};{empleado.UsuarioPersonal};{empleado.ContrasenaPersonal}";
                }
                cont++;
            }
            File.WriteAllLines(rutacompleta, renglones);
        }

        public int numberOfPersonal()
        {
            this.ListaPersonal = this.getListaPersonal();
            return this.ListaPersonal.Count();
        }

        public void addServicoPersonal(ServicioPersonalModel servicioPersonal)
        {
            string rutaCompleta = @"E:\ServicioPersonal.txt";

            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
            {
                string texto = $"{servicioPersonal.IdPersonal};{servicioPersonal.NombreServicio};{servicioPersonal.ValorServicio}";
                file.WriteLine(texto);
                file.Close();
            }
        }

        public List<ServicioPersonalModel> getListaServicoPersonal()
        {
            string rutacompleta = @"E:\ServicioPersonal.txt";
            string[] renglones = File.ReadAllLines(rutacompleta);

            try
            {
                foreach (var linea in renglones)
                {
                    ServicioPersonalModel servicoPersonal = new ServicioPersonalModel();
                    string[] datos = linea.Split(';');
                    servicoPersonal.IdPersonal = datos[0];
                    servicoPersonal.NombreServicio = datos[1];
                    servicoPersonal.ValorServicio = datos[2];

                    this.ListaServicioPersonal.Add(servicoPersonal);

                }
                return this.ListaServicioPersonal;
            }

            catch (Exception e)
            {
                return this.ListaServicioPersonal;
            }
        }

        public List<ServicioPersonalModel> getServicioPersonal(string idPersonal)
        {
            this.ListaServicioPersonal = this.getListaServicoPersonal();
            List<ServicioPersonalModel>  listaPersonal= new List<ServicioPersonalModel>();
            foreach (var servicioPersonal in ListaServicioPersonal)
            {
                if (servicioPersonal.IdPersonal.Equals(idPersonal))
                {
                    listaPersonal.Add(servicioPersonal);
                }
            }
            return listaPersonal;
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
				               $"{paciente.DirecciónPaciente};" +
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
					paciente.DirecciónPaciente = datos[4];
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

		public int numberOfPaciente()
		{
			this.ListaPaciente = this.getListaPaciente();
			return this.ListaPaciente.Count();
		}
	}
}