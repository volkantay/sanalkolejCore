using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.DataAccess.Concrate.EntityFramework.Mappings
{
    public class ArticleMap:IEntityTypeConfiguration<Article>
    {
       

        public void Configure(EntityTypeBuilder<Article> builder)
        {

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
           
        }
    }
}
