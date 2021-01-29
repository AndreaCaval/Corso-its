using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1_Semaforo
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispositivoSemaforo sf;
        public MainWindow()
        {            
            InitializeComponent();
            sf = new DispositivoSemaforo();            
            sf.EventoCambioLuce += ModificaGrafica;
            sf.Start();
        }

        private void ModificaGrafica(DispositivoSemaforo.StatoSemaforo stato)
        {
            if (stato == DispositivoSemaforo.StatoSemaforo.Rosso)
            {
                elRed.Fill = new SolidColorBrush(Colors.Red);
                elYellow.Fill = new SolidColorBrush(Colors.Black);
                elGreen.Fill = new SolidColorBrush(Colors.Black);
            }
            else if (stato == DispositivoSemaforo.StatoSemaforo.Giallo)
            {
                elRed.Fill = new SolidColorBrush(Colors.Black);
                elYellow.Fill = new SolidColorBrush(Colors.Yellow);
                elGreen.Fill = new SolidColorBrush(Colors.Black);
            }
            else
            {
                elRed.Fill = new SolidColorBrush(Colors.Black);
                elYellow.Fill = new SolidColorBrush(Colors.Black);
                elGreen.Fill = new SolidColorBrush(Colors.Green);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            sf.Spegni();
        }

        class DispositivoSemaforo
        {
            private Timer t;
            private StatoSemaforo stato;

            public delegate void CambioLuce(StatoSemaforo stato);

            public event CambioLuce EventoCambioLuce;

            public DispositivoSemaforo()
            {
                stato = StatoSemaforo.Giallo;
            }

            public void Start()
            {              
                CambioStato(null, null);

                stato = StatoSemaforo.Rosso;
                t = new Timer(5000);
                t.Elapsed += CambioStato;
                t.Enabled = true;
                t.AutoReset = true;
            }            

            public void Spegni()
            {
                t.Stop();
                t.Dispose();
            }

            private void CambioStato(object sender, ElapsedEventArgs e)
            {
                switch (stato)
                {
                    case StatoSemaforo.Rosso:
                        stato = StatoSemaforo.Verde;
                        break;
                    case StatoSemaforo.Verde:
                        stato = StatoSemaforo.Giallo;
                        break;
                    case StatoSemaforo.Giallo:
                        stato = StatoSemaforo.Rosso;
                        break;
                    default:
                        stato = StatoSemaforo.Rosso;
                        break;
                }

                Debug.WriteLine(stato);
                
                if(EventoCambioLuce != null)
                    EventoCambioLuce(stato);                
            }

            public enum StatoSemaforo
            {
                Rosso,
                Giallo,
                Verde
            }
        }
    }
}
