using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        
        }
        //public ApplicationDbContext()
        //{
        //    this.Database.GetConnectionString();
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (optionsBuilder == null)
        //    {
        //        optionsBuilder = new DbContextOptionsBuilder();
        //    }
        //    if (!optionsBuilder.IsConfigured)
        //    {

        //        var cs = "Server=localhost;Database=ExamCCI_2023;port=3306;user=root;password=cedric;";
        //        optionsBuilder.UseMySql(cs, ServerVersion.AutoDetect(cs));
        //        base.OnConfiguring(optionsBuilder);
        //    }
        //}
    }


}