namespace Ddp.Domain.Wrappers;

public class ApiResponse<T>
{
    public ApiResponse()
    {
    }
    public ApiResponse(T data, string message = null)
    {
        Succeeded = true;
        Message = message;
        Data = data;
    }
    public ApiResponse(string message)
    {
        Succeeded = false;
        Message = message;
    }
    public bool Succeeded { get; set; }
    public string Message { get; set; }
    public List<string> Errors { get; set; }
    public T Data { get; set; }
}