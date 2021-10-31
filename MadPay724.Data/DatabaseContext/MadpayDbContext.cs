using MadPay724.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadPay724.Data.DatabaseContext
{
    class MadpayDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=PC;Initial Catalog=MadPay724db;Integrated Security=True;MultipleActiveResultSets=True;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<BankCard> BankCards { get; set; }
    }
}
