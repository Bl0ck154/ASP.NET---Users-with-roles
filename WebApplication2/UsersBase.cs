using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class UsersBase
    {
        List<User> list = new List<User>();
        static UsersBase _instance;
        static public UsersBase Instance => _instance ?? (_instance = new UsersBase());
        private UsersBase() { }

        public void Create(User user)
        {
            user.Id = (list.LastOrDefault()?.Id ?? 0) + 1;
            list.Add(user);
        }
        public User Get(string UserString) => list.Find(user => user.ToString() == UserString);
        public bool Remove(string UserString) => list.Remove(Get(UserString));
        public IEnumerable<User> GetAll() => list;
    }
}