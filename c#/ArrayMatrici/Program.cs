using System;
using System.Security.Cryptography.X509Certificates;

namespace ArrayMatrici
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = false;
            int scelta = 0;
            Console.WriteLine("1. Dati in input i numeri interi positivi N e P, crea un array chiamato NUMERI di lunghezza N e riempilo con i primi N numeri pari partendo da P compreso, a crescere.Stampa l'array così ottenuto su un'unica riga.");
            Console.WriteLine("2. Stampare la media dei valori contenuti in NUMERI, il valore massimo e la sua posizione, il valore minimo e la sua posizione.");
            Console.WriteLine("3. Creare l'array NUMERI_INVERSI e riempirlo in modo che contenga gli stessi valori di NUMERI ma al contrario.Stampare NUMERI_INVERSI.");
            Console.WriteLine("4. Creare l'array NUMERI_DISPARI e riempirlo in modo che contenga la sequenza di dispari complementare di NUMERI.Stampare NUMERI_DISPARI.");
            Console.WriteLine("5. Crea l'array NUMERI2 in modo che contenga i valori NUMERI moltiplicati per 2. Stampare NUMERI2.");
            Console.WriteLine("6. Crea la matrice quadrata M di dimensione D in modo che contenga valori casuali compresi tra 0 e 50.Stampa la matrice.");
            Console.WriteLine("7. Stampare il risultato della somma di tutti i valori contenuti in M.");
            Console.WriteLine("8. Stampare il valore minimo presente in M e in quali coordinate si trova.");
            Console.WriteLine("9. Creare la matrice M2 come la trasposta di M. Stampare M2.");
            Console.WriteLine("10. Data in input la dimensione della matrice quadrata I, creare e stampare la matrice identità.");
            Console.WriteLine("");
            do
            {
                try
                {
                    Console.Write("Scegliere un esercizio: ");
                    scelta = int.Parse(Console.ReadLine());
                    x = true;
                    if (scelta < 0 || scelta > 10)
                    {
                        Console.WriteLine("Errore inerimento scelta.\n");
                        x = false;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Errore inerimento scelta.\n");
                }

            } while (x == false);

            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Esercizio 1:\n");
                    esercizio1();
                    break;
                case 2:
                    Console.WriteLine("Esercizio 2:\n");
                    esercizio2();
                    break;
                case 3:
                    Console.WriteLine("Esercizio 3:\n");
                    esercizio3();
                    break;
                case 4:
                    Console.WriteLine("Esercizio 4:\n");
                    esercizio4();
                    break;
                case 5:
                    Console.WriteLine("Esercizio 5:\n");
                    esercizio5();
                    break;
                case 6:
                    Console.WriteLine("Esercizio 6:\n");
                    esercizio6();
                    break;
                case 7:
                    Console.WriteLine("Esercizio 7:\n");
                    esercizio7();
                    break;
                case 8:
                    Console.WriteLine("Esercizio 8:\n");
                    esercizio8();
                    break;
                case 9:
                    Console.WriteLine("Esercizio 9:\n");
                    esercizio9();
                    break;
                case 10:
                    Console.WriteLine("Esercizio 10:\n");
                    esercizio10();
                    break;
            }
        }

        static void esercizio1() 
        {
            bool x = false;
            int n1 = 0, n2 = 0;
            do
            {
                try
                {
                    Console.Write("     Iserisci un numero: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("     Iserisci un numero: ");
                    n2 = int.Parse(Console.ReadLine());
                    x = true;
                    if (n1 <= 0 || n2 <= 0)
                    {
                        Console.WriteLine("     Errore inerimento numeri\n");
                        x = false;
                    }

                }
                catch
                {
                    Console.WriteLine("     Errore inerimento numeri\n");
                }

            } while (x == false);

            int[] numeri = new int[n1];

            if (n2 % 2 != 0)
            {
                n2++;
            }

            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = n2;
                n2 += 2;
            }

            string res = "     NUMERI = {";
            for (int i = 0; i < numeri.Length; i++)
            {
                if(i == numeri.Length - 1)
                {
                    res = res + numeri[i].ToString() + "}";
                }
                else
                {
                    res = res + numeri[i].ToString() + ",";
                }                
            }

            Console.WriteLine(res);
        }

        static void esercizio2() { }
        static void esercizio3() { }
        static void esercizio4() { }
        static void esercizio5() { }
        static void esercizio6() { }
        static void esercizio7() { }
        static void esercizio8() { }
        static void esercizio9() { }
        static void esercizio10() { }


    }
}
