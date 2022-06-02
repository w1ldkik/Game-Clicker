using GameClicker.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GameClicker.DAL
{
    public class DataHelper
    {
        public AuthContext authContext;

        public DataHelper(AuthContext authContext) 
        { 
            this.authContext = authContext;
        }
        public void AddPet()
        {
            var pets = new List<Pet>() {
                new Pet(){
                    Name = "Hamster",
                    DecreaseHpRegen = 10
                },
                new Pet(){
                    Name = "Cat",
                    DecreaseHpRegen = 25
                },
                new Pet(){
                    Name = "Dog",
                    DecreaseHpRegen = 50
                } 
            };
            authContext.Pets.AddRange(pets);
            authContext.SaveChanges();
             
        }

        public void AddWeapon()
        {
            var weapons = new List<Weapon>() {
                new Weapon(){
                    Name = "Pan",
                    Damage = 10
                },
                new Weapon(){
                    Name = "club",
                    Damage = 25
                },
                new Weapon(){
                    Name = "Sword",
                    Damage = 50
                }
            };
            authContext.Weapons.AddRange(weapons);
            authContext.SaveChanges();
        }
        

        public void AddEnemy() 
        {
            var enemys = new List<Enemy>()
            {
                new Enemy(){ 
                    Name = "Roshan",
                    BossNumber = 1,
                    Hp = 2000,
                    HpRegen = 20
                },
                new Enemy(){
                    Name = "Leviofan",
                    BossNumber = 2,
                    Hp = 5000,
                    HpRegen = 50
                }
                
            };
            authContext.Enemies.AddRange(enemys);
            authContext.SaveChanges();
        }

    }
}
