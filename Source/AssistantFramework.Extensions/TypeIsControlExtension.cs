using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace AssistantFramework.Extensions;

public static class TypeIsControlExtension
{
    private const byte _defaultEmptyNumber = 0;
    private const string _valueKindArgumentException = "Unrecognized value kind";

    #region IsNullOrEmpty

    public static bool IsNullOrEmpty(this object value)
    {
        return value == null;
    }

    public static bool IsNullOrEmpty<T>(this ICollection<T> value)
    {
        return value == null || value.Count == _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this Guid? value)
    {
        return !value.HasValue || value == Guid.Empty;
    }

    public static bool IsNullOrEmpty(this char? value)
    {
        return !value.HasValue || char.IsWhiteSpace(value.Value);
    }
    public static bool IsNullOrEmpty(this char[] value)
    {
        return value == null || value.Length == _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this string value)
    {
        return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
    }

    public static bool IsNullOrEmpty(this string[] value)
    {
        return value == null || value.Length == _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this DateTime? value)
    {
        return !value.HasValue || value == DateTime.MinValue;
    }

    public static bool IsNullOrEmpty(this bool? value)
    {
        return !value.HasValue;
    }

    public static bool IsNullOrEmpty(this byte? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this sbyte? value)
    {
        return value is null or (sbyte)_defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this short? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this ushort? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this int? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this uint? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this long? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this ulong? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this float? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this double? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this decimal? value)
    {
        return value is null or _defaultEmptyNumber;
    }

    public static bool IsNullOrEmpty(this JsonElement value)
    {
        return value.ValueKind switch
        {
            JsonValueKind.Object => value.GetByte().IsLessThan(1),
            JsonValueKind.True or JsonValueKind.False => !value.GetBoolean(),
            JsonValueKind.Array => value.GetArrayLength().IsLessThan(1),
            JsonValueKind.String => value.GetString() == string.Empty,
            JsonValueKind.Number => value.GetDecimal().IsLessThan(1),
            JsonValueKind.Undefined or JsonValueKind.Null => true,
            _ => throw new ArgumentException($"{_valueKindArgumentException} {value.ValueKind}")
        };
    }

    #endregion

    #region IsNotNullOrEmpty

