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
using MySql.Data.MySqlClient;

namespace Projet_Cook
{
    /// <summary>
    /// Logique d'interaction pour WindowAccueil.xaml
    /// </summary>
    public partial class WindowAccueil : Window
    {
        static int i = 0;
        public WindowAccueil()
        {
            InitializeComponent();
            SetSold();
            GridMain.Content = new PageHello();
            Client c = new Client(ActiveSession.Instance.Phone);
            if(c.RecipeCreator == false)
            {
                CreateRecipie.Visibility = Visibility.Collapsed;
                MyRecipie.Visibility = Visibility.Collapsed;
            }
            if (c.Chef == false)
            {
                Stock.Visibility = Visibility.Collapsed;
            }
            if (c.Chef == false)
            {
                MyAdmin.Visibility = Visibility.Collapsed;
            }


        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void MyRecipie_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GridMain.Content = new PageMyRecipe(this);
            GridTop.Content = null;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void Stock_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GridMain.Content = new PageStock();
            GridTop.Content = null;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void MyAdmin_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GridTop.Content = new PageNavigationAdmin(this);
            GridMain.Content = new PageAdminBoard();
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void CreateRecipie_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GridMain.Content = new PageCreateCommand();
            GridTop.Content = null;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void NewCommand_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Fonction fonction = new Fonction();
            GridMain.Content = new PageNewCommand(fonction.listRecipe());
            GridTop.Content = new PageRechercheRecette(this);
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        public void ReloadRecipe()
        {
            Fonction fonction = new Fonction();
            GridMain.Content = new PageNewCommand(fonction.listRecipe());
        }

        public void ResearchRecipe(string value)
        {
            Fonction fonction = new Fonction();
            GridMain.Content = new PageNewCommand(fonction.listRecipeResearch(value));
        }


        private void BDeconnexion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window is WindowAccueil)
                {
                    window.Close();
                    break;
                }
            }
        }

        private void BMonCompte_Click(object sender, RoutedEventArgs e)
        {
            GridTop.Content = null;
            GridMain.Content = new PagePersonalInformation();
        }

        private void AddCook_Click(object sender, RoutedEventArgs e)
        {
            GridTop.Content = null;
            GridMain.Content = new PageNewCook(this);
        }
        public void SetSold()
        {
            Client client = new Client(ActiveSession.Instance.Phone);
            Tsolde.Text = "Mon solde : " + client.Balance + " Cook";
        }

        public void GoHome()
        {
            GridTop.Content = null;
            GridMain.Content = new PageHello();
        }

        private void BHello_Click(object sender, RoutedEventArgs e)
        {
            GridTop.Content = null;
            GridMain.Content = new PageHello();
        }

        private void MyOrder_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Content = new PageMyOder(this);
            GridTop.Content = null;
        }

        private void BHistoCommand_Click(object sender, RoutedEventArgs e)
        {
            GridTop.Content = null;
            GridMain.Content = new OldOrderr(this);
        }

        private void RetireCook_Click(object sender, RoutedEventArgs e)
        {
            GridTop.Content = null;
            GridMain.Content = new PageRetireCook(this);
        }

        private void MyTrnasactions_Click(object sender, RoutedEventArgs e)
        {
            GridTop.Content = null;
            GridMain.Content = new PageMyTransaction(this);
        }

        public void AdminBoard()
        {
            GridMain.Content = new PageAdminBoard();
        }
        public void AdminClient()
        {
            GridMain.Content = new PageAdminClient();
        }
        public void AdminRecipe()
        {
            GridMain.Content = new PageAdminRecipe();
        }
        public void AdminTransaction()
        {
            GridMain.Content = new PageAdminTransaction();
        }

        private void BNext_Click(object sender, RoutedEventArgs e)
        {
            if(i>3)
            {
                i = 0;
            }
            if(i == 0)
            {
                GridMain.Content = new PageAdminClient();
                GridTop.Content = null;
            }
            if (i == 1)
            {
                GridMain.Content = new PageDemoCDR();
                GridTop.Content = null;
            }
            if (i == 2)
            {
                GridMain.Content = new PageDemoProduce();
                GridTop.Content = null;
            }
            if (i == 3)
            {
                Fonction f = new Fonction();
                GridMain.Content = new PageNewCommand(f.listRecipe());
                GridTop.Content = new PageRechercheRecette(this);
            }
            i++;
        }

        private void BDemo_Click(object sender, RoutedEventArgs e)
        {
            BNext.Visibility = Visibility.Visible;
        }
    }
}
