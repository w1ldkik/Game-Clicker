using GameClicker.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.DAL
{
    public class DataHelper
    {
        public AuthContext authContext;

        public DataHelper(AuthContext authContext) 
        { 
            this.authContext = authContext;
        }

        public void AddEnemy() 
        {
            var enemys = new List<Enemy>()
            {
                new Enemy(){ 
                    Name = "Roshan",
                    BossNumber = 1,
                    Hp = 2000,
                    HpRegen = 5
                },
                new Enemy(){
                    Name = "Leviofan",
                    BossNumber = 2,
                    Hp = 5000,
                    HpRegen = 10
                }
                
            };
            authContext.Enemies.AddRange(enemys);
            authContext.SaveChanges();
        }

    }
}
