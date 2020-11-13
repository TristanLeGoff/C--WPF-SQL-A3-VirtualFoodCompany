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
    /// Logique d'interaction pour OldOrderr.xaml
    /// </summary>
    public partial class OldOrderr : Page
    {
        private readonly WindowAccueil _waccueil;
        public OldOrderr(WindowAccueil waccueil)
        {
            InitializeComponent();
            _waccueil = waccueil;
            Client client = new Client(ActiveSession.Instance.Phone);
            LVListOrder.ItemsSource = client.orderHistory();
            LVListREcipe.Visibility = Visibility.Hidden;
        }

        private void BAccueil_Click(object sender, RoutedEventArgs e)
        {
            _waccueil.GoHome();
        }

        private void BDetail_Click(object sender, RoutedEventArgs e)
        {
            LVListREcipe.Visibility = Visibility.Visible;
            foreach (Order order in LVListOrder.SelectedItems)
            {
                LVListREcipe.ItemsSource = order.QuantityFromName;
            }
        }
    }
}
