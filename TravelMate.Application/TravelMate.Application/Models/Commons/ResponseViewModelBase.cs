using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Domain.Enums.Commons;

namespace TravelMate.Application.Models.Commons
{
    public class ResponseViewModelBase<T>
    {
        public T Data { get; set; }

        public List<string> Errors { get; set; }

        public string Message { get; set; }

        public ResultTypeEnum ResultType { get; set; }

        public static ResponseViewModelBase<T> Success(T Data, ResultTypeEnum resultType)
        {
            return new ResponseViewModelBase<T> { Data = Data, ResultType = resultType };
        }
        public static ResponseViewModelBase<T> Success(ResultTypeEnum resultType)
        {
            return new ResponseViewModelBase<T> { Data = default(T), ResultType = resultType };
        }
        public static ResponseViewModelBase<T> Success(string message, ResultTypeEnum resultType)
        {
            return new ResponseViewModelBase<T> { Data = default(T), Message = message, ResultType = resultType };
        }
        public static ResponseViewModelBase<T> Information(string message, ResultTypeEnum resultType)
        {
            return new ResponseViewModelBase<T> { Data = default(T), Message = message, ResultType = resultType };
        }
        public static ResponseViewModelBase<T> Fail(List<String> errors, ResultTypeEnum resultType)
        {
            return new ResponseViewModelBase<T> { Data = default(T), Errors = errors, ResultType = resultType };
        }

        public static ResponseViewModelBase<T> Fail(string error, ResultTypeEnum resultType)
        {
            return new ResponseViewModelBase<T> { Data = default(T), Errors = new List<string>() { error }, ResultType = resultType };
        }

    }
}
