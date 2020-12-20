using System;
using System.Collections.Generic;
using SanalKolej.Core.Abstract;
using SanalKolej.Core.Entities.Abstract;

namespace SanalKolej.Entities.Concrate
{
    public class Article : EntityBase, IEntity
    {

       
        //public int ArticleID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }

        //makalenin bir kategorisi olabilir
       // public int CategoryID { get; set; }
       // public Category Category { get; set; }

        //makalenin bir yazarı olabilir
        public long UserID { get; set; }
        public User User { get; set; }

        //Bir makalenin birden çok yoruma sahip olabilir
      //  public ICollection<Comment> ArticleComments { get; set; }


    }
}