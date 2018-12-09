using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TESIS002.Models;

namespace TESIS002.Object
{
	public class ListasEnfermeria
	{
		List<SignoVital> listaSignoVital = new List<SignoVital>();

		public ListasEnfermeria()
		{

		}

        public void addSignoVital(SignoVital signo)
		{
			string rutaCompleta = @"E:\SignosVitales.txt";

			using (StreamWriter file = new StreamWriter(rutaCompleta, true))
			{
				string texto = $"{signo.IdSignoVital};" +
							   $"{signo.IdHistoriaClinica};" +
							   $"{signo.Temperatura};" +
				               $"{signo.PrecionArterial};" +
				               $"{signo.Fr};" +
				               $"{signo.Fc};" +
				               $"{signo.Peso};" +
							   $"{signo.Talla}";
				file.WriteLine(texto);
				file.Close();
			}
		}

        public List<SignoVital> getListaSignoVital()
        {
            string rutacompleta = @"E:\SignosVitales.txt";
            string[] renglones = File.ReadAllLines(rutacompleta);

            try
            {
                foreach (var linea in renglones)
                {
                    SignoVital signo = new SignoVital();
                    string[] datos = linea.Split(';');
                    signo.IdSignoVital = datos[0];
                    signo.IdHistoriaClinica = datos[1];
                    signo.Temperatura = datos[2];
                    signo.PrecionArterial = datos[3];
                    signo.Fr = datos[4];
                    signo.Fc = datos[5];
                    signo.Peso = datos[6];
                    signo.Talla = datos[7];

                    this.listaSignoVital.Add(signo);

                }
                return this.listaSignoVital;
            }

            catch (Exception e)
            {
                return this.listaSignoVital;
            }
        }

        public int numberOfSigno()
        {
            this.listaSignoVital.Clear();
            this.listaSignoVital = this.getListaSignoVital();
            int numero = this.listaSignoVital.Count() - 1;
            int siguienteId = 0;
            if (numero >= 0)
            {
                siguienteId = Int32.Parse(this.listaSignoVital[numero].IdSignoVital);
            }
            return siguienteId;
        }

    }
}