using System;
using System.Diagnostics;

namespace AssistantFramework.Extensions;

public static class StopwatchExtensions
{
    public static string GetElapsedTime(this Stopwatch stopwatch)
    {
        TimeSpan elapsedTime = stopwatch.Elapsed;

        return string.Format("{0:00}:{1:00}:{2:00}.{3:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds / 10);
    }
}