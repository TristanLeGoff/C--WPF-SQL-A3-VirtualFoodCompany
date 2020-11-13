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
    /// Logique d'interaction pour PageNewCommand.xaml
    /// </summary>
    public partial class PageNewCommand : Page
    {
        public PageNewCommand(List<Recipe> listRecipe)
        {
            InitializeComponent();
            LVrecipe.ItemsSource = listRecipe;
        }

        private void BAddCart_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client(ActiveSession.Instance.Phone);
            Order order = client.CurrentOrder();
            foreach (Recipe r in LVrecipe.SelectedItems)
            {
                order.addRecipe(r, 1);
                TError.Text = r.Name + " à bien été ajoutée au panier";
                TError.Visibility = Visibility.Visible;
            }


        }

        private void BDetail_Click(object sender, RoutedEventArgs e)
        {
            foreach (Recipe r in LVrecipe.SelectedItems)
            {
                TDescription.Text = r.Description;
            }
        }
    }
}
