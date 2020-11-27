using System;

namespace es_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leggere numeri interi in input e stampare solo quelli che creano una sequenza crescente, con il numero zero l'algoritmo termina.");
            Console.WriteLine();

            bool x = false;
            int n;
            int max = 0;
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
                    if (max < n)
                    {
                        Console.WriteLine(n);
                        max = n;
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
