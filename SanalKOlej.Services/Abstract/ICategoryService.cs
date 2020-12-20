using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SanalKolej.Core.Result.Abstract;
using SanalKolej.Entities.Concrate;
using SanalKolej.Entities.Dtos;

namespace SanalKolej.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllNonDeleted();
        Task<IResult> Add(CategoryAddDto categoryDto,string creatingByName);
        Task<IResult> Update(CategoryAddDto categoryDto, string modifiedByName);
        Task<IResult> Delete(int categoryId,string modifiedByName);
        Task<IResult> HardDelete(int categoryId);

    }
}
