namespace AssistantFramework.Models.Models.Paging.Request;

public class PagingRequestModel
{
    public ushort? Start { get; set; }
    public ushort? Length { get; set; }
    public string? Sort { get; set; }
}