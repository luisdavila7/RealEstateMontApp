using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateMontApp
{
    class Sellers:Person
    {
        private int sellerid;
        private string password;

        public Sellers(string name, int age, int id, string email, int sellerid, string password):base(name,age, id,email)
        {
            this.sellerid = sellerid;
            this.password = password;
        }

        public int Sellerid { get => sellerid; set => sellerid = value; }
        public string Password { get => password; set => password = value; }
    }
}
