using AssistantFramework.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace AssistantFramework.Extensions;

public static class HttpContextExtensions
{
    public static string GetCorrelationId(this HttpRequest httpRequest)
    {
        string correlationId = string.Empty;
        if (httpRequest.Headers.TryGetValue(WebConstants.CorrelationKey, out StringValues correlationIds))
        {
            correlationId = correlationIds.FirstOrDefault();
        }

        return correlationId;
    }

    public static string GetCorrelationId(this HttpRequestMessage httpRequestMessage)
    {
        string correlationId = string.Empty;
        if (httpRequestMessage.Headers.TryGetValues(WebConstants.CorrelationKey, out IEnumerable<string> correlationIds))
        {
            correlationId = correlationIds.FirstOrDefault();
        }

        return correlationId;
    }

    public static string GetApiVersion(this HttpRequest httpRequest)
    {
        string apiVersion = string.Empty;
        if (httpRequest.Headers.TryGetValue(WebConstants.ApiVersion, out StringValues apiVersions))
        {
            apiVersion = apiVersions.FirstOrDefault();
        }

        return apiVersion;
    }

    public static string GetApiVersion(this HttpRequestMessage httpRequestMessage)
    {
        string apiVersion = string.Empty;
        if (httpRequestMessage.Headers.TryGetValues(WebConstants.ApiVersion, out IEnumerable<string> apiVersions))
        {
            apiVersion = apiVersions.FirstOrDefault();
        }

        return apiVersion;
    }

    public static TValue GetItem<TValue>(this HttpContext httpContext, string key)
    {
        return httpContext.Items.TryGetValue(key, out object o) && o is TValue value ? value : default;
    }
}