using Microsoft.EntityFrameworkCore;
using TishakovaSofya42_22.DataBase.Configurations;
using TishakovaSofya42_22.Models;

namespace TishakovaSofya42_22.DataBase
{
    public class StudentDbContext: DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Group> groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
        }
        
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
    }
}

