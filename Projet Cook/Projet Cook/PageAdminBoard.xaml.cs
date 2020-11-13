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
    /// Logique d'interaction pour PageAdminBoard.xaml
    /// </summary>
    public partial class PageAdminBoard : Page
    {
        public PageAdminBoard()
        {
            InitializeComponent();
            Fonction f = new Fonction();
            if(f.Top1CreatorOfTheWeek() != null)
            {
                TBestCdr.Text = f.Top1CreatorOfTheWeek().FirstName + " " + f.Top1CreatorOfTheWeek().LastName;
            }
            LVrecipe.ItemsSource = f.Top1CreatorEver();
            if(f.Top1CreatorEver().Count > 0 )
            {
                TGoldCdr.Text = f.Top1CreatorEver()[0].RecipeCreator;
            }
            LVrecipeAll.ItemsSource = f.Top5RecipesEver();
        }
        

        
    }
}
