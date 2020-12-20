using System;
using System.Collections.Generic;
using SanalKolej.Core.Abstract;
using SanalKolej.Core.Entities.Abstract;

namespace SanalKolej.Entities.Concrate
{
    public class User:EntityBase,IEntity
    {
        public User()
        {
        }

       // public long UserID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string uid { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }

        public string PhotoURL { get; set; }
        public string Description { get; set; }

       // public int UserRoleID { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Article> UserArticles { get; set; }




    }
}
