using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanningAPI.Models;

namespace PlanningAPI.Services
{
    public class UserService
    {
        private PlanningAPIContext.PlanningAPIContext db = new PlanningAPIContext.PlanningAPIContext();

        public IEnumerable<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public User GetUser(long id)
        {
            return db.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}