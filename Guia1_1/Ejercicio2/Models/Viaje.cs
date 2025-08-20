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
        #region Calcular tiempo de viaje

        static int HInicio;
        static int MInicio;
        static int HFin;
        static int MFin;

        
        

        static TimeSpan InicioViaje = new TimeSpan( HInicio, MInicio, 0);
        static TimeSpan FinViaje = new TimeSpan( HFin, MFin, 0);

        

        public void AsignarTiempos()
        {
            TimeSpan Duracion = FinViaje-InicioViaje;
            HDuracionViaje = Duracion.Hours;
            MDuracionViaje = Duracion.Minutes;
        }

        #endregion


        public Viaje(int hInicio,int mInicio, int asientos)
        {
            Asientos = asientos;
            HInicio = hInicio;
            MInicio = mInicio;
            
        }
        
        public void RealizarParada(int hLLegadaParada, int mLLegadaParada,int hSalidaParada,int mSalidaParada, int ascienden, int decienden)
        {



            int llegadaMin = (60 * hLLegadaParada) + mLLegadaParada;
            int salidaMin = (60 * hSalidaParada) + mSalidaParada;

            int demoraTotal = salidaMin - llegadaMin;

            
            HDemora += demoraTotal / 60;
            MDemora += demoraTotal % 60;

            

            CantParadas++;
            Transportados+=ascienden;

            Ocupados+= ascienden-decienden;

        }
        public void Finalizar(int hLLegada, int mLLegada)
        {
            HFin= hLLegada;
            MFin= mLLegada;
            AsignarTiempos();
        }
       







    }
}
