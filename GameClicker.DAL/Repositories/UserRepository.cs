using GameClicker.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.DAL.Repositories
{
    public class UserRepository
    {
        public AuthContext authContext;

        public UserRepository(AuthContext authContext)
        {
            this.authContext = authContext;
        }

        public void AddUser(User user)
        {
            authContext.Users.Add(user);
            authContext.SaveChanges();
        }

        public User GetUserByLoginAndPassword(string login, string password)
        {
            return authContext.Users.Where(u => u.Password == password && u.Login == login).AsNoTracking().Include(x=>x.Pet).Include(x => x.Weapon).FirstOrDefault();
        }

        public void Update(User updatedUser) 
        {
            authContext.Update(updatedUser);
            authContext.SaveChanges();
        }
    }
}