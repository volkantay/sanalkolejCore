using SanalKolej.Core.Abstract;
using SanalKolej.Core.Entities.Abstract;

namespace SanalKolej.Entities.Concrate
{
    public class UserRole:EntityBase,IEntity
    {
       // public int UserRoleID { get; set; }
        public User User { get; set; }
        public long UserID { get; set; }

        public Role Role { get; set; }
        public long RoleID { get; set; }
    }
}