using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PlanningAPI.Models;

namespace PlanningAPI.PlanningAPIContext
{
    public class PlanningAPIContext : DbContext
    {
        public PlanningAPIContext() : base("PlanningAPIContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.ComplexType<User>();
        }
    }
}