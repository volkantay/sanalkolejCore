using System;
using SanalKolej.Core.Abstract;
using SanalKolej.Core.Entities.Abstract;

namespace SanalKolej.Entities.Concrate
{
    public class Product: EntityBase,IEntity
    {
        public Product()
        {
        }


       // public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}
