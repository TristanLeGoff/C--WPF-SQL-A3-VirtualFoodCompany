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
    /// Logique d'interaction pour PageAdminRecipe.xaml
    /// </summary>
    public partial class PageAdminRecipe : Page
    {
        public PageAdminRecipe()
        {
            InitializeComponent();
            Fonction f = new Fonction();
            LVrecipe.ItemsSource = f.listRecipe();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            Produce p = new Produce(TName.Text, "EuroFood", Convert.ToInt32(TQuantity.Text));
            TError.Text = "Le produit à bien été ajouté";
            TError.Visibility = Visibility.Visible;
            TName.Text = "";
            TQuantity.Text = "";
        }

        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            foreach (Recipe r in LVrecipe.SelectedItems)
            {
                r.Delete();
            }
            Fonction f = new Fonction();
            LVrecipe.ItemsSource = f.listRecipe();
        }

        private void BActu_Click(object sender, RoutedEventArgs e)
        {
            Fonction f = new Fonction();
            f.VerifyIfRecipeUsed();
            TError.Text = "Les stock min et max ont été actualisés";
            TError.Visibility = Visibility.Visible;
        }
    }
}
