using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SanalKolej.Core.Base;
using SanalKolej.Entities.Concrate;

namespace SanalKolej.Entities.Dtos
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
}
