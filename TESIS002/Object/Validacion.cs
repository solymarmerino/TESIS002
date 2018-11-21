using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESIS002.Object
{
    public class Validacion
    {
        public Boolean ValidarCredencial (){
            Usuario user = new Usuario();

            return false;
        }

        public bool ValidarCedula(String cedula)
        {
            bool validado = false;
            int numeroCedula;            
            int total = 0;
            int[] coeficientes = {2,1,2,1,2,1,2,1,2};

            if(cedula.Length == 10 && int.TryParse(cedula, out numeroCedula))
            {
                int provincia = Convert.ToInt32(string.Concat(cedula[0], cedula[1],string.Empty));
                int digitoTres = Convert.ToInt32(string.Concat(cedula[2], string.Empty));
                if (provincia <= 24 && digitoTres <6)
                {
                    int digitoVerificador = Convert.ToInt32(string.Concat(cedula[9], string.Empty));
                    int multiplicacion=0;

                    for(int i = 0; i < coeficientes.Length; i++)
                    {
                        multiplicacion = coeficientes[i] * Convert.ToInt32(string.Concat(cedula[i], string.Empty));
                        if (multiplicacion > 9)
                        {
                            total += (multiplicacion - 9);
                        }
                        else
                        {
                            total += multiplicacion;
                        }
                    }
                    int resultado = 10 - (total % 10);
                    if (resultado == 10)
                    {
                        resultado = 0;
                    }
                    if(resultado == digitoVerificador)
                    {
                        validado = true;
                    }                                        
                }
            }
            return validado;
        }

        public bool ValidarTelefono(string telefono)
        {
            bool valido = false;
            int numeroTelefono;
            if (int.TryParse(telefono, out numeroTelefono) && (telefono.Length == 7 || telefono.Length == 9 || telefono.Length == 10))
            {
                if (telefono.Length == 7)
                {
                    valido = true;
                }

                if (telefono.Length == 9)
                {
                    if (telefono[0].Equals("0")){
                        valido = true;
                    }                    
                }

                if (telefono.Length == 10)
                {
                    if (telefono[0].Equals("0") && telefono[1].Equals("9") && (Convert.ToInt16(telefono[2]) > 2) )
                    {
                        valido = true;
                    }
                    
                }
                
            }
            return valido;
        }
    }
}