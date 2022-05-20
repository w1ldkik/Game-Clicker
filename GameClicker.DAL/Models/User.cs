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
       // public Weapon WeaponId { get; set; }
       // public Weapon Weapon { get; set; }
       // public Pet PetId { get; set; }
//        public Pet Pet { get; set; }
        public int BossNumber { get; set; }

    }
}
