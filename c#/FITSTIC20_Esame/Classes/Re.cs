using System;
using System.Collections.Generic;

namespace FITSTIC20.Classes
{
    public class Re : Pezzo
    {
        public Re(bool bianco) : base(bianco)
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

            for (int i = 0; i <= 7; i++)
            {
                for (int y = 0; y <= 7; y++)
                {
                    valLettera = inizio + y + 1;

                    if ((riga - 1 == i + 1 || riga == i + 1 || riga + 1 == i + 1) && (colonna - 1 == y + 1 || colonna == y + 1 || colonna + 1 == y + 1) && !(colonna == y + 1 && riga == i + 1))
                    {
                        Cella c = new Cella((char)valLettera + "" + (i + 1));
                        if (c.Valida())
                            celle.Add(c);
                    }

                }
            }
            return celle;
        }
    }
}
