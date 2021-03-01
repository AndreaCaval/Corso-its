using System;
using System.Collections.Generic;

namespace FITSTIC20.Classes
{
    public class Alfiere : Pezzo
    {
        public Alfiere(bool bianco) : base(bianco)
        {

        }
        public override IEnumerable<Cella> CalcolaMosseDisponibili(Cella partenza)
        {
            List<Cella> celle = new List<Cella>();

            char lettera = partenza.LetteraColonna();
            int valLettera;
            int inizio = 64;
            int colonna = (int)lettera - inizio; // D = 4 -> 8
            int riga = partenza.NRiga; // 5 -> 9
            //char[,] matrice = new char[8,8];

            for (int i = 0; i <= 7; i++)
            {
                for (int y = 0; y <= 7; y++)
                {
                    valLettera = inizio + y+1;
                    //matrice[i, y] = (char)valLettera;

                    if(i + 1 != riga && y + 1 != colonna && colonna - riga == y - i)
                    {                       
                        Cella c = new Cella((char)valLettera + "" + (i+1));
                        if (c.Valida())
                            celle.Add(c);
                    }
                }
            }
            return celle;
        }
    }
}
