using System.Net;

namespace TestTask.Application.Common.Exceptions
{
    public class CustomException : Exception
    {
        public HttpStatusCode HttpCode { get; set; }
        public CustomException(string? message, HttpStatusCode httpCode) : base(message)
        {
            HttpCode = httpCode;
        }
    }
}
