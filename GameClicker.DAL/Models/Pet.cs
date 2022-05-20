using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.DAL.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DecreaseHpRegen { get; set; }
        public List<User> Users { get; set; }
        
    }
}
