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
    /// Logique d'interaction pour PageCreateCommand.xaml
    /// </summary>
    public partial class PageCreateCommand : Page
    {
        public List<Produce> LProduce;
        public PageCreateCommand()
        {
            InitializeComponent();
            Fonction fonction = new Fonction();
            LVProduce.ItemsSource = fonction.listProduce();
            LProduce = new List<Produce>();
        }

        private void BValider_Click(object sender, RoutedEventArgs e)
        {
            foreach (Produce p in LVProduce.SelectedItems)
            {
                LProduce.Add(p);

            }
            Recipe recipe = new Recipe(TName.Text, TDescription.Text, TType.Text, Convert.ToDouble(TPrice.Text), ActiveSession.Instance.Phone, LProduce);
            TError.Text = "La recette à bien été crée";
            TError.Visibility = Visibility.Visible;
            TName.Text = "";
            TDescription.Text = "";
            TType.Text = "";
            TPrice.Text = "";
            Fonction fonction = new Fonction();
            LVProduce.ItemsSource = fonction.listProduce();
        }
    }
}
