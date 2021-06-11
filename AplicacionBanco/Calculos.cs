using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBanco
{
    static class Calculos
    {
        public static int Calcular(Cliente[] array, string tipoCuenta)
        {
            int suma = 0;
            
            foreach(Cliente x in array)
            {
                if(x != null)
                {
                    if (x.CuentaCliente.TipoCuenta == tipoCuenta) 
                    suma++;
                }
            }
            return suma;
        }

        public static double Porcentaje(Cliente[] array)
        {
            int acumulador = 0;
            int total = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != null)
                {
                    total++;
                    if (array[i].Sexo == true)
                        acumulador++;
                }   
            }
            return (acumulador * 100 ) / total;
        }
    }
}
