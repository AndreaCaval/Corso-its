﻿using System;
using System.Collections.Generic;

namespace FITSTIC20.Classes
{
    public class Pedone : Pezzo, ITest
    {
        public Pedone(bool bianco) : base(bianco)
        {
        }

        public override IEnumerable<Cella> CalcolaMosseDisponibili(Cella partenza)
        {
            int direzione = Bianco ? 1 : -1;
            List<Cella> celle = new List<Cella>();
            Cella c = new Cella(partenza.LetteraColonna() + "" + (partenza.NRiga + 1 * direzione));
            if (c.Valida())
                celle.Add(c);
            Cella c1 = new Cella(partenza.LetteraColonna() + "" + (partenza.NRiga + 2 * direzione));
            if (c1.Valida())
                celle.Add(c1);
            return celle;
        }
    }
}
