using System;
using System.Threading.Tasks;
using SanalKolej.Data.Abstract;

namespace SanalKolej.DataAccess.Abstract
{


    public interface IUnitOfWork:IAsyncDisposable
    {
        //Bütün repositorlerimize tek bir noktadan erişim sağlayalım


        IArticleRepository Articles{ get;  }
        IUserRepository Users{ get; }
        IUserRoleRepository UserRoles { get;  }
        IRoleRepository Roles{ get;  }
        ICardRepository Cards{ get;  }
        ICategoryRepository Categories { get;  }

        Task<int> SaveAsync();

        //Kullanımı
        //_uow.Category.AddAsync(category);
        //_uow.SaveAsync();




    }
}
