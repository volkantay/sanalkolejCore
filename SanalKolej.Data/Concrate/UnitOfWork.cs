using System;
using System.Threading.Tasks;
using SanalKolej.Data.Abstract;
using SanalKolej.Data.Concrate.EntityFramework.Contexts;
using SanalKolej.Data.Concrate.EntityFramework.Repository;
using SanalKolej.DataAccess.Abstract;

namespace SanalKolej.DataAccess.Concrate
{
    public class UnitOfWork:IUnitOfWork
    {

        private readonly SanalKolejContext _context;

         public UnitOfWork(SanalKolejContext context)
        {
            _context = context;
        }


        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfUserRepository _userRepository;
        private EfRoleRepository _roleRepository;
        private EfUserRoleRepository _userRoleRepository;
        private EfCardRepository _cardRepository;
        private EfProductRepository _productRepository;




        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public IUserRoleRepository UserRoles => _userRoleRepository ?? new EfUserRoleRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);

        public ICardRepository Cards => _cardRepository ?? new EfCardRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);
       

        public IProductRepository Products => _productRepository ?? new EfProductRepository(_context);




        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
