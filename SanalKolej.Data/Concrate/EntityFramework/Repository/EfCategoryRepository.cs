using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SanalKolej.Core.Data.Concrate.EntityFramework;
using SanalKolej.Core.Entities.Abstract;
using SanalKolej.Data.Abstract;
using SanalKolej.Data.Concrate.EntityFramework.Contexts;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.Data.Concrate.EntityFramework.Repository
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
       

        public async Task<Category> GetById(int categoryId)
        {
            return await SanalKolejContext.Categories.SingleOrDefaultAsync(c => c.ID == categoryId);

        }

        private SanalKolejContext SanalKolejContext
        {
            get
            {
                return _context as SanalKolejContext;
            }
        }
    }
}
