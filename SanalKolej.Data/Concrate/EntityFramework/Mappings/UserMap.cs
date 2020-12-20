using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.DataAccess.Concrate.EntityFramework.Mappings
{
    public class UserMap:IEntityTypeConfiguration<User>
    {
        

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.ID);//primary key alanı
            builder.Property(x => x.ID).ValueGeneratedOnAdd();//otomatik olarak artsın
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.DisplayName).HasMaxLength(20);
            builder.Property(x => x.PasswordHash).IsRequired();
            builder.Property(x => x.PasswordHash).HasColumnType("VARBINARY(500)");
            builder.HasData(
               new User
               {
                   ID = 1,
                   FirstName = "Admin",
                   LastName = "Tay",
                   Email = "volkantay@gmail.com",
                   CreatedByName = "Initial Create",
                   PhoneNumber = "+905327206212",
                   PasswordHash = Encoding.ASCII.GetBytes("e10adc3949ba59abbe56e057f20f883e"),//123456
                      Description = "Açıklama"
               }


           ) ;

        }
    }
}
