using AssistantFramework.Models.Interfaces.Response;

namespace AssistantFramework.Models.Models.Response;

public class ResponseModel : IResponseModel
{
    public ResponseHeaderModel Header { get; set; }

    public object Body { get; set; }

    public ResponseModel(ResponseHeaderModel header, object body)
    {
        Header = header;
        Body = body;
    }
}

public class ResponseModel<T> : IResponseModel<T>
{
    public ResponseHeaderModel Header { get; set; }
    public T Body { get; set; }

    public ResponseModel(ResponseHeaderModel header, T body)
    {
        Header = header;
        Body = body;
    }
}