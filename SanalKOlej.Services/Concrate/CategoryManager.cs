using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SanalKolej.Core.Result.Abstract;
using SanalKolej.Core.Result.Concrate;
using SanalKolej.Core.Result.ContextType;
using SanalKolej.Data.Concrate.EntityFramework.Contexts;
using SanalKolej.DataAccess.Abstract;
using SanalKolej.Entities.Concrate;
using SanalKolej.Entities.Dtos;
using SanalKolej.Services.Abstract;

namespace SanalKolej.Services.Concrate
{
    public class CategoryManager:ICategoryService

    {

        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;
      



        public CategoryManager(IUnitOfWork unitOfwork, IMapper mapper)
        {
            _unitOfwork = unitOfwork;
            _mapper = mapper;

        }

        public async Task<IDataResult<CategoryDto>> Get(int categoryId)
        {
            var category = await _unitOfwork.Categories.GetAsync(c => c.ID == categoryId);
            if (category != null)
            {
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto
                {
                    Category = category,
                    ResultStatus = ResultStatus.Success
                });
            }

            

            return new DataResult<CategoryDto>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAll()
        {

         
           
            var categories = await _unitOfwork.Categories.GetAllAsync(null);

            if (categories.Count > 0)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success,
                    new CategoryListDto{

                    Categories =categories,
                    ResultStatus=ResultStatus.Success

                    });

            }

            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllNonDeleted()
        {
            var categories = await _unitOfwork.Categories.GetAllAsync(c=>!c.IsDeleted);

            if (categories.Count > 0)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success,
                    new CategoryListDto
                    {

                        Categories = categories,
                        ResultStatus = ResultStatus.Success

                    });

            }

            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı.", null);
        }

        public async Task<IResult> Add(CategoryAddDto categoryDto, string creatingByName)
        {
            //Auto Mapper kullanmadan

            await _unitOfwork.Categories.AddAsync(new Category
            {
                CategoryName = categoryDto.Name,
                CreatedByName = creatingByName,
                CreatedDate = DateTime.Now,
                Description =categoryDto.Description,
                  

            }).ContinueWith(t => _unitOfwork.SaveAsync());
            //await _unitOfWork.SaveAsync() bize ikinci bir task açarken ilk yapı aynı task üzernden işlemleri yapmamaıza olanak sağlar




           // Auto mapper kullanarak yapılması
           // Category cat = _mapper.Map<Category>(categoryDto);
           // cat.CreatedByName = creatingByName;
          //  await _unitOfwork.Categories.AddAsync(cat).ContinueWith(t => _unitOfwork.SaveAsync());

            return new Result(ResultStatus.Success, "Başarılı bir şekilde eklendi!");

        }

        public async Task<IResult> Delete(int categoryId, string modifiedByName)
        {

            var varmi = await _unitOfwork.Categories.AnyAsync(c => c.ID == categoryId);

            if (varmi)
            {
                var cat = await _unitOfwork.Categories.GetAsync(c => c.ID == categoryId);
                if (cat != null)
                {

                    cat.IsDeleted = true;
                    cat.ModifiedByName = modifiedByName;
                    cat.ModifiedDate = DateTime.Now;

                    await _unitOfwork.Categories.UpdateAsync(cat).ContinueWith(s => _unitOfwork.SaveAsync());
                    return new Result(ResultStatus.Success, $"{cat.CategoryName} adlı kategori başarıyla silinmiştir.");
                }
            }
            

            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı");

        }

        public async Task<IResult> HardDelete(int categoryId)
        {
            var cat = await _unitOfwork.Categories.GetAsync(c => c.ID == categoryId);
            if (cat != null)
            {


                await _unitOfwork.Categories.DeleteAsync(cat).ContinueWith(s => _unitOfwork.SaveAsync());
                return new Result(ResultStatus.Success, $"{cat.CategoryName} adlı kategori başarıyla veritabanından silinmiştir.");
            }

            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı");
        }

        public async Task<IResult> Update(CategoryAddDto categoryDto, string modifiedByName)
        {
            var cat = await _unitOfwork.Categories.GetAsync(x => x.ID == categoryDto.ID);
            if (cat != null)
            {
                cat.CategoryName = categoryDto.Name;
                cat.Description = categoryDto.Description;
                cat.ModifiedByName = modifiedByName;
                cat.ModifiedDate = DateTime.Now;
                await _unitOfwork.Categories.UpdateAsync(cat).ContinueWith(t => _unitOfwork.SaveAsync());
                return new Result(ResultStatus.Success, "Başarılı bir şekilde eklendi!");

            }
            return new Result(ResultStatus.Error, "Kayıt bulunamadı!");



        }

        public async Task<IResult> Delete(int categoryId)
        {
            var cat = await _unitOfwork.Categories.GetAsync(c => c.ID == categoryId);
            if (cat != null)
            {

                cat.IsDeleted = true;
                //cat.ModifiedByName = modifiedByName;
                cat.ModifiedDate = DateTime.Now;

                await _unitOfwork.Categories.UpdateAsync(cat).ContinueWith(s => _unitOfwork.SaveAsync());
                return new Result(ResultStatus.Success, $"{cat.CategoryName} adlı kategori başarıyla silinmiştir.");
            }

            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı");
        }
    }
}
