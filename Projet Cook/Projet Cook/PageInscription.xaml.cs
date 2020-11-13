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
    /// Logique d'interaction pour PageInscription.xaml
    /// </summary>
    public partial class PageInscription : Page
    {
        public PageInscription()
        {
            InitializeComponent();
        }

        public MySqlConnection connectionServer()
        {
            MySqlConnection myConnection;
            string connectionString = "SERVER=localhost;PORT=3306;" +
                                         "DATABASE=cooking;" +
                                         "UID=root;PASSWORD=mysecretpassword";

            myConnection = new MySqlConnection(connectionString);
            return myConnection;
        }
        public bool PhoneUnUse(string phone)
        {
            string abc = "";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            string requete = "SELECT phone from client where phone=" + "'" + phone + "'" + ";";
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = requete;
            MySqlDataReader reader = command.ExecuteReader();
            string[] valueString = new string[reader.FieldCount];
            while (reader.Read())
            {
                 abc = reader.GetValue(0).ToString() ;
            }
            if (abc != phone)
            {
                return true;
            }
            else 
            {
                
                return false; 
            }
        }

        private void BInscription_Click(object sender, RoutedEventArgs e)
        {
            bool valid = true;
            if (PhoneUnUse(TPhone.Text) == false)
            {
                TError.Text = "Ce numéro de téléphone est déjà utilisé";
                TError.Visibility = Visibility.Visible;
                valid = false;
            }
            if(TPhone.Text.Length != 10)
            {
                TError.Text = "Un numéro de téléphone contient 10 chiffres";
                TError.Visibility = Visibility.Visible;
                valid = false;
            }
            if(TPassword.Text != TConfirmPassword.Text)
            {
                TError.Text = "Les 2 mots de passe ne correspondent pas";
                TError.Visibility = Visibility.Visible;
                valid = false;
            }
            if (TPrenom.Text == "" || TNom.Text == "" || TAdresse.Text == "" || TPassword.Text == "")
            {
                TError.Text = "Tous les champs doivent être remplis";
                TError.Visibility = Visibility.Visible;
                valid = false;
            }
            if (valid == true)
            {
                Client cl = new Client(TPhone.Text, TPrenom.Text, TNom.Text, false, false, false, TPassword.Text, TAdresse.Text);
                Order order = new Order(TPhone.Text);
                Page co = new PageConnexion();
                NavigationService.Navigate(co);
            }
        }
    }
}
