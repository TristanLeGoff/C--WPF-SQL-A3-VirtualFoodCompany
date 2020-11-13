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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GridMain.Content = new PageConnexion();
            ActiveSession a = new ActiveSession("", "");
            ActiveSession.Instance.Password = "mysecretpassword";
        }

        public void BInscription_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Content = new PageInscription();
        }

        private void BConnexion_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Content = new PageConnexion();
        }
    }
}
