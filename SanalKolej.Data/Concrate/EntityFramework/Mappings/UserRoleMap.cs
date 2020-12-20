using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.DataAccess.Concrate.EntityFramework.Mappings
{
    public class UserRoleMap:IEntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
        }

        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            
        }
    }
}
