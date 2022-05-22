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
        public UserRepository userRepository;
        public DataConteiner dataConteiner;
        public EnemyService(EnemyRepository enemyRepository, UserRepository userRepository, DataConteiner dataConteiner)
        {
            this.enemyRepository = enemyRepository;
            this.userRepository = userRepository;
            this.dataConteiner = dataConteiner;
        }

        public Enemy GetEnemyByBossNumber(int bossNumber) 
        {
            return enemyRepository.GetEnemyByBossNumber(bossNumber);    
        }

        public void ScaleBossLvl() 
        {
            dataConteiner.User.BossNumber++;
            userRepository.Update(dataConteiner.User);
        }

    }
}
