using System;
using System.Collections.Generic;
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
            ListaPersonal.Add(new PersonalModel() { IdPersonal = "1111111111", NombrePersonal = "Administrador", TelefonoPersonal = "1111111111", CargoPersonal = "administrador" });
            ListaPersonal.Add(new PersonalModel() { IdPersonal = "2222222222", NombrePersonal = "Enfermera", TelefonoPersonal = "2222222222", CargoPersonal = "enfermera" });
            ListaPersonal.Add(new PersonalModel() { IdPersonal = "3333333333", NombrePersonal = "Laboratorista", TelefonoPersonal = "3333333333", CargoPersonal = "laboratorista" });
            ListaPersonal.Add(new PersonalModel() { IdPersonal = "4444444444", NombrePersonal = "Medico", TelefonoPersonal = "4444444444", CargoPersonal = "medico" });
            ListaPersonal.Add(new PersonalModel() { IdPersonal = "5555555555", NombrePersonal = "Recepcionista", TelefonoPersonal = "5555555555", CargoPersonal = "recepcionista" });
        }
        public List<PersonalModel> getListaPersonal()
        {
            return this.ListaPersonal;
        }

        public void addListaPersonal(PersonalModel empleado)
        {
            ListaPersonal.Add(empleado);
        }

    }
}