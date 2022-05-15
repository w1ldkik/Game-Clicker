using GameClicker.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClicker.DAL
{
    public class AuthContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AuthDatabase;Trusted_Connection=True;";
       
        public AuthContext()
        {

        }
        public AuthContext(DbContextOptions options) : base(options)
        {

        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<User> Users { get; set; }
    }
}
