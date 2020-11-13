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
    /// Logique d'interaction pour PageMyTransaction.xaml
    /// </summary>
    public partial class PageMyTransaction : Page
    {
        private readonly WindowAccueil _waccueil;
        public PageMyTransaction(WindowAccueil waccueil)
        {
            InitializeComponent();
            _waccueil = waccueil;
            Client client = new Client(ActiveSession.Instance.Phone);
            LVtransaction.ItemsSource = client.transactionHistory();
        }

        private void Baccueil_Click(object sender, RoutedEventArgs e)
        {
            _waccueil.GoHome();
        }
    }
}
