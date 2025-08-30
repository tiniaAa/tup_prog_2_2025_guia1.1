using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class Peaje
    {
      
        public double PromCantVehiculosDelMes 
        { 
            get 
            {
                double prom=0;

                for (int n=0; n<31;n++) 
                
                    prom = +cantidades[n];

                return prom/31;
            } 
        }


        int [] cantidades  = new int [31];

        public void RegistrarResumenDia(int dia, int cantidadVehiculos)
        {
            if (dia >= 1 && dia <=31)
                cantidades[dia-1]=cantidadVehiculos;
        }
        public int VerCantidadAutosEnUnDia(int dia)
        {

            int cantidad = cantidades[dia-1];

            return cantidad;
        }
        public int[] CalcularLosDiasMayoresAlPromedio(out int cantDias)
        {
            cantDias = 0;
            double promedio = PromCantVehiculosDelMes;
            int[] diasMay = new int [31];

            for (int n =0;n<31;n++)
            {
                if (cantidades[n]>promedio)
                {
                    diasMay[cantDias] = n + 1;
                    cantDias++;
                }



            }
            return diasMay;
        }
        public int CalcularTercioDelMesMayor()
        {
            int[] periodos = new int [3];
            for (int n =0;n<31;n++)
            {
                if (n < 10) periodos[0] += cantidades[n];
                else if (n < 20) periodos[1] += cantidades[n];
                else periodos[2] += cantidades[n];


            }

            int m = 0;
            for (int n=1;n<3;n++)
            {
                if (periodos[m] <periodos[n])
                {
                    m = n;
                }
            }


            return m+1;
        }

    }
}
