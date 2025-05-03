using Viceri.SuperHero.Api.Dto;

namespace Viceri.SuperHero.Api.Exception
{
    public class ApiException : System.Exception
    {
        public ResponseDto Response { get; set; }

        public ApiException(ResponseDto response)
        {
            Response = response;
        }

        public ApiException(string message, bool success, object? data, int statusCode)
        {
            Response = new ResponseDto(message, success, data, statusCode);
        }
    }
}
