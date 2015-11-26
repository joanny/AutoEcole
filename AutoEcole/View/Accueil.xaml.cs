using AutoEcole.ViewModel;
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
using System.Windows.Shapes;

namespace AutoEcole.View
{
    /// <summary>
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        public Accueil()
        {
            InitializeComponent();           
        }

        private void lecon_Click(object sender, RoutedEventArgs e)
        {
             ucGestionEleve.Visibility = System.Windows.Visibility.Hidden;
             ucGestionVehicule.Visibility = System.Windows.Visibility.Hidden;
        }

        private void vehicule_Click(object sender, RoutedEventArgs e)
        {
            ucGestionEleve.Visibility = System.Windows.Visibility.Hidden;
            ucGestionVehicule.Visibility = System.Windows.Visibility.Visible;
        }
        private void eleve_Click(object sender, RoutedEventArgs e)
        {
            ucGestionEleve.Visibility = System.Windows.Visibility.Visible;
            ucGestionVehicule.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
