using System;
using SanalKolej.Core.Result.Abstract;
using SanalKolej.Core.Result.ContextType;

namespace SanalKolej.Core.Result.Concrate
{
    public class DataResult<T>:IDataResult<T>
    {
        private ResultStatus error;

        public DataResult(ResultStatus error)
        {
            this.error = error;
        }

        public DataResult(ResultStatus resultStatus,T data)
        {
            ResultStatus = resultStatus;
            Data = data;

        }

        public DataResult(ResultStatus resultStatus, string message, T data)
        {
            ResultStatus = resultStatus;
            Data = data;
            Message = message;

        }

        public DataResult(ResultStatus resultStatus, string message, T data, Exception exception)
        {
            ResultStatus = resultStatus;
            Data = data;
            Message = message;
            Exception = exception;

        }



        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }
    }
}
