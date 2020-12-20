using System;
using System.Threading.Tasks;
using SanalKolej.Core.Result.Abstract;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.Services.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<Article>> GetAllAsync();
       
       
    }
}
