using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = EMIR-OZDAG;database = corepersonel; integrated security = true;");    
        }
        public DbSet<Departments> departments { get; set; }
        public DbSet<Personel> personels { get; set; }
    }
}
