﻿using System;
using SanalKolej.Core.Result.Abstract;
using SanalKolej.Core.Result.ContextType;

namespace SanalKolej.Core.Result.Concrate
{
    public class Result:IResult
    {

        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }

        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }

        public Result(ResultStatus resultStatus, string message)
        {
            ResultStatus = resultStatus;
            Message = message;

        }

        public Result(ResultStatus resultStatus,string message, Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
        }

        // Kullanımı
        // new Rusult(ResultStatus.Error,"Message",exceprtion);


    }
}
