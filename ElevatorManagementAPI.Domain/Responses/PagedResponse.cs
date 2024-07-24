using System.Text.Json.Serialization;

namespace ElevatorManagementAPI.Domain.Responses
{
  public class PagedResponse<T> : Response<T>
  {
    [JsonConstructor]
    public PagedResponse(
      T? data,
      int totalCount,
      int currentPage = 1,
      int pageSize = 1)
      : base(data)
    {
      Data = data;
      TotalCount = totalCount;
      CurrentPage = currentPage;
      PageSize = pageSize;
    }

    public PagedResponse(
      T? data,
      int code = Configuration.DefaultStatusCode,
      string? message = null)
      : base(data, code, message)

    {

    }
    public int CurrentPage { get; set; }
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    public int TotalCount { get; set; }
  }
}
