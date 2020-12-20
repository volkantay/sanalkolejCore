using System;
using SanalKolej.Core.Result.ContextType;

namespace SanalKolej.Core.Result.Abstract
{
    public interface IResult
    {
       

        public ResultStatus ResultStatus { get;}
        public string Message { get;  }
        public Exception Exception { get;  }


    }
}
