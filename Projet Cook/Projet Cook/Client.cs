using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_Cook
{
    class Client
    {
        private string phone;
        private string firstName;
        private string lastName;
        private double balance;
        private bool recipeCreator;
        private bool admin;
        private bool chef;
        private string password;
        private string adress;
        private string role;

        //for a completly new client
        public Client(string phone, string firstName, string lastName, bool recipeCreator, bool admin, bool chef, string password, string adress)
        {
            this.phone = phone;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = 0;
            this.recipeCreator = recipeCreator;
            this.admin = admin;
            this.chef = chef;
            this.password = password;
            this.adress = adress;
            if(this.admin == true)
            {
                this.role = "Admin";
            }
            else if (this.chef == true)
            {
                this.role = "Cuisinier";
            }
            else if (this.recipeCreator == true)
            {
                this.role = "Créateur";
            }
            else
            {
                this.role = "Client";
            }
            string request = "INSERT INTO client (phone,firstName,lastName,balance,recipeCreator,admin,chef,password,adress) " +
            "VALUES(" + "'" + phone + "'" + "," + "'" + firstName + "'" + "," + "'" + lastName + "'" + "," + balance
            + "," + recipeCreator + "," + admin + "," + chef + "," + "'" + password + "'" + "," + "'" + adress + "'" + ");";
            makeRequest(request);

        }

        public Client(string phone)//for an old client
        {
            string request = "SELECT * FROM client where phone = '" + phone + "'";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            string[] data = new string[reader.FieldCount];
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data[i] = reader.GetValue(i).ToString();
                }
                this.phone = phone;
                this.firstName = data[1];
                this.lastName = data[2];
                this.balance = Convert.ToDouble(data[3]);
                this.recipeCreator = Convert.ToBoolean(data[4]);
                this.admin = Convert.ToBoolean(data[5]);
                this.chef = Convert.ToBoolean(data[6]);
                this.password = data[7];
                this.adress = data[8];
            }
            command.Dispose();
            myConnection.Close();
            if (this.admin == true)
            {
                this.role = "Admin";
            }
            else if (this.chef == true)
            {
                this.role = "Cuisinier";
            }
            else if (this.recipeCreator == true)
            {
                this.role = "Créateur";
            }
            else
            {
                this.role = "Client";
            }
        }

        public string resume()
        {
            string resume = "phone = " + phone + " firstName = " + firstName + " adress = " + adress;
            return resume;
        }
        public void Delete()
        {
            string request = "DELETE FROM client where phone = '" + phone + "';";
            makeRequest(request);
        }
        public void changeBalance(double value)
        {
            balance = balance + value;
            string request = "UPDATE client SET balance =" + balance + " WHERE phone =" + phone + ";";
            makeRequest(request);
        }

        public List<Order> orderHistory()
        {
            List<Order> listOrders = new List<Order>();
            //historique des commandes deja faites parce que valid = true
            string request = "SELECT distinct(orderId) from ordertab NATURAL JOIN client " +
                "WHERE client ='" + phone + "'and valid = true;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            List<string> data = new List<string>();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data.Add(reader.GetValue(i).ToString());
                }
            }
            command.Dispose();
            myConnection.Close();
            //data est la liste des orders d'un client

            //on rempli la liste de commande            
            for (int i = 0; i < data.Count(); i++)
            {
                Order order = new Order(Convert.ToInt32(data[i]));
                listOrders.Add(order);
            }
            return listOrders;
        }

        public Order CurrentOrder()
        {
            //historique des commandes deja faites parce que valid = true
            string request = "SELECT orderId from ordertab NATURAL JOIN client " +
                "WHERE client ='" + phone + "'and valid = false;";
            int id = 0;
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader.GetValue(0).ToString());
            }
            command.Dispose();
            myConnection.Close();
            Order order = new Order(id);
            return order;
        }

        public void deleteRecipe(Recipe recipe)
        {
            recipe.changeAvailable(false);
        }

        public void addRecipe(string name, string description, string type, double price, List<Produce> produce)
        {
            Recipe recipe = new Recipe(name, description, type, price, phone, produce);
        }
        public void changeStatut(string status, bool value)
        {
            if (status == "chef")
            {
                chef = value;
            }
            else if (status == "recipeCreator")
            {
                recipeCreator = value;
            }
            else if (status == "admin")
            {
                admin = value;
            }
            ///update database
            if (status == "admin" || status == "recipeCreator" || status == "chef")
            {
                string request = "UPDATE client SET " + status + "=" + value + " WHERE phone =" + phone + ";";
                makeRequest(request);
            }
        }

        public List<Transaction> transactionHistory()
        {
            List<Transaction> listTransactions = new List<Transaction>();
            string request = "SELECT distinct(transactionID) FROM transaction NATURAL JOIN client " +
                            "where clientPhone = '" + phone + "';";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            List<string> data = new List<string>();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data.Add(reader.GetValue(i).ToString());
                }
            }
            command.Dispose();
            myConnection.Close();
            //data est la liste des transactionID d'un client
            //on rempli la liste de transaction grace aux transactionsID
            for (int i = 0; i < data.Count(); i++)
            {
                Transaction transaction = new Transaction(Convert.ToInt32(data[i]));
                listTransactions.Add(transaction);
            }
            return listTransactions;

        }

        public void changeData()//A tester!!!!!!!!!!!!!!! 
        {
            string request = "UPDATE client set phone ='" + phone + "',firstName='" + firstName + "',lastName='" + lastName +
                "',balance=" + balance + ", recipeCreator=" + recipeCreator + ",admin=" + admin + ",chef=" + chef +
                ",password='" + password + "', adress ='" + adress + "'" +
                "WHERE firstName='" + firstName + "';";
            makeRequest(request);
        }

        public List<Recipe> GetMyRecipe()
        {
            List<Recipe> listRecipe = new List<Recipe>();
            string request = "SELECT distinct(recipeName) FROM recipe " +
                             "WHERE clientPhone =" + phone + ";";

            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetValue(0).ToString();
                Recipe recipe = new Recipe(name);
                listRecipe.Add(recipe);
            }
            command.Dispose();
            myConnection.Close();
            return listRecipe;
        }

        public string Phone { get => phone; set => phone = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Balance { get => balance; set => balance = value; }
        public bool RecipeCreator { get => recipeCreator; set => recipeCreator = value; }
        public bool Admin { get => admin; set => admin = value; }
        public bool Chef { get => chef; set => chef = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Role { get => role; set => role = value; }


        private void makeRequest(string request)
        {
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            command.ExecuteNonQuery();
            command.Dispose();
            myConnection.Close();
        }
        private MySqlConnection connectionServer()
        {
            MySqlConnection myConnection;
            string connectionString = "SERVER=localhost;PORT=3306;" +
                                         "DATABASE=cooking;" +
                                         "UID=root;PASSWORD=" + ActiveSession.Instance.Password;

            myConnection = new MySqlConnection(connectionString);
            return myConnection;
        }
    }
}
