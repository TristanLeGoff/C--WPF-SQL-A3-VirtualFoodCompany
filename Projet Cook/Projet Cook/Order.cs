using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Projet_Cook
{
    public class Order
    {
        private int orderID;
        private string date;
        private string clientPhone;
        private Dictionary<Recipe ,int> quantityFromName;
        private List<Recipe> listRecipes;
        private bool confirm; //true is old and false is new
        private double price;
        private int nombreRecette;

        public Order(string clientPhone) //for an completly new order 
        {
            //first determine an orderID which does not exist
            this.orderID = determineId();
            //complete object
            this.date = Convert.ToString(DateTime.Now);
            this.clientPhone = clientPhone;
            this.confirm = false;
            this.quantityFromName = new Dictionary<Recipe, int>();
            this.listRecipes = new List<Recipe>();
            this.price = 0;
            for(int i = 0; i < listRecipes.Count(); i++)
            {
                this.price += listRecipes[i].Price;
            }
            //insert in DB
            string request = "INSERT INTO ordertab(orderID, date, client, valid) VALUES(" + this.orderID +
                            ",'" + date + "','" + clientPhone + "'," + confirm + ");";
            makeRequest(request);
        }

        public Order(int orderID)//for an old order but we don't know the list of recipes
        {
            this.price = 0;
            this.confirm = true;
            this.orderID = orderID;

            //on veut date et clientPhone
            string request = "SELECT date,client from ordertab WHERE  orderID =" + OrderID + ";";
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
                this.date = data[0];
                this.ClientPhone = data[1];
            }
            command.Dispose();
            myConnection.Close();
            //on cherche maintenant la liste des recettes contenu dans la commande
            quantityFromName = new Dictionary<Recipe, int>();
            listRecipes = new List<Recipe>();
            string request2 = "SELECT recipeName,quantity FROM recipe " +
                            "NATURAL JOIN cart NATURAL JOIN ordertab " +
                            "where orderID =" + orderID + ";";
            myConnection = connectionServer();
            myConnection.Open();
            command = myConnection.CreateCommand(); ;
            command.CommandText = request2;
            MySqlDataReader reader2 = command.ExecuteReader();
            while (reader2.Read())
            {
                Recipe recipe = new Recipe(reader2.GetValue(0).ToString());
                int quantity = Convert.ToInt32(reader2.GetValue(1).ToString());
                listRecipes.Add(recipe);
                quantityFromName.Add(recipe, quantity);
            }
            command.Dispose();
            myConnection.Close();
            for (int i = 0; i < listRecipes.Count(); i++)
            {
                this.price += listRecipes[i].Price * quantityFromName[listRecipes[i]];
            }
            this.nombreRecette = 0;
            foreach (KeyValuePair<Recipe, int> q in this.quantityFromName)
            {
                this.nombreRecette += q.Value;
            }
        }

        private int determineId()
        {
            string request = "SELECT MAX(orderID) from ordertab;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            int maxId = 0;
            while (reader.Read())
            {
                maxId = Convert.ToInt32(reader.GetValue(0).ToString());
            }
            Console.WriteLine(maxId);
            int newId = maxId + 1;
            command.Dispose();
            myConnection.Close();
            return newId;
        }
        public void addRecipe(Recipe recipe, int quantity)
        {
            string request = "";
            if (quantityFromName.ContainsKey(recipe) == true)//if the recipe is already in the list --> change quantity in DB and dico
            {
                int newQuantity = quantityFromName[recipe] + quantity;
                quantityFromName[recipe] = newQuantity;
                Console.WriteLine(quantityFromName[recipe]);
                request = "UPDATE cart SET quantity = " + newQuantity +
                            " where orderID = " + orderID + " and recipeName = '" + recipe.Name + "';";
            }
            else//insert the recipe in the list with his quantity in the dictionnary and in the DB
            {
                listRecipes.Add(recipe);
                quantityFromName.Add(recipe, quantity);
                request = "INSERT INTO cart (orderID,quantity,recipeName) VALUES (" + orderID
                            + "," + quantity + ",'" + recipe.Name + "');";
            }
            makeRequest(request);
        }
        public void deleteRecipe(Recipe recipe, int quantity) //can only delete recipe which already are in the cart !
        {
            string request = "";
            int testQuantity;
            if (quantityFromName.TryGetValue(recipe, out testQuantity))
            {
                if (testQuantity == quantity)//if the quantity of that recipe is equal to the quantity you want to delete for that order 
                                             //--> we delete the raw in DB, the recipe in the dico and in the list
                {
                    listRecipes.RemoveAll(x => x.Name == recipe.Name);
                    quantityFromName.Remove(recipe);
                    request = "DELETE FROM cart where orderID = " + orderID + " and recipeName ='" + recipe.Name + "';";

                }
                else if (quantityFromName[recipe] > quantity)//is the quantity is lower, 
                                                                  //we change the quantity in the raw in DB and in the dico
                {
                    int newQuantity = quantityFromName[recipe] - quantity;
                    quantityFromName[recipe] = newQuantity;
                    request = "UPDATE cart SET quantity = " + newQuantity +
                            " where orderID = " + orderID + " and recipeName = '" + recipe.Name + "';";
                }
                makeRequest(request);
            }
            else
            {
                Console.WriteLine("recipe not found !");
            }

        }

        public void PassCommand()
        {
            string request = "UPDATE ordertab SET valid=1;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            command.Dispose();
            myConnection.Close();
        }

        public string Date { get => date; set => date = value; }
        public string ClientPhone { get => clientPhone; set => clientPhone = value; }
        public int OrderID { get => orderID; set => orderID = value; }
        public int Nombrerecette { get => nombreRecette; set => nombreRecette = value; }
        public double Price { get => price; set => price = value; }
        public bool Confirm { get => confirm; set => confirm = value; }
        public List<Recipe> ListRecipes { get => listRecipes; set => listRecipes = value; }
        public Dictionary<Recipe, int> QuantityFromName { get => quantityFromName; set => quantityFromName = value; }

        public MySqlConnection connectionServer()
        {
            MySqlConnection myConnection;
            string connectionString = "SERVER=localhost;PORT=3306;" +
                                            "DATABASE=cooking;" +
                                            "UID=root;PASSWORD=" + ActiveSession.Instance.Password;

            myConnection = new MySqlConnection(connectionString);
            return myConnection;
        }
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
    }
}
