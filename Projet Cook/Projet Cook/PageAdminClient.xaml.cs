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
    /// Logique d'interaction pour PageAdminClient.xaml
    /// </summary>
    public partial class PageAdminClient : Page
    {
        public PageAdminClient()
        {
            InitializeComponent();
            Fonction f = new Fonction();
            LVclient.ItemsSource = f.listClient();
            TTotal.Text = Convert.ToString(f.listClient().Count);
        }

        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            foreach (Client c in LVclient.SelectedItems)
            {
                c.Delete();


            }
            Fonction f = new Fonction();
            LVclient.ItemsSource = f.listClient();
            TTotal.Text = Convert.ToString(f.listClient().Count);
        }

        private void BCDR_Click(object sender, RoutedEventArgs e)
        {
            foreach (Client c in LVclient.SelectedItems)
            {
                c.changeStatut("recipeCreator",true);

            }
            Fonction f = new Fonction();
            LVclient.ItemsSource = f.listClient();
        }

        private void BChef_Click(object sender, RoutedEventArgs e)
        {
            foreach (Client c in LVclient.SelectedItems)
            {
                c.changeStatut("recipeCreator", true);
                c.changeStatut("chef", true);

            }
            Fonction f = new Fonction();
            LVclient.ItemsSource = f.listClient();
        }

        private void BAdmin_Click(object sender, RoutedEventArgs e)
        {
            foreach (Client c in LVclient.SelectedItems)
            {
                c.changeStatut("recipeCreator", true);
                c.changeStatut("chef", true);
                c.changeStatut("admin", true);
            }
            Fonction f = new Fonction();
            LVclient.ItemsSource = f.listClient();
        }
    }
}
