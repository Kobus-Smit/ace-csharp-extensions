namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime ConvertToDateTime(this string? value, IFormatProvider? provider)
    {
        return Convert.ToDateTime(value, provider);
    }

    public static DateTime ConvertToDateTimeOrDefault(this string? value, IFormatProvider provider, DateTime defaultValue = default)
    {
        bool isDateTime = TryConvertToDateTime(value, provider, out var result);

        return isDateTime switch
        {
            true => result,
            false => defaultValue
        };
    }

    public static DateTime SafeConvertToDateTime(this string? value, IFormatProvider provider)
    {
        bool isDateTime = TryConvertToDateTime(value, provider, out var result);

        return isDateTime switch
        {
            true => result,
            false => default
        };
    }

    public static bool TryConvertToDateTime(this string? value, IFormatProvider? provider, out DateTime result)
    {
        try
        {
            result = Convert.ToDateTime(value, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
