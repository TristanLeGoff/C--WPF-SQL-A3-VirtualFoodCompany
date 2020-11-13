using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_Cook
{
    public class Recipe
    {
        private string name;
        private bool available;
        private string description;
        private string type;
        private double price;
        private string recipeCreator;
        private string cdrPhone;
        private string chef;
        private List<Produce> listProduces;
        private int nbrSales;

        //for  a completly new recipe
        public Recipe(string name, string description, string type, double price, string recipeCreator, List<Produce> listProduces)
        {
            this.listProduces = listProduces;
            this.name = name;
            this.description = description;
            this.type = type;
            this.price = price;
            this.recipeCreator = recipeCreator;
            this.available = false;
            this.nbrSales = 0;

            //chercher un chef dans la base de donnée
            string request = "SELECT phone FROM client WHERE chef = true;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            string[] data = new string[reader.FieldCount];
            while (reader.Read())
            {
                this.chef = reader.GetValue(0).ToString();
            }
            command.Dispose();


            //Insert into DB
            request = "INSERT INTO recipe(recipeName, available, description, type, price, clientPhone, chefPhone, nbrSales)" +
                " VALUES('" + name + "', true,'" + description + "','" + type + "'," + price + ",'" + recipeCreator + "','" +
                chef + "'," + nbrSales + ");";
            makeRequest(request);
            for (int i = 0; i < listProduces.Count; i++)
            {
                request = "INSERT INTO recipeContent(stockMini,nameProduce,recipeName) VALUES (2,'"
                        + listProduces[i].Name + "','" + name + "');";
                makeRequest(request);
            }

        }

        //for an old recipe
        public Recipe(string name)
        {
            string request = "SELECT * FROM recipe WHERE recipeName = '" + name + "';";
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
                this.name = name;
                this.available = Convert.ToBoolean(data[1]);
                this.Description = data[2];
                this.type = data[3];
                this.price = Convert.ToDouble(data[4]);
                Client client = new Client(data[5]);
                this.cdrPhone = client.Phone;
                this.recipeCreator = client.FirstName + " " + client.LastName;
                this.chef = data[6];
                this.nbrSales = Convert.ToInt32(data[7]);
            }
            command.Dispose();
            this.listProduces = new List<Produce>();
            request = "SELECT nameProduce FROM produce NATURAL JOIN recipeContent " +
                    "where recipeName='" + name + "';";
            command = myConnection.CreateCommand();
            command.CommandText = request;
            reader = command.ExecuteReader();
            data = new string[reader.FieldCount];
            while (reader.Read())
            {
                Produce produce = new Produce(data[0]);
                this.listProduces.Add(produce);
            }
            command.Dispose();
            myConnection.Close();
        }

        public string resume()
        {
            string resume = "Recipe name is " + name + "\n valid : " + available + " \n description : " + description + "\n type :" +
                            type + "\n price : " + price + "\n recipeCreator : " + recipeCreator;
            return resume;
        }

        public override int GetHashCode()
        {
            if (name == null) return 0;
            return name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Recipe other = obj as Recipe;
            return other != null && other.name == this.name;
        }



        public string Name { get => name; set => name = value; }
        public bool Available { get => available; set => available = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
        public string RecipeCreator { get => recipeCreator; set => recipeCreator = value; }
        public string CdrPhone { get => cdrPhone; set => cdrPhone = value; }
        public string Chef { get => chef; set => chef = value; }
        public int NbrSales { get => nbrSales; set => nbrSales = value; }
        public List<Produce> ListProduces { get => listProduces; set => listProduces = value; }




        public void changeAvailable(bool change)
        {
            available = change;
            string request = "UPDATE recipe SET change =" + change + " WHERE recipeName='" + name + "';";
            makeRequest(request);
        }

        public void changePrice(int value)
        {
            price = price + value;
            string request = "UPDATE recipe set price =" + price + " WHERE recipeName = '" + name + "';";
            makeRequest(request);
        }

        public void changeStock()
        {
            string request = "UPDATE produce NATURAL JOIN recipeContent " +
                "SET stock = stock - 1 " +
                "WHERE recipeName = '" + name + "';";
            makeRequest(request);
        }

        public void Delete()
        {
            string request = "DELETE FROM recipe where recipeName = '" + name + "';";
            makeRequest(request);
        }

        public void changeNrbSales(int quantity)
        {
            for(int i = 0; i<quantity;i++)
            {
                nbrSales++;
                if (nbrSales==10)
                {
                    changePrice(2);
                }
                if (nbrSales == 50)
                {
                    changePrice(5);
                }
            }
            string request = "UPDATE recipe set nbrSales =" + nbrSales + " WHERE recipeName = '" + name + "';";
            makeRequest(request);

        }

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
