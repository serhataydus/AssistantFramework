using AssistantFramework.Models.Models.Validation;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace AssistantFramework.Extensions;

public static class ModelStateExtension
{
    public static IEnumerable<ValidationErrorModel> AllErrors(this ModelStateDictionary modelState)
    {
        return modelState.Keys.SelectMany(key => modelState[key].Errors.Select(x => new ValidationErrorModel(key, x.ErrorMessage))).ToList();
    }
}