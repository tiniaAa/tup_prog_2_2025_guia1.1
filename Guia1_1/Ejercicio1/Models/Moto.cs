using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Moto
    {
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public double ValorFabricacion { get; set; }




        public Moto (string marca,int modelo,double valorFabricacion)
        {
            Marca= marca;
            Modelo= modelo;
            ValorFabricacion= valorFabricacion;
        }
        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            int AñosUsos = añoACalcular -Modelo;
            //alternativa
            // double valorActualizado = valorFabricacion *añosUsos/vidaUtil
            double valorActualizado = ValorFabricacion - (ValorFabricacion * (añoACalcular - Modelo) / vidaUtil);//da negativo 
            return valorActualizado;
        }
        public double CalcularDepreciacionAnual(int añoACalcular,double tasaDepreciacion)
        {
            int AñosUsos = añoACalcular - Modelo;

            double valorActualizado = ValorFabricacion * (Math.Pow(1.0- tasaDepreciacion,AñosUsos));
           
            return valorActualizado;
        }
        public string VerDescripcion()
        {
            return$"Marca:{Marca}-Modelo:{Modelo}-Valor fabricación{ValorFabricacion}";
        }






    }
}
