using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static ulong ToUInt64Local(this string @this)
        {
            return ToUInt64(@this, CultureInfo.CurrentCulture);
        }

        public static ulong ToUInt64OrDefaultLocal(this string @this, ulong @default = default)
        {
            return ToUInt64OrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static bool TryConvertToUInt64Local(this string @this, out ulong result)
        {
            return TryConvertToUInt64(@this, CultureInfo.CurrentCulture, out result);
        }

        public static ulong ToULongLocal(this string @this)
        {
            return ToUInt64Local(@this);
        }

        public static ulong ToULongOrDefaultLocal(this string @this, ulong @default = default)
        {
            return ToUInt64OrDefaultLocal(@this, @default);
        }

        public static bool TryConvertToULongLocal(this string @this, out ulong result)
        {
            return TryConvertToUInt64Local(@this, out result);
        }
    }
}
