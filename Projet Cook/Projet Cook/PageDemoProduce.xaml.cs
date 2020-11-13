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
    /// Logique d'interaction pour PageDemoProduce.xaml
    /// </summary>
    public partial class PageDemoProduce : Page
    {
        public PageDemoProduce()
        {
            InitializeComponent();
            Fonction f = new Fonction();
            LVproduce.ItemsSource = f.listProduceX2();
        }
    }
}
