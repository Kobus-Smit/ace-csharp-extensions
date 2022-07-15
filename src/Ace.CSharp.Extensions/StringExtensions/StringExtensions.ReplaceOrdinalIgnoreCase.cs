namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static string ReplaceOrdinalIgnoreCase(this string value, string oldValue, string? newValue)
    {
        return value.Replace(oldValue, newValue, StringComparison.OrdinalIgnoreCase);
    }
}
