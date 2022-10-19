namespace AssistantFramework.Models.Models.Paging.Response;

public class PagingResponseModel
{
    public ushort? Start { get; set; }
    public ushort? Length { get; set; }
    public int Total { get; set; }
    public string? Sort { get; set; }
}

public class PagingResponseModel<T> : PagingResponseModel
{
    public List<T> Data { get; set; }
}