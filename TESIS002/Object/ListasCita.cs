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
							   $"{cita.TipoCita}";
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