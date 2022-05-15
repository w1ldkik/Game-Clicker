using GameClicker.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.DAL
{
    public  class DataHelper
    {
        public AuthContext authContext;


        public DataHelper(AuthContext authContext)
        {
            this.authContext = authContext;
        }

        public void AddPets() 
        {
            var pets = new List<Pet>();
            pets.Add(new Pet { Name = "Hamster", DecreaseHpRegen = 10 });
            pets.Add(new Pet { Name = "Cat", DecreaseHpRegen = 25 });
            pets.Add(new Pet { Name = "Dog", DecreaseHpRegen = 50 });
            authContext.AddRange(pets);
            authContext.SaveChanges();
        }

        public void AddWeapons()
        {
            var weapons = new List<Weapon>();
            weapons.Add(new Weapon { Name = "Pan", Damage = 10 });
            weapons.Add(new Weapon { Name = "Сlub", Damage = 25 });
            weapons.Add(new Weapon { Name = "Sword", Damage = 50 });
            authContext.AddRange(weapons);
            authContext.SaveChanges();
        }


    }
}
