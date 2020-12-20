using System.Collections.Generic;
using SanalKolej.Core.Abstract;
using SanalKolej.Core.Entities.Abstract;

namespace SanalKolej.Entities.Concrate
{
    public class Category:EntityBase,IEntity
    {

        //public int CategoryID { get; set; }
        public string  CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Product> ProductList { get; set; }
    }
}