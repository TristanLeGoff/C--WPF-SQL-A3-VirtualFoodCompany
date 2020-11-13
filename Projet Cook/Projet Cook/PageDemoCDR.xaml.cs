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
    /// Logique d'interaction pour PageDemoCDR.xaml
    /// </summary>
    public partial class PageDemoCDR : Page
    {
        public PageDemoCDR()
        {
            InitializeComponent();
            Fonction f = new Fonction();
            LVCDR.ItemsSource = f.listCDR();
            TTotal.Text = Convert.ToString(f.countRecipe());
            
        }
    }
}
