using GameClicker.DAL.Models;
using GameClicker.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.BLL
{
    public class EnemyService
    {
        public EnemyRepository enemyRepository;
        public EnemyService(EnemyRepository enemyRepository)
        {
            this.enemyRepository = enemyRepository;
        }

        public Enemy GetEnemyByBossNumber(int bossNumber) 
        {
            return enemyRepository.GetEnemyByBossNumber(bossNumber);    
        }


    }
}
