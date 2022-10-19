using AssistantFramework.Models.Models.Validation;

namespace AssistantFramework.Models.Interfaces.Response;

public interface IResponseHeader
{
    string? Version { get; set; }

    int? StatusCode { get; set; }

    string Message { get; set; }

    bool? IsError { get; set; }

    object? Exception { get; set; }

    public DateTime ResponseTime { get; }

    public string CorrelationId { get; set; }

    public string? HelpLink { get; set; }

    IEnumerable<ValidationErrorModel>? ValidationErrors { get; set; }
}