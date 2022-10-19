using AssistantFramework.Models.Models.Response;

namespace AssistantFramework.Models.Interfaces.Response;

public interface IResponse
{
    public ResponseHeaderModel Header { get; }
    public object Body { get; }
}

public interface IResponse<T>
{
    public ResponseHeaderModel Header { get; }
    public T Body { get; }
}