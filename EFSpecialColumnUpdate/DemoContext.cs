using Microsoft.EntityFrameworkCore;

namespace EFSpecialColumnUpdate
{
    //Update-Database
    public class DemoContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=RASHAD-NY;Initial Catalog=DemoDatabase;Integrated Security=True");
        }
    }
}
