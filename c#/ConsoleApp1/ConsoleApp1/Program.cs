using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            mainQuadrato();
        }

        static void mainCerchio()
        {
            Cerchio c1 = new Cerchio(5);
            double perimetro, area;
            perimetro = c1.Perimetro();
            area = c1.Area();
            Console.WriteLine("Il perimetro è: " + perimetro);
            Console.WriteLine("l'area è: " + area);
        }

        static void mainTriangolo()
        {
            Triangolo t1 = new Triangolo(3, 4, 5);
            double perimetro, area;
            string tipologia;
            bool is_rettangolo;
            perimetro = t1.Perimetro();
            area = t1.Area();
            tipologia = t1.Tipologia();
            is_rettangolo = t1.IsRettangolo();
            Console.WriteLine("Il perimetro è: " + perimetro);
            Console.WriteLine("l'area è: " + area);
            Console.WriteLine("Il triangolo è: " + tipologia);
            if(is_rettangolo)
                Console.WriteLine("Il triangolo è rettangolo.");
            else
                Console.WriteLine("Il triangolo non è rettangolo.");
        }

        static void mainRettangolo()
        {
            Rettangolo r1 = new Rettangolo(3, 4);
            double perimetro, area, diagonale;
            diagonale = r1.Diagonale();
            perimetro = r1.Perimetro();
            area = r1.Area();
            Console.WriteLine("La diagonale è: " + diagonale);
            Console.WriteLine("Il perimetro è: " + perimetro);
            Console.WriteLine("l'area è: " + area);
        }

        static void mainQuadrato()
        {
            Quadrato q1 = new Quadrato(9);
            double perimetro, area, diagonale;
            diagonale = q1.Diagonale();
            perimetro = q1.Perimetro();
            area = q1.Area();
            Console.WriteLine("La diagonale è: " + diagonale);
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
