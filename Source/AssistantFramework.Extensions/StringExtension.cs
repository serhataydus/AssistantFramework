using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace AssistantFramework.Extensions;

public static class StringExtension
{
    public static bool IsValidJson(this string text)
    {
        text = text.Trim();
        if ((text.StartsWith("{") && text.EndsWith("}")) || //For object
            (text.StartsWith("[") && text.EndsWith("]"))) //For array
        {
            try
            {
                JsonDocument obj = JsonDocument.Parse(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public static (bool IsEncoded, string ParsedText) VerifyBodyContent(this string text)
    {
        try
        {
            if (text.IsValidJson())
            {
                return (false, text);
            }

            string obj = JsonSerializer.Serialize(text);
            return (true, obj.ToString());
        }
        catch (Exception)
        {
            return (false, text);
        }
    }

    public static bool IsHtml(this string text)
    {
        Regex tagRegex = new(@"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>");

        return tagRegex.IsMatch(text);
    }

    public static string ToCamelCase(this string str)
    {
        return !string.IsNullOrEmpty(str) && str.Length.IsGreaterThan(1) ? char.ToLowerInvariant(str[0]) + str[1..] : str;
    }
}