using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;

namespace AssistantFramework.Extensions;

public static class ActionFilterExtension
{
    public static T GetActionExecutingContextModel<T>(this ActionExecutingContext context)
    {
        KeyValuePair<string, object?> model = context.ActionArguments
                                                 .Where(w => !w.Value.IsNullOrEmpty() && typeof(T)
                                                                                .IsAssignableFrom(w.Value.GetType()))
                                                 .FirstOrDefault();

        return !model.Value.IsNullOrEmpty() ? (T)model.Value : default;
    }
}