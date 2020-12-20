using System;
using System.Collections.Generic;
using SanalKolej.Core.Abstract;
using SanalKolej.Core.Entities.Abstract;

namespace SanalKolej.Entities.Concrate
{
    public class Role:EntityBase,IEntity
    {
        public Role()
        {
        }

   // public int RoleID { get; set; }
    public string RoleName { get; set; }
    public string Description { get; set; }
    public ICollection<UserRole> RoleUsers { get; set; }

    }
}
