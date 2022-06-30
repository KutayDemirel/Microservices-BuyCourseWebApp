using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BuyCourse.Shared.Dtos
{
    public class ResponseDto<T>
    {
        public T Data { get; private set; }

        [JsonIgnore] // Response'un içersinde zaten StatusCode var ama kod içersnde kullanmak için jsonignore
        public int StatusCode { get; private set; }
        [JsonIgnore]
        public bool IsSuccessful { get; private set; }
        public List<string> Errors { get; set; }

        //Static Factory Method(Constructor'da geriye nesne dönüyorsak)
        public static ResponseDto<T> Success(T Data, int StatusCode)
        {
            return new ResponseDto<T> { Data = Data, StatusCode = StatusCode, IsSuccessful = true };
        }
        public static ResponseDto<T> Success(int StatusCode)
        {
            return new ResponseDto<T> { Data = default(T), StatusCode = StatusCode, IsSuccessful = true };
        }
        public static ResponseDto<T> Fail(List<string> errors, int StatusCode)
        {
            return new ResponseDto<T>
            {
                Errors = errors,
                StatusCode = StatusCode,
                IsSuccessful = false
            };
        }
        public static ResponseDto<T> Fail(string error, int StatusCode)
        {
            return new ResponseDto<T>
            {
                Errors = new List<string> { error },
                StatusCode = StatusCode,
                IsSuccessful = false
            };
        }

    }
}
