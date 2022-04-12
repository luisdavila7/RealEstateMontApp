using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateMontApp
{
    class Person
    {

        private string name;
        private int age;
        private int id;
        private string email;

        public Person(string name, int age, int id, string email)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.email = email;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }





    }
}
