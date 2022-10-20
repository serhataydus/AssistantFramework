# Assistant Framework Extensions

[![NuGet](https://img.shields.io/nuget/v/AssistantFramework.Extensions)](https://www.nuget.org/packages/AssistantFramework.Extensions/)

## Description

This project includes categorized extension methods to avoid repetitive code that can be used frequently for your applications.

## Goal

The use of extension methods reduces code duplication even though it requires writing a lot of methods. It maintains the code standard. It avoids mistakes. Increases code readability. It reduces maintenance cost. It provides better maintainability and refactoring by creating a centralized structure.

## Dependencies

* This project has been developing in NET 6
* AssistantFramework.Constants <Version="1.0.1">
* AssistantFramework.Models <Version="1.0.0">
* Microsoft.AspNetCore.App <FrameworkReference>
* Microsoft.AspNetCore.Http.Abstractions <Version="2.2.0">
* Microsoft.AspNetCore.Mvc.Abstractions" <Version="2.2.0">
* Microsoft.AspNetCore.Http" <Version="2.2.2">
* Microsoft.Extensions.Configuration.Abstractions" <Version="6.0.0">
* Microsoft.Extensions.DependencyInjection" <Version="6.0.0">

## Getting Started

Added classes for the following extension methods;
> . ActionFilterExtension
>   GetActionExecutingContextModel()
>
> . CollectionExtensions
>   RemoveAll()
>
> . ConfigurationExtension
>   GetConfigurationObject()
>
> . DateTimeExtensions
>   GetUtcNow()
>   GetNow()
>
> . DictionaryExtensions
>   Get()
>
> . EnumExtension
>   GetAttributeOfType()
>
> . FormFileExtensions
>   GetBytes()
>
> . HttpContextExtensions
>   GetCorrelationId()
>   GetApiVersion()
>   GetItem()
>
> . ModelStateExtension
>   GetErrors() 
>
> . ReflectionExtensions
>   GetDescription()
>
> . StopwatchExtensions
>   GetElapsedTime()
>
> . StringExtension
>   IsValidJson()
>   VerifyBodyContent
>   IsHtml()
>   ToCamelCase()
>
> . TypeConverterExtension
>   ToDateTime()
>   ToInt16()
>   ToInt32()
>   ToInt64()
>   ToBoolean()
>   ToFloat()
>   ToDecimal()
>   ToDouble()
>   IsNumber()
>   IsWholeNumber()
>   IsDecimalNumber()
>   IsBoolean()
>
> . TypeIsControlExtension
>   The following methods can be used for object,ICollection<T>,Guid,char,char[],string,string[],DateTime,bool,byte,sbyte,short,ushort,int,uint,long,ulong,float,double,decimal,JsonElement,e.g types
>   IsNullOrEmpty()
>   IsNotNullOrEmpty()
>   IsEqual()
>   IsNotEqual()
>   IsArrayEqual()
>   IsNotArrayEqual()
>   IsLessThan()
>   IsNotLessThan()
>   IsEqualOrLessThan()
>   IsNotEqualOrLessThan()
>   IsGreaterThan()
>   IsNotGreaterThan()
>   IsEqualOrGreaterThan()
>   IsNotEqualOrGreaterThan()
>   IsCorrectFormat()
>   IsNotCorrectFormat()