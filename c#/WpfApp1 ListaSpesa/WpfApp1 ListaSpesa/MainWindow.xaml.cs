using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace WpfApp1_ListaSpesa
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Priorità> priorita;
        private List<Spesa> spese;

        enum Priorità
        {
            Bassa,
            Media,
            Alta
        }       

        public MainWindow()
        {
            InitializeComponent();

            priorita = new List<Priorità>
            {
                Priorità.Bassa,
                Priorità.Media,
                Priorità.Alta
            };

            priorità.ItemsSource = priorita;
            priorità.SelectedIndex = 0;

            spese = new List<Spesa>();
            lista.ItemsSource = spese;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        class Spesa
        {
            public string nome { get; set; }
            public int quantita { get; set; }
            public Priorità priorita { get; set; }

            public Spesa(string nome, int quantita, Priorità priorita)
            {
                this.nome = nome;
                this.quantita = quantita;
                this.priorita = priorita;
            }

            public override string ToString()
            {
                return nome + " - " + quantita.ToString() + " - " + priorita.ToString();
            }
        }

        private void btn_Aggiungi_Click(object sender, RoutedEventArgs e)
        {
            string nome = Nome.Text;
            string qt = Quantità.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Inserisci un Nome.");
                return;
            }
            if (string.IsNullOrWhiteSpace(qt))
            {
                MessageBox.Show("Inserisci un Nome.");
                return;
            }
            int quantita = int.Parse(qt);

            Priorità priorita = (Priorità)priorità.SelectedValue;
            
            Spesa s = new Spesa(nome, quantita, priorita);
            spese.Add(s);
            lista.Items.Refresh();
        }
    }
}
