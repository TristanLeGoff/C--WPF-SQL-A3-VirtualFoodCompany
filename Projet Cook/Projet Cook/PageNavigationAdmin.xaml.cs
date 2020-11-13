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
    /// Logique d'interaction pour PageNavigationAdmin.xaml
    /// </summary>
    public partial class PageNavigationAdmin : Page
    {
        private readonly WindowAccueil _waccueil;
        public PageNavigationAdmin(WindowAccueil waccueil)
        {
            InitializeComponent();
            _waccueil = waccueil;
        }

        private void BBoard_Click(object sender, RoutedEventArgs e)
        {
            _waccueil.AdminBoard();
        }

        private void BClient_Click(object sender, RoutedEventArgs e)
        {
            _waccueil.AdminClient();
        }

        private void BREcipe_Click(object sender, RoutedEventArgs e)
        {
            _waccueil.AdminRecipe();
        }

        private void BTransactions_Click(object sender, RoutedEventArgs e)
        {
            _waccueil.AdminTransaction();
        }
    }
}
