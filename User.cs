using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingRecipe
{
    public class User
    {
        //account(usernamme, password, firstname, lastname, email address, bdate, address, phonenumber)
        public string Name { get; set; }
        public string Email { get;private set; }
        private string password;
        public string Address { get; set; }
        public DateTime Birtdate { get; set; }
        public string Phonenumber { get; set; }

        public User(string name, string email, string password, string address, DateTime birtdate, string phonenumber)
        {
            this.Name = name;
            this.Email = email;
            this.password = password;
            this.Address = address;
            this.Birtdate = birtdate;
            this.Phonenumber = phonenumber;
        }
    }
}
