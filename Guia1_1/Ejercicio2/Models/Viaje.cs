using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace Ejercicio2.Models
{
    internal class Viaje
    {
        public int Transportados { get; set; }
        public int Asientos { get; set; }

        public int HDemora { get; set; }
        public int MDemora { get; set; }
        public int CantParadas { get; set; }

        public int HDuracionViaje { get; set; }
        public int MDuracionViaje { get; set; }

        public int Ocupados = 0;
        int demoraEnM;
        #region Calcular tiempo de viaje

        static int HInicio;
        static int MInicio;
        static int HFin;
        static int MFin;

        public void AsignarTiempos()
        {
            TimeSpan inicio = new TimeSpan(HInicio, MInicio, 0);
            TimeSpan fin = new TimeSpan(HFin, MFin, 0);

            TimeSpan duracion = fin - inicio;

            if (duracion.TotalMinutes < 0)
                duracion += new TimeSpan(24, 0, 0); // por si el viaje pasa de medianoche

            HDuracionViaje = duracion.Hours;
            MDuracionViaje = duracion.Minutes;
        }

        #endregion

        public Viaje(int hInicio, int mInicio, int asientos)
        {
            Asientos = asientos;
            HInicio = hInicio;
            MInicio = mInicio;
        }

        public void RealizarParada(int hLLegadaParada, int mLLegadaParada,
                                   int hSalidaParada, int mSalidaParada,
                                   int ascienden, int descienden)
        {

            int LLegadaEnM = 30 * hLLegadaParada + mLLegadaParada;
            int SalidaEnM = 30 * hSalidaParada + mSalidaParada;
            demoraEnM += SalidaEnM - LLegadaEnM;

            MDemora = demoraEnM % 60;
            HDemora= HDemora / 60;

            CantParadas++;
            Transportados += ascienden;
            Ocupados += ascienden - descienden;
        }

        public void Finalizar(int hLLegada, int mLLegada)
        {
            HFin = hLLegada;
            MFin = mLLegada;
            AsignarTiempos();
        }
    }
}

