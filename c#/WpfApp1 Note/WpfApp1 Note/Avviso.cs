using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1_Note
{
    public sealed class Avviso : Nota
    {
        public DateTime DataAlert { get; private set; }
        public Avviso(string testo, DateTime alert) : base(testo)
        {
            DataAlert = alert;
        }

        public bool ModificaAlert(DateTime nuovoAlert)
        {
            if(nuovoAlert > DataAlert)
            {
                DataAlert = nuovoAlert;
                return true;
            }

            return false;
        }

    }
}
