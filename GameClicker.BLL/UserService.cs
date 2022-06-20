using GameClicker.DAL.Models;
using GameClicker.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.BLL
{
    public class UserService
    {
        public UserRepository userRepository;
        public DataConteiner dataConteiner;
        public UserService(UserRepository userRepository, DataConteiner dataConteiner)
        {
            this.userRepository = userRepository;
            this.dataConteiner = dataConteiner;
        }

        public void UpdateUser()
        {
            userRepository.Update(dataConteiner.User);
        }
           
        public User GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }
    }
}
