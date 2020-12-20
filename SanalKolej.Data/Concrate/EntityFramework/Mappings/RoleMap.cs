using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.DataAccess.Concrate.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
        }

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.RoleName).IsRequired();
            builder.HasData(
                new Role {
               ID =1,
                RoleName ="Admin",
                Description ="Yönetici",
                CreatedByName  ="Initial Create",
                
            }, new Role
            {
                ID = 2,
                RoleName = "User",
                Description = "Kullanıcı",
                CreatedByName = "Initial Create",
            }


            );



        }
    }
}
