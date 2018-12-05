using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TESIS002.Models;

namespace TESIS002.Object
{
	public class ListasCitas
	{
		List<CitaModel> listaCita = new List<CitaModel>();

		public ListasCitas()
		{

		}

		public void addCita(CitaModel cita)
		{
			string rutaCompleta = @"E:\Cita.txt";

			using (StreamWriter file = new StreamWriter(rutaCompleta, true))
			{
				string texto = $"{cita.IdCita};" +
							   $"{cita.IdPaciente};" +
							   $"{cita.Especialidad};" +
				               $"{cita.Medico};" +
				               $"{cita.TipoCita};" +
				               $"{cita.Pagado};" +
				               $"{cita.Enfermeria};" +
				               $"{cita.Atencion};" +
							   $"{cita.Facturado}";
				file.WriteLine(texto);
				file.Close();
			}
		}

		public List<CitaModel> getListaCita()
		{
			string rutacompleta = @"E:\Cita.txt";
			string[] renglones = File.ReadAllLines(rutacompleta);

			try
			{
				foreach (var linea in renglones)
				{
					CitaModel cita = new CitaModel();
					string[] datos = linea.Split(';');
					cita.IdCita = datos[0];
					cita.IdPaciente = datos[1];
					cita.Especialidad = datos[2];
					cita.Medico = datos[3];
					cita.TipoCita = datos[4];
                    cita.Pagado = datos[5];
                    cita.Enfermeria = datos[6];
                    cita.Atencion = datos[7];
                    cita.Facturado = datos[8];
					
					this.listaCita.Add(cita);

				}
				return this.listaCita;
			}

			catch (Exception e)
			{
				return this.listaCita;
			}
		}

        public List<CitaModel> getListaCitaConPaciente()
        {
            ListasPaciente listasPaciente = new ListasPaciente();
            string rutacompleta = @"E:\Cita.txt";
            string[] renglones = File.ReadAllLines(rutacompleta);

            try
            {
                foreach (var linea in renglones)
                {
                    CitaModel cita = new CitaModel();
                    string[] datos = linea.Split(';');
                    cita.IdCita = datos[0];
                    cita.IdPaciente = datos[1];
                    cita.Especialidad = datos[2];
                    cita.Medico = datos[3];
                    cita.TipoCita = datos[4];
                    cita.Pagado = datos[5];
                    cita.Enfermeria = datos[6];
                    cita.Atencion = datos[7];
                    cita.Facturado = datos[8];

                    cita.Paciente = listasPaciente.searchPaciente(datos[1]);

                    this.listaCita.Add(cita);

                }
                return this.listaCita;
            }

            catch (Exception e)
            {
                return this.listaCita;
            }
        }

        public List<CitaListaModel> getListaCitaPaciente(string idPaciente)
        {
            List<CitaListaModel> citasPaciente = new List<CitaListaModel>();
            this.listaCita.Clear();
            this.listaCita = this.getListaCita();

            foreach (var cita in listaCita)
            {
                if (cita.IdPaciente.Equals(idPaciente))
                {
                    CitaListaModel citaLista = new CitaListaModel();
                    citaLista.IdCita = cita.IdCita;
                    citaLista.IdPaciente = cita.IdPaciente;
                    citaLista.Especialidad = cita.Especialidad;
                    citaLista.Medico = cita.Medico;
                    citaLista.TipoCita = cita.TipoCita;

                    citasPaciente.Add(citaLista);
                }
            }
            return citasPaciente;
        }


        public int numberOfCita()
		{
            this.listaCita.Clear();
            this.listaCita = this.getListaCita();
			int numero = this.listaCita.Count() - 1;
			int siguienteId = 0;
            if(numero >= 0)
            {
                siguienteId = Int32.Parse(this.listaCita[numero].IdCita);
            }            
            return siguienteId;
		}

	}
}