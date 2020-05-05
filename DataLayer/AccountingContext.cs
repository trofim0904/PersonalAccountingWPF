using DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AccountingContext : DbContext
    {
        public AccountingContext() : base("AccountingDB")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CashCount> CashCounts { get; set; }
        public DbSet<CashCountAction> CashCountActions { get; set; }
        public DbSet<CashCountActionCategory> CashCountActionCategories { get; set; }
    }
}
