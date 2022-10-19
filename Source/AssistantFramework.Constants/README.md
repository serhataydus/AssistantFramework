# AssistantFramework Constants

## Description

This project contains categorized constant values that can be used frequently for your applications.

## Goal

It provides better integrity of the application by reducing errors. The use of constants also improves performance over regular variables. It improves the readability of the code and provides better maintainability because it is easier to update the constant in one place before recompiling the software

## Dependencies

* This project has been developing in NET 6

## Getting Started

This project is divided into the following categories.

* `AppSettingConstants`
* `CacheConstants`
* `ContentTypeConstants`
* `ExceptionConstants`
* `ExtensionConstants`
* `PunctuationCharConstants`
* `PunctuationStringConstants`
* `RegularExpressionConstants`
* `SortingConstants`
* `WebConstants`

How to use:

```csharp
@using AssistantFramework.Constants
```

```csharp
CacheConstants.Key
PunctuationCharConstants.LeftCurlyBracketChar
```

```csharp
class LocalizationManager
{
    public const string Module = "Grid";
    public const string Category = "Button";

    public static Save = $"{Module}{PunctuationStringConstants.DotString}{Category}{PunctuationStringConstants.DotString}{nameof(Save)}";
    public static Edit = $"{Module}{PunctuationStringConstants.DotString}{Category}{PunctuationStringConstants.DotString}{nameof(Edit)}";
    public static Delete = $"{Module}{PunctuationStringConstants.DotString}{Category}{PunctuationStringConstants.DotString}{nameof(Delete)}";
}
```