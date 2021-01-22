using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            mainTriangolo();
        }

        static void mainTriangolo()
        {
            Triangolo t1 = new Triangolo(5, 9, 5);
            double perimetro = 0, area = 0;
            perimetro = t1.Perimetro();
            area = t1.Area();
            Console.WriteLine("Il perimetro è: " + perimetro);
            Console.WriteLine("l'area è: " + area);
        }

        static void mainRettangolo()
        {
            Rettangolo r1 = new Rettangolo(5, 9, 5, 9);
            double perimetro = 0, area = 0;
            perimetro = r1.Perimetro();
            area = r1.Area();
            Console.WriteLine("Il perimetro è: " + perimetro);
            Console.WriteLine("l'area è: " + area);
        }

        static void mainPuntop2D()
        {
            Punto2D p1 = new Punto2D(5.4, 6.2);
            Punto2D p2 = new Punto2D(5.9, 8.2);

            double distanza = p1.CalcolaDistanza(p2);
            Console.WriteLine("La distanza tra i due punti è: " + distanza);
        }
    }
}
