using Microsoft.Extensions.Configuration;

namespace AssistantFramework.Extensions;

public static class ConfigurationExtension
{
    public static T GetConfigurationObject<T>(this IConfiguration configuration, string parentSectionName)
    {
        return configuration.GetSection(parentSectionName).Get<T>();
    }
}