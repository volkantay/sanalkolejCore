using System;
using Microsoft.EntityFrameworkCore;
using SanalKolej.Core.Base;
using SanalKolej.DataAccess.Concrate.EntityFramework.Mappings;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.Data.Concrate.EntityFramework.Contexts
{
    public class SanalKolejContext:DbContext
    {
        public SanalKolejContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("Data Source=SanalKolej.db;");

            //optionsBuilder.UseSqlite($"Data Source={_appHost.ContentRootPath}/data.db");

            // optionsBuilder.UseSqlServer( @"Server = (localdb);Database:SanalKolej;TrustedConneciton:true;" );
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
         

        }

    }





}
