using AssistantFramework.Models.Models.Validation;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AssistantFramework.Extensions;

public static class ModelStateExtension
{
    public static IEnumerable<ValidationErrorModel> GetErrors(this ModelStateDictionary modelState)
    {
        return modelState.Keys.SelectMany(key => modelState[key].Errors.Select(x => new ValidationErrorModel(key, x.ErrorMessage))).ToList();
    }
}