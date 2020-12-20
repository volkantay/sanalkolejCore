using SanalKolej.Core.Abstract;
using SanalKolej.Core.Entities.Abstract;

namespace SanalKolej.Entities.Concrate
{
    public class Comment:EntityBase,IEntity
    {
       // public int CommentID { get; set; }
        public string CommentText { get; set; }


        //Yorum bir makaleye ait olabilir
        public Article Article { get; set; }
        public int  ArticleID { get; set; }

        
    }
}