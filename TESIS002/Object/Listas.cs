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

        public PersonalModel searchPersonalUsuario(string usuarioPersonal)
        {
            this.ListaPersonal = this.getListaPersonal();
            PersonalModel personalEncontrado = new PersonalModel();
            foreach (var personal in ListaPersonal)
            {
                if (personal.UsuarioPersonal.Equals(usuarioPersonal))
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
            int numero = this.ListaPersonal.Count() - 1;
            int siguienteId = Int32.Parse(this.ListaPersonal[numero].IdPersonal);
            return siguienteId;
        }

        public void addServicoPersonal(ServicioPersonalModel servicioPersonal)
        {
            string rutaCompleta = @"E:\ServicioPersonal.txt";
            int siguienteId = this.numberOfServicioPersonal();
            servicioPersonal.IdPersonalServicio = siguienteId.ToString();
            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
            {
                string texto = $"{servicioPersonal.IdPersonalServicio};{servicioPersonal.IdPersonal};{servicioPersonal.NombreServicio};{servicioPersonal.ValorServicio}";
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
                    servicoPersonal.IdPersonalServicio = datos[0];
                    servicoPersonal.IdPersonal = datos[1];
                    servicoPersonal.NombreServicio = datos[2];
                    servicoPersonal.ValorServicio = datos[3];

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

        public ServicioPersonalModel getAServicioPersonal(string idServicePersonal)
        {
            this.ListaServicioPersonal = this.getListaServicoPersonal();
            ServicioPersonalModel aServicePersonal = new ServicioPersonalModel();
            foreach (var servicioPersonal in ListaServicioPersonal)
            {
                if (servicioPersonal.IdPersonalServicio.Equals(idServicePersonal))
                {
                    aServicePersonal = servicioPersonal;
                }
            }
            return aServicePersonal;
        }

        public void deleteServicioPersonal(string idServicioPersonal)
        {
            ServicioPersonalModel aServicePersonal = this.getAServicioPersonal(idServicioPersonal);
            this.ListaServicioPersonal = this.getListaServicoPersonal();

            this.ListaServicioPersonal.Remove(aServicePersonal);

            string rutaCompleta = @"E:\ServicioPersonal.txt";
            File.Delete(rutaCompleta);

            StreamWriter file = new StreamWriter(rutaCompleta, true);
            
            foreach (var servicioPersonal in ListaServicioPersonal)
            {
                string texto = $"{servicioPersonal.IdPersonalServicio};{servicioPersonal.IdPersonal};{servicioPersonal.NombreServicio};{servicioPersonal.ValorServicio}";
                file.WriteLine(texto);
            }
            file.Close();        
        }
        public int numberOfServicioPersonal()
        {
            this.ListaServicioPersonal = this.getListaServicoPersonal();
            int numero = this.ListaServicioPersonal.Count()-1;
            int siguienteId = Int32.Parse(this.ListaServicioPersonal[numero].IdPersonalServicio)+1;
            return siguienteId;
        }
    }
}