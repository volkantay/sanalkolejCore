using System;
using SanalKolej.Core.Result.ContextType;

namespace SanalKolej.Core.Base
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
    }
}
