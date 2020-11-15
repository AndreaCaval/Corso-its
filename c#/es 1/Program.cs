using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

//<
//>

namespace es_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                selectEs();

                Console.WriteLine("Vuoi continuare: 0(NO) / 1(YES): ");

                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch { }

                if (x != 0 && x != 1) { x = 0; }

            } while (x == 1);
        }

        static void selectEs()
        {
            bool input = false;
            do
            {
                Console.WriteLine("[1] Dati 3 numeri in input, scrivere in output il tre dei maggiori");
                Console.WriteLine("[2] Dati N numeri in input, scrivere in output il maggiore");
                Console.WriteLine("[3] Dati N numeri in input, scrivere in output il maggiore e la sua posizione");
                Console.Write("Scelta: ");
                int selection = Convert.ToInt32(Console.ReadLine());
                if (selection == 1)
                {
                    input = true;
                    esercizio1();
                }
                else if (selection == 2)
                {
                    input = true;
                    esercizio2();
                }
                else if (selection == 3)
                {
                    input = true;
                    esercizio3();
                }
                if (input == false)
                {
                    Console.WriteLine("error retry");
                }


            } while (input == false);
        }

        static void esercizio1()
        {
            int max = 0; int numero1 = 0; int numero2 = 0; int numero3 = 0;
            Console.WriteLine("Inserisci 3 numeri: (es: 1/2/3)");
            string numeri = Console.ReadLine();
            try
            {
                numero1 = Convert.ToInt32(numeri.Split('/')[0]);
                numero2 = Convert.ToInt32(numeri.Split('/')[1]);
                numero3 = Convert.ToInt32(numeri.Split('/')[2]);
            }
            catch { }

            if (numero1 >= numero2 && numero1 >= numero3)
            {
                max = numero1;
            }

            if (numero2 >= numero1 && numero2 >= numero3)
            {
                max = numero2;
            }

            if (numero3 >= numero1 && numero3 >= numero2)
            {
                max = numero3;
            }

            Console.WriteLine("Numero maggiore= " + max);
        }

        static void esercizio2()
        {
            int max = 0;
            Console.WriteLine("Inserisci n numeri: (es: 1/2/3/5..)");
            string numeri = Console.ReadLine();
            int count_numeri = numeri.Split('/').Length;

            for (int i = 0; i < count_numeri; i++)
            {
                try
                {
                    if (max < Convert.ToInt32(numeri.Split('/')[i]))
                    {
                        max = Convert.ToInt32(numeri.Split('/')[i]);
                    }
                }
                catch { }
            }

            Console.WriteLine("Numero maggiore= " + max);
        }

        static void esercizio3()
        {
            int max = 0; int position = 0;
            Console.WriteLine("Inserisci n numeri: (es: 1/2/3/5..)");
            string numeri = Console.ReadLine();
            int count_numeri = numeri.Split('/').Length;

            for (int i = 0; i < count_numeri; i++)
            {
                try
                {
                    if (max < Convert.ToInt32(numeri.Split('/')[i]))
                    {
                        max = Convert.ToInt32(numeri.Split('/')[i]);
                        position = i;
                    }
                }
                catch { }
            }

            Console.WriteLine("Numero maggiore= " + max + ", Posizione=" + position);
        }
    }
}
