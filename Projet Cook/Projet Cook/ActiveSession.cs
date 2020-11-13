using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Cook
{
    public class ActiveSession
    {

        private static ActiveSession instance;

        public static ActiveSession Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ActiveSession("ERREUR","ERREUR");
                }
                return instance;
            }
        }



        private string phone;
        private string password;

        public ActiveSession(string phone,string password)
        {
            this.phone = phone;
            this.password = password;
   
        }

        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
    }
}
