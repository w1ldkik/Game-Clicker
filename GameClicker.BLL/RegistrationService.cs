using GameClicker.DAL.Models;
using GameClicker.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.BLL
{
    public class RegistrationService
    {
        public UserRepository userRepository;

        public RegistrationService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void RegistrateUser(string login, string password)
        {
            /// Проверки
            
            var user = new User()
            {
                Login = login,
                Password = password,
                PetId = 3,
                WeaponId = 3
            };
            userRepository.AddUser(user);
        }
    }
}
