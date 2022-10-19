using AssistantFramework.Models.Enums;

namespace AssistantFramework.Models.Models.Validation;

public class ValidationErrorModel
{
    public ValidationErrorModel(string propertyName, string message)
    {
        PropertyName = propertyName;
        Message = message;
    }

    public ValidationErrorModel(string modulName, string propertyName, string message)
    {
        ModulName = modulName;
        PropertyName = propertyName;
        Message = message;
    }

    public string? ModulName { get; set; }
    public string? PropertyName { get; set; }
    public string? ErrorCode { get; set; }
    public ErrorTypeEnum? ErrorType { get; set; }
    public LogPriorityEnum? LogPriority { get; set; }
    public int? Status { get; set; }
    public string? Url { get; set; }
    public bool? IsDiarize { get; set; }
    public object? AttemptedValue { get; set; }
    public string? Message { get; set; }
    public object? State { get; set; }
}