using System;
namespace SanalKolej.Core.Result.Abstract
{
    public interface IDataResult<out T>:IResult
    {
        public T Data { get; }

        // Kullanımı sadece bir class dönelecek ise
        // new DataResult<Category>(ResultStatus.Success,category)
        //Liste döndürmek için
        //new DataResult<IList<Category>>(DataResultStatus.Success,categorList);

    }
}
