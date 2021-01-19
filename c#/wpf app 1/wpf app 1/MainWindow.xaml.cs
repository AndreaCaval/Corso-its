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

namespace wpf_app_1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Veicolo> veicoli;
        private List<Persona> persone;

        enum Veicolo
        {
            Auto,
            Moto
        }

        enum Genere
        {
            Maschio,
            Femmina
        }

        public MainWindow()
        {
            InitializeComponent();

            veicoli = new List<Veicolo> 
            { 
                Veicolo.Auto,            
                Veicolo.Moto
            };

            cmbbox_tipo_veicolo.ItemsSource = veicoli;
            cmbbox_tipo_veicolo.SelectedIndex = 0;

            persone = new List<Persona>();
            lstbox_nomi.ItemsSource = persone;
        }

        struct Persona
        {
            public Persona(string nome, bool privato, Veicolo veicolo, Genere genere)
            {
                Nome = nome;
                Privato = privato;
                Veicolo = veicolo;
                Genere = genere;
            }

            public string Nome { get; set; }
            public bool Privato { get; set; }
            public Veicolo Veicolo { get; set; }
            public Genere Genere { get; set; }

            public override string ToString()
            {
                return Nome;
            }

        }

        private void btn_Salva_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtbox_nome.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Inserisci un Nome.");
                return;
            }

            bool privato = (bool)ckbox_privato.IsChecked;
            Veicolo veicolo = (Veicolo)cmbbox_tipo_veicolo.SelectedValue;
            Genere genere;
            if ((bool)rdb_maschio.IsChecked)
            {
                genere = Genere.Maschio;
            }
            else
            {
                genere = Genere.Femmina;
            }

            Persona p = new Persona(nome, privato, veicolo, genere);
            persone.Add(p);
            lstbox_nomi.Items.Refresh();
        }
    }
}
