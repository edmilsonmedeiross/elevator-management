using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Responses
{
  public class Response<TData>
  {
    private readonly int _code;

    [JsonConstructor]
    public Response()
    {
      _code = Configuration.DefaultStatusCode;
    }

    public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null)
    {
      Data = data;
      Message = message ?? string.Empty;
      _code = code;
    }

    public TData? Data { get; set; }
    public string Message { get; set; } = string.Empty;
    [JsonIgnore]
    public bool IsSuccess => _code >= 200 && _code < 300;
  }
}
