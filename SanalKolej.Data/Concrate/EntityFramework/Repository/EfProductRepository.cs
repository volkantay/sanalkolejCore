using System;
using Microsoft.EntityFrameworkCore;
using SanalKolej.Core.Data.Concrate.EntityFramework;
using SanalKolej.Data.Abstract;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.Data.Concrate.EntityFramework.Repository
{
    public class EfProductRepository : EfEntityRepositoryBase<Product>, IProductRepository
    {
        public EfProductRepository(DbContext context) : base(context)
        {
        }
    }
}
