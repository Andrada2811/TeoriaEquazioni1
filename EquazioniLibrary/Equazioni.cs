using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        //Metodo per un'equazione determinata(1)
        public static bool IsDetermined (double a)
        {
            bool Risposta = false;

            if (a!=0)
            {
                Risposta = true;
            }

            

            return Risposta;
        }

        //Metodo per verificare se un'equazione è impossibile(2)
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

        //Metodo per un'equazione impossibile(2.2)
        public static bool IsIndetermined(double a, double b)
        {
            bool Risposta = false;

            if (a == 0 && b == 0)
            {
                Risposta = true;

            }

            else
            {
                Risposta = false;
            }

            return Risposta;
        }

        //Metodo per verificare se un'equazione è di secondo grado(3)
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

        //Metodo per calcolare il delta di un'equazione di 2 grado(4)
        public static double Delta (double a, double b, double c )
        {
            double Delta = 0;

            Delta = (b * b) - 4 * a * c;

            return Delta; 

        }

        //Metodo per risolvere un'equazione di 1 grado
        public static string EquationDegree1 (double a, double b)
        {
            string Messaggio = "";
            double Calcolo = 0;

            if (IsIndetermined(a,b))
            {
                Messaggio = "L'equazione è indeterminata";
            }

            else if (IsInconsisted(a,b))
            {
                Messaggio = "L'equazione è impossibile";
            }

            else
            {
                Calcolo = (b / a); 
            }

            Messaggio = Convert.ToString(Calcolo);
            
            return Messaggio;
        }
    }
}
