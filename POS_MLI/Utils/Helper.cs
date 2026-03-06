using System.Globalization;

namespace POS_MLI.Utils
{
    class Helper
    {
        public static string FormatMoney(decimal amount)
        {
            return string.Format(
                CultureInfo.GetCultureInfo("lo-LA"),
                "{0:N0}",
                amount
             );
        }
    }
}
