﻿using System;
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
    /// Logique d'interaction pour PageAdminTransaction.xaml
    /// </summary>
    public partial class PageAdminTransaction : Page
    {
        public PageAdminTransaction()
        {
            InitializeComponent();
            Fonction f = new Fonction();
            LVtransaction.ItemsSource = f.listTransaction();
        }
    }
}
