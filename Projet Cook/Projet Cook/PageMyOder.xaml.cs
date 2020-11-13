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
    /// Logique d'interaction pour PageMyOder.xaml
    /// </summary>
    public partial class PageMyOder : Page
    {
        private readonly WindowAccueil _waccueil;
        public PageMyOder(WindowAccueil waccueil)
        {
            InitializeComponent();
            _waccueil = waccueil;
            Client client = new Client(ActiveSession.Instance.Phone);
            LVrecipe.ItemsSource = client.CurrentOrder().QuantityFromName;
            TPrice.Text = "Prix du Panier : " + Convert.ToString(client.CurrentOrder().Price) + " Cook";
        }

        private void BCommand_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client(ActiveSession.Instance.Phone);
            if(client.Balance > client.CurrentOrder().Price)
            {
                
                foreach (Recipe r in client.CurrentOrder().ListRecipes)
                {
                    Client cuisinier = new Client(r.Chef);
                    Client cdr = new Client(r.CdrPhone);

                    for(int i = 0; i < client.CurrentOrder().QuantityFromName[r]; i++)
                    {
                        r.changeStock();
                        r.changeNrbSales(1);
                        cuisinier.changeBalance(2);
                        Transaction tcuisinier = new Transaction(r.Chef, 2, r.Name + " préparée");
                        if (r.NbrSales > 50)
                        {
                            Transaction tcdr1 = new Transaction(r.CdrPhone, 4 , r.Name + " commandée (CDR)");
                            cdr.changeBalance(4);
                        }
                        else
                        {
                            Transaction tcdr2 = new Transaction(r.CdrPhone, 2 , r.Name + " commandée (CDR)");
                            cdr.changeBalance(2);
                        }
                    }
                }
                Transaction t = new Transaction(ActiveSession.Instance.Phone, -client.CurrentOrder().Price, "Commande passée");
                client.changeBalance(-client.CurrentOrder().Price);
                _waccueil.SetSold();
                client.CurrentOrder().PassCommand();
                Order order = new Order(ActiveSession.Instance.Phone);
                LVrecipe.ItemsSource = client.CurrentOrder().QuantityFromName;
                TPrice.Text = "Prix du Panier : " + Convert.ToString(client.CurrentOrder().Price) + " Cook";
                TError.Text = "Votre commande à bien été passée";

            }
            else
            {
                TError.Text = "Pas assez de cook";
            }
            

        }

        private void BDetail_Click(object sender, RoutedEventArgs e)
        {
            foreach (KeyValuePair<Recipe,int> r in LVrecipe.SelectedItems)
            {
                TDescription.Text = r.Key.Description;
            }
        }

        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client(ActiveSession.Instance.Phone);
            foreach (KeyValuePair<Recipe, int> r in LVrecipe.SelectedItems)
            {
                client.CurrentOrder().deleteRecipe(r.Key,1);
                
            }
            LVrecipe.ItemsSource = client.CurrentOrder().QuantityFromName;
            TPrice.Text = "Prix du Panier : " + Convert.ToString(client.CurrentOrder().Price) + " Cook";

        }
    }
}
