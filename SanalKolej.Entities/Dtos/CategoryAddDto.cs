using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SanalKolej.Entities.Dtos
{
    public class CategoryAddDto
    {
        public CategoryAddDto()
        {
        }

        [DisplayName("ID")]
        public long ID { get; set; }


        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir!")]
        [MaxLength(50, ErrorMessage = "{0}{1} karakterden büyük olmamalıdır!")]
        [MinLength(3, ErrorMessage = "{0}{1} karakterden az olmamalıdır!")]
        public string Name { get; set; }


        [DisplayName("Kategori Açıklaması")]

        [MaxLength(500, ErrorMessage = "{0}{1} karakterden büyük olmamalıdır!")]
        [MinLength(3, ErrorMessage = "{0}{1} karakterden az olmamalıdır!")]
        public string Description { get; set; }


        [DisplayName("Kategori Not")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        [MaxLength(50, ErrorMessage = "{0}{1} karakterden büyük olmamalıdır!")]
        [MinLength(3, ErrorMessage = "{0}{1} karakterden az olmamalıdır!")]
        public string Note { get; set; }



        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir!")]
        public bool IsActive { get; set; }
    }
}
