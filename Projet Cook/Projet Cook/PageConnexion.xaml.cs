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
    /// Logique d'interaction pour PageConnexion.xaml
    /// </summary>
    public partial class PageConnexion : Page
    {
        public PageConnexion()
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
        public bool AuthGood(string phone,string password)
        {
            string tel = "";
            string mdp = "";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            string requete = "SELECT phone,password from client where phone=" + "'" + phone + "'" + ";";
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = requete;
            MySqlDataReader reader = command.ExecuteReader();
            string[] valueString = new string[reader.FieldCount];
            while (reader.Read())
            {
                tel = reader.GetValue(0).ToString();
                mdp = reader.GetValue(1).ToString();
            }
            if (tel == phone && mdp == password )
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        private void BSeConnecter_Click(object sender, RoutedEventArgs e)
        {
            bool valid = true;

            if (AuthGood(TphoneNumber.Text, TPassword.Text) == false || TphoneNumber.Text.Length == 0 || TPassword.Text.Length == 0)
            {
                TError.Text = "Mot de passe ou numéro incorrecte";
                TError.Visibility = Visibility.Visible;
                valid = false;
            }
            if (valid == true)
            {
                ActiveSession.Instance.Phone = TphoneNumber.Text;
                WindowAccueil w = new WindowAccueil();
                w.Show();
                foreach (Window window in Application.Current.Windows)
                {
                    if (window is MainWindow)
                    {
                        window.Close();
                        break;
                    }
                }
            }

        }

        public void Hyperlink_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
