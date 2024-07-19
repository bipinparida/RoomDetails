using AdminApi.Models.App.Persons;
using AdminApi.Models.Helper;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;

namespace AdminApi.Models
{
    public class AppDbContext:DbContext
    {     
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<LogHistory> LogHistory { get; set; }
        public virtual DbSet<AppMenu> Menu { get; set; }
        public virtual DbSet<MenuGroup> MenuGroup { get; set; }
        public virtual DbSet<MenuGroupWiseMenuMapping> MenuGroupWiseMenuMapping { get; set; }
      
        public virtual DbSet<Person> Persons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.Seed();//use this for Sql server,Mysql,Sqlite and PostgreSql
                                //modelBuilder.SeedOracle();//use this only for Oracle
            #region 


            //modelBuilder.Entity<HospitalMaster>()
            //  .Property(s => s.CreatedOn)
            //  .HasDefaultValue(System.DateTime.Now);

            //modelBuilder.Entity<HospitalMaster>()
            //  .Property(s => s.IsDeleted)
            //  .HasDefaultValue(false)
            //  .ValueGeneratedNever();

            modelBuilder.Entity<Person>()
              .Property(s => s.CreatedOn)
              .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Person>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();



            #endregion
        }

    }
}
