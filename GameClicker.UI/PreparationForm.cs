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
            var boss = enemyService.GetEnemyByBossNumber(dataConteiner.User.BossNumber);
            lvlLabel.Text = boss.BossNumber.ToString();
            bossNameLabel.Text = boss.Name;
            bossHpLabel.Text = boss.Hp.ToString();
            BossHpRegenLabel.Text = boss.HpRegen.ToString();
        }

        private void fightButton_Click(object sender, EventArgs e)
        {
            fightForm.Show();
        }
    }
}
