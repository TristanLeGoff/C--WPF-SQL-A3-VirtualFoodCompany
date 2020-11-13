using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_Cook
{
    class Transaction
    {
        private int transactionId;
        private double value;
        private string date;
        private string clientPhone;
        private string why;

        public int TransactionId { get => transactionId; set => transactionId = value; }
        public double Value { get => value; set => this.value = value; }
        public string Date { get => date; set => date = value; }
        public string ClientPhone { get => clientPhone; set => clientPhone = value; }
        public string Why { get => why; set => why = value; }

        //for a completly new transaction
        public Transaction(string clientPhone, double value, string why)
        {
            //determine newId
            int newId = determineId();
            this.transactionId = newId;
            //complete object
            this.clientPhone = clientPhone;
            this.value = value;
            this.why = why;
            this.date = Convert.ToString(DateTime.Now);
            //Insert into DB
            string request = "INSERT INTO transaction(transactionID, value, date, clientPhone, why) " +
                            "VALUES (" + transactionId + "," + value + ",'" + date + "','" + clientPhone + "','" + why + "');";
            makeRequest(request);
        }
        //for an old transaction
        public Transaction(int transactionId)
        {
            this.transactionId = transactionId;
            string request = "SELECT date,clientPhone,value,why from transaction WHERE  transactionID =" + transactionId + ";";
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
                this.clientPhone = data[1];
                this.value = Convert.ToDouble(data[2]);
                this.why = data[3];
            }
            command.Dispose();
            myConnection.Close();
        }
        private int determineId()
        {
            string request = "SELECT MAX(transactionID) from transaction;";
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
            int newId = maxId + 1;
            command.Dispose();
            myConnection.Close();
            return newId;
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
