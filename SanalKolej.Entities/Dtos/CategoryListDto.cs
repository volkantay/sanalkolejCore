using System;
using System.Collections.Generic;
using SanalKolej.Core.Base;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.Entities.Dtos
{
    public class CategoryListDto : DtoGetBase
    {
        public IList<Category> Categories { get; set; }
    }
}