    public static bool IsNotNullOrEmpty(this object value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty<T>(this ICollection<T> value)
    {
        return !IsNullOrEmpty(value);
    }

    public static bool IsNotNullOrEmpty(this Guid? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this char? value)
    {
        return !value.IsNullOrEmpty();
    }
    public static bool IsNotNullOrEmpty(this char[] value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this string value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this string[] value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this DateTime? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this bool? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this byte? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this sbyte? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this short? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this ushort? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this int? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this uint? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this long? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this ulong? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this float? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this double? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this decimal? value)
    {
        return !value.IsNullOrEmpty();
    }

    public static bool IsNotNullOrEmpty(this JsonElement value)
    {
        return !value.IsNullOrEmpty();
    }

    #endregion

    #region IsEqual

    public static bool IsEqual(this object value, object valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this Guid value, Guid valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this char value, char valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this string value, string valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this DateTime value, DateTime valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this bool value, bool valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this byte value, byte valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this sbyte value, sbyte valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this short value, short valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this ushort value, ushort valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this int value, int valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this uint value, uint valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this long value, long valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this ulong value, ulong valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this float value, float valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this double value, double valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this decimal value, decimal valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    public static bool IsEqual(this JsonElement value, JsonElement valueToCompare)
    {
        return value.Equals(valueToCompare);
    }

    #endregion

    #region IsNotEqual

    public static bool IsNotEqual(this object value, object valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this Guid value, Guid valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this char value, char valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this string value, string valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this DateTime value, DateTime valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this bool value, bool valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this byte value, byte valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this sbyte value, sbyte valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this short value, short valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this ushort value, ushort valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this int value, int valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this uint value, uint valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this long value, long valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this ulong value, ulong valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this float value, float valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this double value, double valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this decimal value, decimal valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    public static bool IsNotEqual(this JsonElement value, JsonElement valueToCompare)
    {
        return !value.IsEqual(valueToCompare);
    }

    #endregion

    #region IsArrayEqual

    public static bool IsArrayEqual<T>(this T[] value, T[] valueToCompare, bool sorted)
    {
        return sorted ? value.OrderBy(a => a).SequenceEqual(valueToCompare.OrderBy(a => a)) : value.SequenceEqual(valueToCompare);
    }

    public static bool IsEqual(this object[] value, object[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this Guid[] value, Guid[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this char[] value, char[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this string[] value, string[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this DateTime[] value, DateTime[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this bool[] value, bool[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this byte[] value, byte[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this sbyte[] value, sbyte[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this short[] value, short[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this ushort[] value, ushort[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this int[] value, int[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this uint[] value, uint[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this long[] value, long[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this ulong[] value, ulong[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this float[] value, float[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this double[] value, double[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsEqual(this decimal[] value, decimal[] valueToCompare, bool sorted)
    {
        return value.IsArrayEqual(valueToCompare, sorted);
    }

    #endregion

    #region IsNotArrayEqual

    public static bool IsNotArrayEqual<T>(this T[] value, T[] valueToCompare, bool sorted)
    {
        return !value.IsArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this object[] value, object[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this Guid[] value, Guid[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this char[] value, char[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this string[] value, string[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this DateTime[] value, DateTime[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this bool[] value, bool[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this byte[] value, byte[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this sbyte[] value, sbyte[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this short[] value, short[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this ushort[] value, ushort[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this int[] value, int[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this uint[] value, uint[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this long[] value, long[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this ulong[] value, ulong[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this float[] value, float[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this double[] value, double[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    public static bool IsNotEqual(this decimal[] value, decimal[] valueToCompare, bool sorted)
    {
        return value.IsNotArrayEqual(valueToCompare, sorted);
    }

    #endregion

    #region IsLessThan

    public static bool IsLessThan(this byte value, byte length)
    {
        return value < length;
    }

    public static bool IsLessThan(this sbyte value, sbyte length)
    {
        return value < length;
    }

    public static bool IsLessThan(this short value, short length)
    {
        return value < length;
    }

    public static bool IsLessThan(this ushort value, ushort length)
    {
        return value < length;
    }

    public static bool IsLessThan(this int value, int length)
    {
        return value < length;
    }

    public static bool IsLessThan(this uint value, uint length)
    {
        return value < length;
    }

    public static bool IsLessThan(this long value, long length)
    {
        return value < length;
    }

    public static bool IsLessThan(this ulong value, ulong length)
    {
        return value < length;
    }

    public static bool IsLessThan(this float value, float length)
    {
        return value < length;
    }

    public static bool IsLessThan(this double value, double length)
    {
        return value < length;
    }

    public static bool IsLessThan(this decimal value, decimal length)
    {
        return value < length;
    }

    #endregion

    #region IsNotLessThan

    public static bool IsNotLessThan(this byte value, byte length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this sbyte value, sbyte length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this short value, short length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this ushort value, ushort length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this int value, int length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this uint value, uint length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this long value, long length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this ulong value, ulong length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this float value, float length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this double value, double length)
    {
        return !value.IsLessThan(length);
    }

    public static bool IsNotLessThan(this decimal value, decimal length)
    {
        return !value.IsLessThan(length);
    }

    #endregion

    #region IsEqualOrLessThan

    public static bool IsEqualOrLessThan(this byte value, byte length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this sbyte value, sbyte length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this short value, short length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this ushort value, ushort length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this int value, int length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this uint value, uint length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this long value, long length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this ulong value, ulong length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this float value, float length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this double value, double length)
    {
        return value <= length;
    }

    public static bool IsEqualOrLessThan(this decimal value, decimal length)
    {
        return value <= length;
    }

    #endregion

    #region IsNotEqualOrLessThan

    public static bool IsNotEqualOrLessThan(this byte value, byte length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this sbyte value, sbyte length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this short value, short length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this ushort value, ushort length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this int value, int length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this uint value, uint length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this long value, long length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this ulong value, ulong length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this float value, float length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this double value, double length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    public static bool IsNotEqualOrLessThan(this decimal value, decimal length)
    {
        return !value.IsEqualOrLessThan(length);
    }

    #endregion

    #region IsGreaterThan

    public static bool IsGreaterThan(this byte value, byte length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this sbyte value, sbyte length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this short value, short length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this ushort value, ushort length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this int value, int length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this uint value, uint length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this long value, long length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this ulong value, ulong length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this float value, float length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this double value, double length)
    {
        return value > length;
    }

    public static bool IsGreaterThan(this decimal value, decimal length)
    {
        return value > length;
    }

    #endregion

    #region IsNotGreaterThan

    public static bool IsNotGreaterThan(this byte value, byte length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this sbyte value, sbyte length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this short value, short length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this ushort value, ushort length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this int value, int length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this uint value, uint length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this long value, long length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this ulong value, ulong length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this float value, float length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this double value, double length)
    {
        return !value.IsGreaterThan(length);
    }

    public static bool IsNotGreaterThan(this decimal value, decimal length)
    {
        return !value.IsGreaterThan(length);
    }

    #endregion

    #region IsEqualOrGreaterThan

    public static bool IsEqualOrGreaterThan(this byte value, byte length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this sbyte value, sbyte length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this short value, short length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this ushort value, ushort length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this int value, int length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this uint value, uint length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this long value, long length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this ulong value, ulong length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this float value, float length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this double value, double length)
    {
        return value >= length;
    }

    public static bool IsEqualOrGreaterThan(this decimal value, decimal length)
    {
        return value >= length;
    }

    #endregion

    #region IsNotEqualOrGreaterThan

    public static bool IsNotEqualOrGreaterThan(this byte value, byte length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this sbyte value, sbyte length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this short value, short length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this ushort value, ushort length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this int value, int length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this uint value, uint length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this long value, long length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this ulong value, ulong length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this float value, float length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this double value, double length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    public static bool IsNotEqualOrGreaterThan(this decimal value, decimal length)
    {
        return !value.IsEqualOrGreaterThan(length);
    }

    #endregion

    #region IsCorrectFormat

    public static bool IsCorrectFormat(this string value, string regularExpression)
    {
        Regex regex = new(regularExpression, RegexOptions.Compiled);

        return regex.IsMatch(value);
    }

    #endregion

    #region IsNotCorrectFormat

    public static bool IsNotCorrectFormat(this string value, string regularExpression)
    {
        return !value.IsCorrectFormat(regularExpression);
    }

    #endregion
}