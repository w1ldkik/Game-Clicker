using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        
    }
}
