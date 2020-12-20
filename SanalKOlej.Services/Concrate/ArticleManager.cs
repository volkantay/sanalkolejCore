using System;
using System.Threading.Tasks;
using AutoMapper;
using SanalKolej.Core.Result.Abstract;
using SanalKolej.Core.Result.Concrate;
using SanalKolej.Core.Result.ContextType;
using SanalKolej.DataAccess.Abstract;
using SanalKolej.Entities.Concrate;
using SanalKolej.Services.Abstract;

namespace SanalKolej.Services.Concrate
{
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<Article>> GetAllAsync()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(null, a => a.User);
            if (articles.Count > -1)
            {
                return new DataResult<Article>(ResultStatus.Success,null);
            }
            return new DataResult<Article>(ResultStatus.Error," Messages.Article.NotFound(isPlural: true", null);
        }
    }
}
