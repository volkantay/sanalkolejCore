using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.DataAccess.Concrate.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {



        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.CategoryName).IsRequired();
            builder.HasData(
                new Category
                {
                    ID = 1,
                    CategoryName = "C#",
                    Description = "Açıklama"

                }


                ); ; ;
            
        }
    }
}
