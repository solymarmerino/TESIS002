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

        public Listas()
        {
           
        }

        public void addListaPersonal(PersonalModel empleado)
        {
            string rutaCompleta = @"D:\salida.txt";

            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
            {
                string texto = $"{empleado.NombrePersonal};{empleado.IdPersonal};{empleado.TelefonoPersonal};{empleado.CargoPersonal}";
                file.WriteLine(texto); 
                file.Close();
            }
        }

        public List<PersonalModel> getListaPersonal()
        {
            string rutacompleta = @"D:\salida.txt";
            string[] renglones = File.ReadAllLines(rutacompleta);

            try
            {
                foreach (var linea in renglones)
                {
                    PersonalModel personal = new PersonalModel();
                    string[] datos = linea.Split(';');
                    personal.NombrePersonal = datos[0];
                    personal.IdPersonal = datos[1];
                    personal.TelefonoPersonal = datos[2];
                    personal.CargoPersonal = datos[3];

                    this.ListaPersonal.Add(personal);
           
                }
                return this.ListaPersonal;
            }

            catch (Exception e)
            {
                return this.ListaPersonal;
            }
        }
    }
}