using System;

namespace es_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leggere numeri interi positivi in input e stampare solo quelli pari, l'algoritmo termina con lo zero.");
            Console.WriteLine();

            bool x = false;
            int n;
            do
            {
                do
                {
                    Console.Write("Inserisci un numero: ");
                    try
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Errore di inserimento");
                        n = -1;
                    }

                } while (n < 0);

                if (n != 0)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Il numero " + n + " è positivo");
                    }
                }
                else
                {
                    x = true;
                }


            } while (x == false);

            Console.WriteLine("Goodbye");
        }
    }
}
