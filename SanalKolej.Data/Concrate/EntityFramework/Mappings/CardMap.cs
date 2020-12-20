using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.DataAccess.Concrate.EntityFramework.Mappings
{
    public class CardMap:IEntityTypeConfiguration<Card>
    {
       

        public void Configure(EntityTypeBuilder<Card> builder)
        {

            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
           
        }
    }
}
