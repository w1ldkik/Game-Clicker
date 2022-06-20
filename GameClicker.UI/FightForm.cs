using GameClicker.BLL;
using GameClicker.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClicker.UI
{
    public partial class FightForm : Form
    {
        private string PreparationFormName { get; set; } = "PreparationForm";
        public DataConteiner dataConteiner;
        public EnemyService enemyService;
        private Enemy enemy;
        private double bossMaxHp;

       
        public FightForm(DataConteiner dataConteiner, EnemyService enemyService)
        {
            InitializeComponent();
            this.dataConteiner = dataConteiner;
            this.enemyService = enemyService;
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            enemy.Hp = enemy.Hp - dataConteiner.User.Weapon.Damage;
            if (enemy.Hp > 0)
            {
                hpLabel.Text = enemy.Hp.ToString();
            }
            else 
            {
                enemyService.ScaleBossLvl();
                timer1.Stop();
                // Победа над боссом визуал
                var preparationForm = (PreparationForm) Application.OpenForms.Cast<Form>().Where(x=>x.Name == PreparationFormName).FirstOrDefault()!;
                preparationForm.RefreshDataSource();
                preparationForm.Show();
                this.Hide();
                
                
            }

            
        }

        private void FightForm_Load(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (enemy.Hp < bossMaxHp)
            {
                if (enemy.Hp + enemy.HpRegen <= bossMaxHp)
                {
                    hpLabel.Text = enemy.Hp.ToString();
                    enemy.Hp = enemy.Hp + enemy.HpRegen;
                    
                }
                else
                {
                    enemy.Hp = bossMaxHp;
                }
            }
        }
        public void RefreshDataSource()
        {
            enemy = enemyService.GetEnemyByBossNumber(dataConteiner.User.BossNumber);
            enemy.HpRegen = enemy.HpRegen * (1 - dataConteiner.User.Pet.DecreaseHpRegen / 100);
            bossMaxHp = enemy.Hp;
            timer1.Interval = 1000;
            timer1.Start();
            hpLabel.Text = "HP: " + enemy.Hp.ToString();
            damageLabel.Text = dataConteiner.User.Weapon.Damage.ToString() + " Damage/click";
            hpRegenLabel.Text = "+" + enemy.HpRegen.ToString() + " HP/second";
            switch (enemy.BossNumber)
            {
                case 1:
                    bossPictureBox.Image = GameClicker.UI.Properties.Resources.bossRoshan;
                    break;
                case 2:
                    bossPictureBox.Image = GameClicker.UI.Properties.Resources.Leviofan;
                    break;
                default:
                    break;
            }
        }
           
        
    }
}
