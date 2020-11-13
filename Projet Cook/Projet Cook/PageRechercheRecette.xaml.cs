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

namespace Projet_Cook
{
    /// <summary>
    /// Logique d'interaction pour PageRechercheRecette.xaml
    /// </summary>
    public partial class PageRechercheRecette : Page
    {
        private readonly WindowAccueil _waccueil;
        public PageRechercheRecette(WindowAccueil waccueil)
        {
            _waccueil = waccueil;
            InitializeComponent();
        }

        private void BRecherche_Click(object sender, RoutedEventArgs e)
        {
            _waccueil.ResearchRecipe(TRecherche.Text);
        }

        private void BAll_Click(object sender, RoutedEventArgs e)
        {
            _waccueil.ReloadRecipe();
        }
    }
}
