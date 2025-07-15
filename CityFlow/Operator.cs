using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public class Operator
    {
        public Operator(Guid id, string login, string passwordHash, string firstName, string lastName)
        {
            Id = id;
            Login = login;
            PasswordHash = passwordHash;
            FirstName = firstName;
            LastName = lastName;
        }

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
