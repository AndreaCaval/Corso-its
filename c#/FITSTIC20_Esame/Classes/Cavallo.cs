using System;
using System.Collections.Generic;

namespace FITSTIC20.Classes
{
    public class Cavallo : Pezzo, ITest
    {
        public Cavallo(bool bianco) : base(bianco)
        {

        }
        public override IEnumerable<Cella> CalcolaMosseDisponibili(Cella partenza)
        {
            List<Cella> celle = new List<Cella>();

            char lettera = partenza.LetteraColonna();
            int valLettera;

            for (int i = -2; i <= 2; i++)
            {
                valLettera = (int)lettera + i;
                if (i != 0)
                {                    

                    if (Math.Abs(i) == 2)
                    {
                        for (int y = -1; y <= 1; y += 2)
                        {
                            Cella c = new Cella((char)valLettera + "" + (partenza.NRiga + y));
                            if (c.Valida())
                                celle.Add(c);
                        }
                    }
                    else
                    {
                        for (int y = -2; y <= 2; y += 4)
                        {
                            Cella c = new Cella((char)valLettera + "" + (partenza.NRiga + y));
                            if (c.Valida())
                                celle.Add(c);
                        }
                    }
                }
            }
            
            return celle;
        }
    }
}
