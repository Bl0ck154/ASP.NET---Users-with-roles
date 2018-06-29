using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Role
    {
        public string Name { get; set; }
        public override string ToString() => Name;
        public Role(string name)
        {
            Name = name;
        }
    }
}