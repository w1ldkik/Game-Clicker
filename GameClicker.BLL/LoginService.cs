using GameClicker.DAL.Models;
using GameClicker.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.BLL
{
    public class LoginService
    {
        public UserRepository userRepository;

        public LoginService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User Login(string login, string password) 
        {
            return userRepository.GetUserByLoginAndPassword(login, password);
        }
    }

}
