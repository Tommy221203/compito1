using CalcolaMetà_int_n_;
using System;


namespace soluzione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il numero");
            int a = int.Parse(Console.ReadLine());
            double risultato = Calcola_metà.Meta(a);
            Console.WriteLine($"il risultato è {a}");
            Console.ReadLine();
        }
    }
}
