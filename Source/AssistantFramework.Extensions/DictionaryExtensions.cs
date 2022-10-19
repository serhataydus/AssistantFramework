using System.Collections.Generic;

namespace AssistantFramework.Extensions;

internal static class DictionaryExtensions
{
    public static TValue Get<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key)
    {
        return TypeIsControlExtension.IsNullOrEmpty(source) || key.IsNullOrEmpty() ? default : source.TryGetValue(key, out TValue value) ? value : default;
    }
}