using GameClicker.BLL;
using GameClicker.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClicker.UI
{
    public partial class PreparationForm : Form
    {
        public EnemyService enemyService;
        public DataConteiner dataConteiner;
        public FightForm fightForm;
        public PreparationForm( EnemyService enemyService, DataConteiner dataConteiner, FightForm fightForm)
        {
            InitializeComponent();
            this.dataConteiner = dataConteiner;
            this.enemyService = enemyService;
            this.fightForm = fightForm;

        }


        private void backMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form mainform = Application.OpenForms[1];
            mainform.Show();

        }

        private void PreparationForm_Load(object sender, EventArgs e)
        {
            RefreshDataSource();
            
        }

        public void RefreshDataSource()
        {
            var boss = enemyService.GetEnemyByBossNumber(dataConteiner.User.BossNumber);
            if (boss is not null)
            {
                lvlLabel.Text = "Level: " + boss.BossNumber.ToString();
                bossNameLabel.Text = boss.Name;
                bossHpLabel.Text = "Boss HP: " + boss.Hp.ToString();
                BossHpRegenLabel.Text = "Boss HP regen: " + boss.HpRegen.ToString() + "% per second";
            }
            else
            {
                MessageBox.Show("Test");
            }
            switch (boss.BossNumber.ToString())
            {
                case "1":
                    bossPictureBox.Image = GameClicker.UI.Properties.Resources.bossRoshan;
                    break;
                default:
                    break;
            }
        }
        private void fightButton_Click(object sender, EventArgs e)
        {
            fightForm.RefreshDataSource();
            Hide();
            fightForm.Show();
        }
    }
}
