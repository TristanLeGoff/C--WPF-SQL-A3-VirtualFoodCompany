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
    /// Logique d'interaction pour PagePersonalInformation.xaml
    /// </summary>
    public partial class PagePersonalInformation : Page
    {
        public PagePersonalInformation()
        {
            InitializeComponent();
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            string requete = "SELECT phone,firstName,lastName,password,adress from client where phone=" + "'" + ActiveSession.Instance.Phone + "'" + ";";
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = requete;
            MySqlDataReader reader = command.ExecuteReader();
            string[] valueString = new string[reader.FieldCount];
            while (reader.Read())
            {
                TPhone.Text = reader.GetValue(0).ToString();
                TPrenom.Text = reader.GetValue(1).ToString();
                TNom.Text = reader.GetValue(2).ToString();
                TPassword.Text = reader.GetValue(3).ToString();
                TAdresse.Text = reader.GetValue(4).ToString();
                TConfirmPassword.Text = reader.GetValue(3).ToString();
            }
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
                abc = reader.GetValue(0).ToString();
            }
            if (abc != phone || abc == ActiveSession.Instance.Phone)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        private void BValider_Click(object sender, RoutedEventArgs e)
        {
            bool valid = true;
            if (PhoneUnUse(TPhone.Text) == false)
            {
                TError.Text = "Ce numéro de téléphone est déjà utilisé";
                TError.Visibility = Visibility.Visible;
                valid = false;
            }
            if (TPhone.Text.Length != 10)
            {
                TError.Text = "Un numéro de téléphone contient 10 chiffres";
                TError.Visibility = Visibility.Visible;
                valid = false;
            }
            if (TPassword.Text != TConfirmPassword.Text)
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
            if(valid == true)
            {
                TError.Text = "Les informations ont été enregistrées";
                TError.Visibility = Visibility.Visible;
                MySqlConnection myConnection = connectionServer();
                myConnection.Open();
                string request = "UPDATE Client SET phone='" + TPhone.Text + "', firstname='" + TPrenom.Text + "', lastname='" + TNom.Text + "', password='" + TPassword.Text + "', adress='" + TAdresse.Text + "'WHERE phone='" + ActiveSession.Instance.Phone + "';"   ;
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = request;
                command.ExecuteNonQuery();
                command.Dispose();
                myConnection.Close();
                ActiveSession.Instance.Phone = TPhone.Text;

            }
        }

        private void BCDR_Click(object sender, RoutedEventArgs e)
        {
            TError.Text = "Vous êtes maintenant créateur de recette, Reconnectez vous pour voir vos nouveau droits";
            TError.Visibility = Visibility.Visible;
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            string request = "UPDATE Client SET recipeCreator=1 WHERE phone='" + ActiveSession.Instance.Phone + "';";
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            command.ExecuteNonQuery();
            command.Dispose();
            myConnection.Close();
        }
    }
}
