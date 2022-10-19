using System;
using System.Collections.Generic;
using System.Linq;

namespace AssistantFramework.Extensions;

public static class CollectionExtensions
{
    public static ICollection<T> RemoveAll<T>(this ICollection<T> source, Func<T, bool> predicate)
    {
        List<T> items = source.Where(predicate).ToList();
        foreach (T item in items)
        {
            _ = source.Remove(item);
        }

        return items;
    }
}