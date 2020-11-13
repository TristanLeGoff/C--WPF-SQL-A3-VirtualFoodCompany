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
    /// Logique d'interaction pour PageRetireCook.xaml
    /// </summary>
    public partial class PageRetireCook : Page
    {
        private readonly WindowAccueil _waccueil;
        public PageRetireCook(WindowAccueil waccueil)
        {
            InitializeComponent();
            _waccueil = waccueil;
        }

        private void BValider_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client(ActiveSession.Instance.Phone);
            client.changeBalance(-Convert.ToDouble(TMontant.Text));
            Transaction t = new Transaction(client.Phone, -Convert.ToDouble(TMontant.Text), "Retrait de cook du compte");
            TError.Text = "Les " + TMontant.Text + " Cook ont été retirés du compte";
            TError.Visibility = Visibility.Visible;
            TMontant.Text = "";
            _waccueil.SetSold();
            
        }
    }
}
