using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_Cook
{
    public class Produce
    {
        private string name;
        private int stock;
        private string supplier;

        public string Name { get => name; set => name = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Supplier { get => supplier; set => supplier = value; }

        public Produce(string name, string supplier, int stock)//to create a completly new produce 
        {
            this.name = name;
            this.supplier = supplier;
            this.stock = stock;

            //Insert into db
            string request = "INSERT INTO produce(nameProduce, supplierName, stock, stockMax, stockMin) VALUES('" +
                        name + "','" + supplier + "'," + stock + ", 50, 10);";
            makeRequest(request);
        }
        public Produce(string name)//to get the produce in DB
        {
            this.name = name;
            string request = "SELECT supplierName, stock FROM produce WHERE nameProduce ='" + name + "';";
            MySqlConnection myConnection = connectionServer();
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = request;
            MySqlDataReader reader = command.ExecuteReader();
            string[] data = new string[reader.FieldCount];
            while (reader.Read())
            {
                this.supplier = reader.GetValue(0).ToString();
                this.stock = Convert.ToInt32(reader.GetValue(1).ToString());
            }
            command.Dispose();
            myConnection.Close();

        }

        public void moreStock(int value)
        {
            stock = stock + value;
            string request = "UPDATE produce SET stock = " + stock + " where nameProduce = '" + name + "';";
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
