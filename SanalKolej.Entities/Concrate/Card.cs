using System;
using SanalKolej.Core.Abstract;
using SanalKolej.Core.Entities.Abstract;

namespace SanalKolej.Entities.Concrate
{
    public class Card:EntityBase,IEntity
    {
        public Card()
        {
        }


       // public int CardID { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

    }
}
