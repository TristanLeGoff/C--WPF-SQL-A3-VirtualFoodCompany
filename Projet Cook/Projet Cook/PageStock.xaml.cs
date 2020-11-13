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
    /// Logique d'interaction pour PageStock.xaml
    /// </summary>
    public partial class PageStock : Page
    {
        public PageStock()
        {
            InitializeComponent();
            Fonction f = new Fonction();
            LVproduce.ItemsSource = f.listProduce();
            LVAddProduce.ItemsSource = f.listProduce();
        }

        private void BCommand_Click(object sender, RoutedEventArgs e)
        {
            
            Produce p =  (Produce) LVAddProduce.SelectedItem;
            p.moreStock(Convert.ToInt32(TQuantity.Text));
            Fonction f = new Fonction();
            LVproduce.ItemsSource = f.listProduce();
            TQuantity.Text = "";
            LVAddProduce.SelectedItem = null;
            Terror.Text = "Le produit selectionné à bien été ajouté au stock";
            Terror.Visibility = Visibility.Visible;


        }

        private void BCommandAll_Click(object sender, RoutedEventArgs e)
        {
            Fonction f = new Fonction();
            f.VerifyAndAddStock();
            LVproduce.ItemsSource = f.listProduce();
            Terror.Text = "Tous les produits manquants ont été approvisionnés";
            Terror.Visibility = Visibility.Visible;

        }
    }
}
