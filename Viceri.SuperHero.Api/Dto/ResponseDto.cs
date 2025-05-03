namespace Viceri.SuperHero.Api.Dto
{
    public class ResponseDto
    {
        public string? Message { get; set; }
        public bool Success { get; set; }
        public object? Data { get; set; }
        public int StatusCode { get; set; }

        public ResponseDto()
        {
                
        }

        public ResponseDto(string message, bool success, object? data, int statusCode)
        {
            Message = message;
            Success = success;
            Data = data;
            StatusCode = statusCode;
        }
    }
}
