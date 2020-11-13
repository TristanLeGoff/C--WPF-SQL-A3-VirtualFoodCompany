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
    /// Logique d'interaction pour PageNewCook.xaml
    /// </summary>
    public partial class PageNewCook : Page
    {
        private readonly WindowAccueil _waccueil;
        public PageNewCook(WindowAccueil waccueil)
        {
            _waccueil = waccueil;
            InitializeComponent();
        }

        private void BValider_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client(ActiveSession.Instance.Phone);
            client.changeBalance(Convert.ToDouble(TMontant.Text));
            Transaction t = new Transaction(client.Phone, Convert.ToDouble(TMontant.Text), "Ajout de cook au compte");
            TError.Text = "Les " + TMontant.Text + " Cook ont été ajoutés au compte";
            TError.Visibility = Visibility.Visible;
            TMontant.Text = "";
            _waccueil.SetSold();
            


        }
    }
}
