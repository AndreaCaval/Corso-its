using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Triangolo : FigureGeometriche
    {
        public Triangolo(double l1, double l2, double l3) : base(l1, l2, l3) { }

        public Triangolo(Quadrato q) : base(q.Riduci().Lati[0], q.Riduci().Lati[1], q.Riduci().Lati[2]) { }
        
        public Triangolo(Rettangolo r) : base(r.Riduci().Lati[0], r.Riduci().Lati[1], r.Riduci().Lati[2]) { }

        public override double Area()
        {
            double semiperimetro = Perimetro() / 2;
            return Math.Sqrt(semiperimetro * (semiperimetro - Lati[0]) * (semiperimetro - Lati[1]) * (semiperimetro - Lati[2]));
        }

        private void GetLati(out double l1, out double l2, out double ipotenusa)
        {
            int ipo = 0, y = 0;
            ipotenusa = 0; l1 = 0; l2 = 0;

            for (int i = 0; i < 3; i++)
            {
                if (ipo < Lati[i])
                {
                    ipo = i;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (ipo != i)
                {
                    if(y == 0)
                    {
                        l1 = Lati[i];
                    }
                    else
                    {
                        l2 = Lati[i];
                    }

                    y++;
                }
                else
                {
                    ipotenusa = Lati[i];
                }
            }


        } 

        public bool IsRettangolo()
        {
            bool is_rettangolo = false;
            double ipotenusa, l1, l2;
            double somma_area_cateti, area_ipotenusa;


            GetLati(out l1, out l2, out ipotenusa);

            somma_area_cateti = Math.Pow(l1, 2) + Math.Pow(l2, 2);   

            area_ipotenusa = Math.Pow(ipotenusa, 2);

            if (area_ipotenusa == somma_area_cateti)
                is_rettangolo = true;

            return is_rettangolo;
        }

        public string Tipologia()
        {
            string tipologia = "";
            int coppie = 0;

            if(Lati[0] == Lati[1])
            {
                coppie++;
            }
            if (Lati[1] == Lati[2])
            {
                coppie++;
            }
            if (Lati[0] == Lati[2])
            {
                coppie++;
            }

            if(coppie == 3)
            {
                tipologia = "Equilatero";
            }
            else if (coppie == 1)
            {
                tipologia = "Isoscele";
            }
            else
            {
                tipologia = "Scaleno";
            }


            return tipologia;
        }

        public FigureGeometriche Componi()
        {
            FigureGeometriche f;

            string tipologia = Tipologia();
            bool is_rettangolo = IsRettangolo();
            double l1, l2, ipotenusa = 0;

            GetLati(out l1, out l2, out ipotenusa);
            if (tipologia == "Isoscele" && is_rettangolo)
            {
                f = new Quadrato(l1);
            }
            else if(is_rettangolo)
            {
                
                f = new Rettangolo(l1, l2);
            }
            else //parallelogramma
            {
                f = new Rettangolo(l1, l2);
            }
            
            return f;
        }
    }
}
