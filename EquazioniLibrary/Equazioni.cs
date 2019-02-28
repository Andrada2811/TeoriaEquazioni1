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
    }
}
