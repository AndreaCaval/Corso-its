using FITSTIC20.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FITSTIC20
{
    public class TestEsame
    {
        [TestCase("D2", "D3", typeof(Pedone), true)]
        [TestCase("D2", "D4", typeof(Pedone), true)]
        [TestCase("G7", "G6", typeof(Pedone), false)]
        [TestCase("G7", "G5", typeof(Pedone), false)]
        [TestCase("D4", "E6", typeof(Cavallo), true)]
        [TestCase("B1","C3", typeof(Cavallo), true)]
        [TestCase("D5", "G8", typeof(Alfiere), true)]
        [TestCase("D5", "A2", typeof(Alfiere), true)]
        [TestCase("D5", "C7", typeof(Alfiere), true)]
        [TestCase("D5", "G2", typeof(Alfiere), true)]

        //[TestCase("A8","A4", typeof(Torre), false)]
        public void TestMossaValida(string cellaPartenza, string cellaArrivo, Type tipoPezzo, bool bianco)
        {
            Cella partenza = new Cella(cellaPartenza);
            Cella arrivo = new Cella(cellaArrivo);
            Pezzo p = (Pezzo)Activator.CreateInstance(tipoPezzo, new object[] { bianco });
            bool mossaValida = p.Muovi(partenza, arrivo);
            Assert.True(mossaValida);
        }

        [TestCase("D2", true)]
        [TestCase("G7", false)]
        public void TestAperturaPedone(string cellaPartenza, bool bianco)
        {
            Cella partenza = new Cella(cellaPartenza);
            Pedone p = new Pedone(bianco);
            Cella arrivoApertura = new Cella(partenza.LetteraColonna() + "" + (partenza.NRiga + (bianco ? 1 : -1) * 2));

            bool mossaValida = p.Muovi(partenza, arrivoApertura);
            Assert.True(mossaValida);

            Cella arrivoSecondaMossa = new Cella(arrivoApertura.LetteraColonna() + "" + (arrivoApertura.NRiga + (bianco ? 1 : -1)));

            mossaValida = p.Muovi(arrivoApertura, arrivoSecondaMossa);
            Assert.True(mossaValida);
        }

        [TestCase(true)]
        [TestCase(false)]
        public void TestFormaleMosseValide(bool bianco)
        {
            var ts = CaricaPezziTestabili();
            Cella c = new Cella("D4");
            foreach (var type in ts)
            {
                Pezzo p = (Pezzo)Activator.CreateInstance(type, new object[] { bianco });
                var cellePossibili = p.CalcolaMosseDisponibili(c);
                Assert.False(cellePossibili.Contains(c));
            }
        }

        [TestCase(true)]
        [TestCase(false)]
        public void TestMossaFuoriScacchiera(bool bianco)
        {
            var ts = CaricaPezziTestabili();
            Cella c = new Cella(bianco ? "A8" : "A1");
            foreach (var type in ts)
            {
                Pezzo p = (Pezzo)Activator.CreateInstance(type, new object[] { bianco });
                var cellePossibili = p.CalcolaMosseDisponibili(c).ToList();
                Assert.True(cellePossibili.TrueForAll(cl=>cl.Valida()));
            }
        }

        private IEnumerable<Type> CaricaPezziTestabili()
        {
            return System.Reflection.Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => typeof(ITest).IsAssignableFrom(type) && 
                typeof(Pezzo).IsAssignableFrom(type))
                .ToList();
        }
    }

}