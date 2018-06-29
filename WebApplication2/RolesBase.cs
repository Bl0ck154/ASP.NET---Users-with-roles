using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class RolesBase
    {
        List<string> list = new List<string>();
        static RolesBase _instance;
        static public RolesBase Instance => _instance ?? (_instance = new RolesBase());
        private RolesBase() { }

        public void Create(string name) => list.Add(name);
        public bool Remove(string RoleName) => list.Remove(RoleName);
        public IEnumerable<string> GetAll() => list;
    }
}