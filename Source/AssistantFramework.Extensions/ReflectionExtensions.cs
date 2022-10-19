using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace AssistantFramework.Extensions;

public static class ReflectionExtensions
{
    public static string GetDescription(Enum value)
    {
        MemberInfo enumMember = value.GetType().GetMember(value.ToString()).FirstOrDefault();
        DescriptionAttribute descriptionAttribute =
            enumMember.IsNullOrEmpty()
                ? default
                : enumMember.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
        return
            descriptionAttribute.IsNullOrEmpty()
                ? value.ToString()
                : descriptionAttribute.Description;
    }
}
