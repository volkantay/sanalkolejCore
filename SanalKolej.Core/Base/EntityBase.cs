using System;
namespace SanalKolej.Core.Abstract
{
    public class EntityBase
    {
        public EntityBase()
        { }

        public virtual long ID { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual  DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; } = "Admin";
        public virtual string ModifiedByName { get; set; } ="Admin";
        public virtual string Note { get; set; }


    }
}
