using GameClicker.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.DAL.Repositories
{
    public class EnemyRepository
    {
        public AuthContext authContext;
        public EnemyRepository(AuthContext authContext)
        {
            this.authContext = authContext;
        }

        public Enemy GetEnemyByBossNumber(int bossNumber) 
        {
            return authContext.Enemies.Where(x=>x.BossNumber == bossNumber).FirstOrDefault();
        }
    }
}
