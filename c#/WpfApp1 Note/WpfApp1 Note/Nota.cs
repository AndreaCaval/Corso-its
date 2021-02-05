using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1_Note
{
    public class Nota
    {
        public string Testo { get; set; }
        public DateTime DataIns { get; }
        public Nota(string testo)
        {
            Testo = testo;
            DataIns = DateTime.Now;
        }

        public override string ToString()
        {
            const int max = 30;

            if (Testo.Length <= max) return Testo;

            return Testo.Substring(0, 30) + "...";
        }
    }
}
