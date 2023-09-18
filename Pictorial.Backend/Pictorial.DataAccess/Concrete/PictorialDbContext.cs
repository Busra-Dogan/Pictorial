using Microsoft.EntityFrameworkCore;
using Pictorial.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.DataAccess.Concrete
{
    public class PictorialDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ARC106NB\SQLEXPRESS;Database=Pictorial;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Member> MEMBER { get; set; }
        public DbSet<Course> COURSE { get; set; }
        public DbSet<Word> WORD { get; set; }
        public DbSet<Category> CATEGORY{ get; set; }
        public DbSet<Language> LANGUAGE{ get; set; }
        public DbSet<Authority> Authority{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");

            //Map entity to table
            modelBuilder.Entity<Member>().ToTable("MEMBER", "MEM");
            modelBuilder.Entity<Course>().ToTable("COURSE", "CRS");
            modelBuilder.Entity<Word>().ToTable("WORD", "CRS");
            modelBuilder.Entity<Category>().ToTable("CATEGORY", "CRS");
            modelBuilder.Entity<Language>().ToTable("LANGUAGE", "CRS");
            modelBuilder.Entity<Authority>().ToTable("Authority", "AUT");
        }
    }
}
