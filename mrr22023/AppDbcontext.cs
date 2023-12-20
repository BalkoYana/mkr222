using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.SqlServer;



namespace mrr22023
{
    internal class AppDbcontext : DbContext
    {
        public AppDbcontext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Zavod>Zavods { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\mrr22023\mrr22023\Zavod.mdf;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zavod>().ToTable("Zavod");

        }



    }
}
