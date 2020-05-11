using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEFTPCStrategyFW
{
    class Context : DbContext
    {
        public Context() : base("BillingConnectionString")
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
        }

        public DbSet<BillingDetail> BillingDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BankAccount>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("BankAccounts");
            });

            modelBuilder.Entity<CreditCard>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("CreditCards");
            });
        }
    }
}