using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SanalKolej.Core.Data.Abstract;
using SanalKolej.Core.Entities.Abstract;

using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SanalKolej.Core.Data.Concrate.EntityFramework
{
    public class EfEntityRepositoryBase<Tentity> : IEntityRepository<Tentity>
    where Tentity : class, IEntity, new()
    {

       
        protected readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public  async Task AddAsync(Tentity entity)
        {
             await _context.Set<Tentity>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<Tentity, bool>> predicate)
        {
            return  await _context.Set<Tentity>().AnyAsync(predicate);
        }

        public async Task<int> Count(Expression<Func<Tentity, bool>> predicate)
        {
            return  await _context.Set<Tentity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(Tentity entity)
        {
             await Task.Run(()=> _context.Set<Tentity>().Remove(entity));
        }

        public async Task<IList<Tentity>> GetAllAsync(Expression<Func<Tentity, bool>> predicate = null, params Expression<Func<Tentity, object>>[] includeProperties)
        {
            IQueryable<Tentity> query = _context.Set<Tentity>();

            if(predicate!=null){
                query= query.Where(predicate);
            }

            if(includeProperties.Any())
            {
                foreach(var property in includeProperties){
                    query = query.Include(property);
                }


            }

            return await query.ToListAsync();
        

        }

        public async Task<Tentity> GetAsync(Expression<Func<Tentity, bool>> predicate,
         params Expression<Func<Tentity, object>>[] includeProperties)
        {
             IQueryable<Tentity> query = _context.Set<Tentity>();

            if(predicate!=null){
                query= query.Where(predicate);
            }

            if(includeProperties.Any())
            {
                foreach(var property in includeProperties){
                    query = query.Include(property);
                }


            }

            return await query.SingleOrDefaultAsync();
        }

        public async Task<Tentity> GetByIdAsync(int Id)
        {
            //return await Task.Run(()=> _context.Set<Tentity>().FindAsync(Id));
            //test etmek gerekiyor
            return  await _context.Set<Tentity>().Where(x=>x.Equals(Id)).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Tentity entity)
        {
             await Task.Run(()=> _context.Set<Tentity>().Update(entity));
        }
    }
}