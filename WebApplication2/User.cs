using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role role { get; set; }
        public override string ToString() => Id + ") " + Email + " - " + FirstName + " " + LastName + " " + role;
    }
}