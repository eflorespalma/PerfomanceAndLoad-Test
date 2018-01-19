using Course.Entity;
using System.Data.Entity;

namespace Course.Data
{
    public class DatabaseService : DbContext
    {
        public IDbSet<Person> Person { get; set; }

        public DatabaseService() : base("cn")
        {
        }

        public void Save()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}
