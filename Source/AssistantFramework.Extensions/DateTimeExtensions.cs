namespace AssistantFramework.Extensions;

public static class DateTimeExtensions
{
    public static DateTime GetUtcNow()
    {
        return DateTime.UtcNow;
    }

    public static DateTime GetNow()
    {
        return DateTime.Now;
    }
}