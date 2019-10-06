using System;

namespace CalcolaMetà_int_n_
{
    public class Calcola_metà
    {
        public static int Meta(int n)
        {
            int a = n % 2;
            if(a>0)
            {
                throw new Exception("il risultato è un numero deimale");
            }
            return a;
        }

    }
}
