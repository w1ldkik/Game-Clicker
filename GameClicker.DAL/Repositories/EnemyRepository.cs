using GameClicker.DAL.Models;
using Microsoft.EntityFrameworkCore;
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
            return authContext.Enemies.Where(x=>x.BossNumber == bossNumber).AsNoTracking().FirstOrDefault();
        }

        public int GetBossQuantity()
        {
            return authContext.Enemies.Select(x => x).Count();
        }
    }
}
