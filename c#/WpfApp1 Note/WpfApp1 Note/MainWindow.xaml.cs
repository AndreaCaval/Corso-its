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

namespace WpfApp1_Note
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Nota> note = new List<Nota>();
        public MainWindow()
        {
            InitializeComponent();

            lstNote.ItemsSource = note;


        }

        private void btnSalva_Click(object sender, RoutedEventArgs e)
        {
            string testoNota = txtTesto.Text;
            if (string.IsNullOrWhiteSpace(testoNota))
            {
                MessageBox.Show("Inserisci il testo.", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Nota n = new Nota(testoNota);
            note.Add(n);

            lstNote.Items.Refresh();
        }
    }
}
