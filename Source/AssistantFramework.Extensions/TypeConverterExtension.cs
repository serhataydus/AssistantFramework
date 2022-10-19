using System;
using System.Text.RegularExpressions;

namespace AssistantFramework.Extensions;

public static class TypeConverterExtension
{
    public static DateTime ToDateTime(this string value)
    {
        return DateTime.TryParse(value, out DateTime result) ? result : default;
    }

    public static short ToInt16(this string value)
    {
        return short.TryParse(value, out short result) ? result : default;
    }

    public static int ToInt32(this string value)
    {
        return int.TryParse(value, out int result) ? result : default;
    }

    public static long ToInt64(this string value)
    {
        return long.TryParse(value, out long result) ? result : default;
    }

    public static bool ToBoolean(this string value)
    {
        return bool.TryParse(value, out bool result) && result;
    }

    public static float ToFloat(this string value)
    {
        return float.TryParse(value, out float result) ? result : default;
    }

    public static decimal ToDecimal(this string value)
    {
        return decimal.TryParse(value, out decimal result) ? result : default;
    }

    public static double ToDouble(this string value)
    {
        return double.TryParse(value, out double result) ? result : default;
    }

    public static bool IsNumber(this string value)
    {
        return Regex.IsMatch(value, @"^\d+$");
    }

    public static bool IsWholeNumber(this string value)
    {
        return long.TryParse(value, out _);
    }

    public static bool IsDecimalNumber(this string value)
    {
        return decimal.TryParse(value, out _);
    }

    public static bool IsBoolean(this string value)
    {
        return bool.TryParse(value, out bool _);
    }
}