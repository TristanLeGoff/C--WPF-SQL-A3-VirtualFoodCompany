using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_Cook
{
    class Fonction
    {
        public Fonction()
        {

        }

        public MySqlConnection connectionServer()
        {
            MySqlConnection myConnection;
            string connectionString = "SERVER=localhost;PORT=3306;" +
                                            "DATABASE=cooking;" +
                                            "UID=root;PASSWORD="+ ActiveSession.Instance.Password;

            myConnection = new MySqlConnection(connectionString);
            return myConnection;
        }
        

        public List<Recipe> listRecipeResearch(string value)
        {
            List<Recipe> listRecipe = new List<Recipe>();
            string request = "SELECT distinct(recipeName) FROM recipe " +
                             "NATURAL JOIN recipeContent NATURAL JOIN produce NATURAL JOIN client " +
                             "WHERE  available = true and recipeCreator = true " +
                             "and phone = clientPhone " +
                             "and (nameProduce LIKE '%" + value + "%' or recipeName LIKE '%" + value +
                             "%' or firstName LIKE '%" + value + "%' or lastName LIKE '%" + value + "%');";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            List<Recipe> nameRecipe = new List<Recipe>();
            while (reader.Read())
            {
                string name = reader.GetValue(0).ToString();
                Recipe recipe = new Recipe(name);
                nameRecipe.Add(recipe);
            }
            command.Dispose();
            myConnection.Close();
            reader.Dispose();
            for (int i = 0; i < nameRecipe.Count; i++)
            {
                myConnection = connectionServer();
                myConnection.Open();
                string name = nameRecipe[i].Name;
                request = "SELECT nameProduce FROM recipeContent NATURAL JOIN produce " +
                    "WHERE recipeName = '" + name + "' AND stock >= stockMin;";
                command = myConnection.CreateCommand();
                command.CommandText = request;
                MySqlDataReader reader2 = command.ExecuteReader();
                List<string> listProducesAvailable = new List<string>();
                while (reader2.Read())
                {
                    listProducesAvailable.Add(reader2.GetValue(0).ToString());
                }
                if (listProducesAvailable.Count == nameRecipe[i].ListProduces.Count)
                {
                    Recipe recipe = new Recipe(nameRecipe[i].Name);
                    listRecipe.Add(recipe);
                }
                command.Dispose();
                reader.Dispose();
                myConnection.Close();
            }
            return listRecipe;
        }

        public List<Produce> listProduce()
        {
            List<Produce> listProduce = new List<Produce>();
            string request = "SELECT distinct(nameProduce) FROM produce;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetValue(0).ToString();
                Produce produce = new Produce(name);
                listProduce.Add(produce);
            }
            myConnection.Close();
            return listProduce;
        }

        public void VerifyIfRecipeUsed()
        {
            //select all produces that has been used since 1 months
            string timeNow = Convert.ToString(DateTime.Now);
            string time1MonthAgo = Convert.ToString(DateTime.Now.AddMonths(-1));
            string request = "SELECT distinct(nameProduce) from produce NATURAL JOIN recipeContent " +
                "where recipeName in " +
                "(Select distinct(recipeName) FROM cart NATURAL JOIN ordertab WHERE date BETWEEN '" + time1MonthAgo +"' AND '" + timeNow +"');";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            List<string> listProducesUsed = new List<string>();
            while (reader.Read())
            {
                string nameProduceUsed = reader.GetValue(0).ToString();
                listProducesUsed.Add(nameProduceUsed);
            }
            List<string> listProducesUnused = new List<string>();
            List<Produce> allProduces = listProduce();
            //Determine produces which are unused since 1 month
            for (int i = 0; i < allProduces.Count; i++)
            {
                if (listProducesUsed.Contains(allProduces[i].Name) == false)
                {
                    listProducesUnused.Add(allProduces[i].Name);
                }
            }
            command.Dispose();
            myConnection.Close();
            reader.Dispose();
            //to change the stock of the unused produces
            for (int i = 0; i < listProducesUnused.Count; i++)
            {
                request = "UPDATE produce SET stockMax = stockMax/2 WHERE nameProduce = '" + listProducesUnused[i] + "';";
                makeRequest(request);
                request = "UPDATE produce SET stockMin = stockMin/2 WHERE nameProduce = '" + listProducesUnused[i] + "';";
                makeRequest(request);
            }
        }

        public List<Produce> listProduceX2()
        {
            List<Produce> listProduce = new List<Produce>();
            string request = "SELECT distinct(nameProduce) FROM produce WHERE stock>2*stockMin;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetValue(0).ToString();
                Produce produce = new Produce(name);
                listProduce.Add(produce);
            }
            myConnection.Close();
            return listProduce;
        }

        public List<Client> listClient()
        {
            List<Client> listClient = new List<Client>();
            string request = "SELECT * FROM client;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string phone = reader.GetValue(0).ToString();
                Client c = new Client(phone);
                listClient.Add(c);
            }
            myConnection.Close();
            return listClient;
        }

        public List<Transaction> listTransaction()
        {
            List<Transaction> listTransaction = new List<Transaction>();
            string request = "SELECT * FROM transaction;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader.GetValue(0).ToString());
                Transaction t = new Transaction(id);
                listTransaction.Add(t);
            }
            myConnection.Close();
            return listTransaction;
        }

        public List<Recipe> listRecipe()
        {
            List<Recipe> listRecipe = new List<Recipe>();
            //we select all recipes wich are available
            string request = "SELECT distinct(recipeName) FROM recipeContent NATURAL JOIN recipe " +
                "WHERE available = TRUE;  ";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            List<Recipe> nameRecipe = new List<Recipe>();
            while (reader.Read())
            {
                string name = reader.GetValue(0).ToString();
                Recipe recipe = new Recipe(name);
                nameRecipe.Add(recipe);
            }
            command.Dispose();
            myConnection.Close();
            reader.Dispose();
            ///
            for (int i = 0; i < nameRecipe.Count; i++)
            {
                myConnection = connectionServer();
                myConnection.Open();
                string name = nameRecipe[i].Name;
                request = "SELECT nameProduce FROM recipeContent NATURAL JOIN produce " +
                    "WHERE recipeName = '" + name + "' AND stock >= stockMin;";
                command = myConnection.CreateCommand();
                command.CommandText = request;
                MySqlDataReader reader2 = command.ExecuteReader();
                List<string> listProducesAvailable = new List<string>();
                while (reader2.Read())
                {
                    listProducesAvailable.Add(reader2.GetValue(0).ToString());
                }
                if (listProducesAvailable.Count == nameRecipe[i].ListProduces.Count)
                {
                    Recipe recipe = new Recipe(nameRecipe[i].Name);
                    listRecipe.Add(recipe);
                }
                command.Dispose();
                reader.Dispose();
                myConnection.Close();
            }
            return listRecipe;
        }

        public void VerifyAndAddStock()
        {
            string request = "UPDATE produce SET stock = stock + 10 " +
                "WHERE nameProduce IN " +
                "(SELECT * FROM (SELECT nameProduce FROM produce WHERE stock<stockMin) as x);";
            makeRequest(request);
        }

        public int countRecipe()
        {
            string request = "SELECT count(recipeName) FROM recipe";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return Convert.ToInt32(reader.GetValue(0));
            }
            command.Dispose();
            myConnection.Close();
            return 0;
        }
        public Dictionary<Client, int> listCDR()
        {
            string request = "SELECT clientPhone,sum(nbrSales) from recipe " +
                "where clientPhone in " +
                "(SELECT phone FROM client WHERE recipeCreator = true) " +
                "group by clientPhone;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            Dictionary<Client, int> dictCDR = new Dictionary<Client, int>();
            while (reader.Read())
            {
                Client CDR = new Client(reader.GetValue(0).ToString());
                dictCDR.Add(CDR, Convert.ToInt32(reader.GetValue(1)));
            }
            return dictCDR;
        }

        public List<Recipe> Top1CreatorEver()
        {
            List<Recipe> listRecipe = new List<Recipe>();
            string request = "SELECT distinct(recipeName) from recipe " +
                "WHERE clientphone = (Select clientPhone from recipe group by clientPhone order by sum(nbrSales) DESC LIMIT 1);";
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

        //Return a desc list of the 5 most popular recipes ever
        public List<Recipe> Top5RecipesEver()
        {
            List<Recipe> listRecipe = new List<Recipe>();
            string request = "SELECT recipeName FROM recipe ORDER BY nbrSales DESC LIMIT 5;";
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

        //not necessary
        //Return a desc list of the 5 most popular recipes for the last week
        public List<Recipe> Top5RecipesOfTheWeek()
        {
            List<Recipe> listRecipe = new List<Recipe>();
            string timeNow = Convert.ToString(DateTime.Now);
            Console.WriteLine(timeNow);
            string time7daysAgo = Convert.ToString(DateTime.Now.AddDays(-7));
            Console.WriteLine(time7daysAgo);
            string request = "SELECT recipeName FROM cart " +
                "WHERE orderID IN " +
                "(Select orderID FROM orderTab WHERE date BETWEEN '" + time7daysAgo + "' AND '" + timeNow + "')" +
                "GROUP BY recipeName " +
                "ORDER BY sum(quantity) DESC " +
                 "LIMIT 5; ";
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

        //return the top1 recipe creator since 7 days from now
        public Client Top1CreatorOfTheWeek()
        {
            string timeNow = Convert.ToString(DateTime.Now);
            Console.WriteLine(timeNow);
            string time7daysAgo = Convert.ToString(DateTime.Now.AddDays(-7));
            Console.WriteLine(time7daysAgo);
            string request = "SELECT clientPhone FROM cart NATURAL JOIN recipe " +
                "WHERE orderID IN " +
                "(Select orderID FROM orderTab WHERE date BETWEEN '" + time7daysAgo + "' AND '" + timeNow + "') " +
                "GROUP BY clientPhone " +
                "ORDER BY sum(quantity) DESC " +
                "LIMIT 1;";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string clientPhone = reader.GetValue(0).ToString();
                Client bestRecipeCreator = new Client(clientPhone);
                command.Dispose();
                myConnection.Close();
                return bestRecipeCreator;
            }
            return null;
        }

        public void makeRequest(string request)
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
