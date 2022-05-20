using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.DAL.Models
{
    public class Enemy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Hp { get; set; }
        public double HpRegen { get; set; }
        public int BossNumber { get; set; }
    }
}
