using AssistantFramework.Models.Interfaces.Response;
using AssistantFramework.Models.Models.Validation;

namespace AssistantFramework.Models.Models.Response;

public class ResponseHeaderModel : IResponseHeader
{
    public string? Version { get; set; }

    public int? StatusCode { get; set; } = 200;

    public string Message { get; set; }

    public string ErrorCode { get; set; }
    public string ExceptionType { get; set; }

    public bool? IsError { get; set; }

    public object? Exception { get; set; }

    public DateTime ResponseTime { get; set; }

    public string CorrelationId { get; set; }

    public string? HelpLink { get; set; }

    public IEnumerable<ValidationErrorModel> ValidationErrors { get; set; }


    public ResponseHeaderModel(string correlationId, string errorCode, string message, int? statusCode, string helpLink, string version, string exceptionType)
    {
        CorrelationId = correlationId;
        ErrorCode = errorCode;
        Message = message;
        StatusCode = statusCode;
        HelpLink = helpLink;
        Version = version;
        IsError = true;
        ExceptionType = exceptionType;
    }

    public ResponseHeaderModel(string correlationId, string errorCode, string message, int? statusCode, object exception, string helpLink, string version, string exceptionType)
    {
        CorrelationId = correlationId;
        ErrorCode = errorCode;
        Message = message;
        StatusCode = statusCode;
        Exception = exception;
        HelpLink = helpLink;
        Version = version;
        IsError = true;
        ExceptionType = exceptionType;
    }

    public ResponseHeaderModel(string correlationId, string errorCode, string message, int? statusCode, IEnumerable<ValidationErrorModel> validationError, string helpLink, string version, string exceptionType)
    {
        CorrelationId = correlationId;
        ErrorCode = errorCode;
        Message = message;
        StatusCode = statusCode;
        ValidationErrors = validationError;
        HelpLink = helpLink;
        Version = version;
        IsError = true;
        ExceptionType = exceptionType;
    }

    public ResponseHeaderModel(string correlationId, string version)
    {
        CorrelationId = correlationId;
        Version = version;
    }
}