using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SanalKolej.Core.Result.Abstract;
using SanalKolej.Core.Result.ContextType;
using SanalKolej.Data.Concrate.EntityFramework.Contexts;
using SanalKolej.Entities.Dtos;
using SanalKolej.Services.Abstract;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SanalKolej.WebUI.Areas.Admin.Controllers
{


    [Area("Admin")]
    public class CategoryController : Controller
    {

       /// private readonly SanalKolejContext context;
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {

          //  var ist = await context.Category.ToList();
            IDataResult<CategoryListDto> result = await _categoryService.GetAll();

            if(result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View(result.Data);
        }
    }

}
