using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        //Metodo per un'equazione determinata
        public static bool IsDetermined (double a)
        {
            bool Risposta = false;

            if (a!=0)
            {
                Risposta = true;
            }

            else
            {
                Risposta = false;
            }



            return Risposta;
        }

        //Metodo per un'equazione impossibile
        public static bool IsInconsisted (double a, double b)
        {
            bool Risposta = false;

            if (a==0 || b!=0)
            {
                Risposta = true;

            }

            else
            {
                Risposta = false;
            }

            return Risposta;
        }

        //Metodo per un'equazione di secondo grado
        public static bool IsDegree2 (double a)
        {
            bool Risposta = false;

            if (a != 0)
            {
                Risposta = true;
            }

            else
            {
                Risposta = false;
            }


            return Risposta;
        }
    }
}
