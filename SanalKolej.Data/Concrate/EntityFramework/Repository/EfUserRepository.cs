using System;
using Microsoft.EntityFrameworkCore;
using SanalKolej.Core.Data.Concrate.EntityFramework;
using SanalKolej.Data.Abstract;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.Data.Concrate.EntityFramework.Repository
{
    public class EfUserRepository : EfEntityRepositoryBase<User>, IUserRepository
    {
        public EfUserRepository(DbContext context) : base(context)
        {
        }
    }
}
