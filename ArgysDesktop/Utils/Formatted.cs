using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgysDesktop.Utils
{
    public class Formatted
    {
        public static string FormatDate(string inputDate)
        {
            DateTime data = DateTime.ParseExact(inputDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            string dataFormatada = data.ToString("yyyy-MM-dd") + "T19:28:50.447Z";

            return dataFormatada;
        }

        public static string GetRgNumberAndRemoveDigit(string inputRg)
        {
            if (string.IsNullOrEmpty(inputRg))
            {
                return inputRg;
            }

            string rgNumber = new string(Array.FindAll(inputRg.ToCharArray(), Char.IsDigit));

            if (rgNumber.Length > 0 )
            {
                rgNumber = rgNumber.Substring(0, rgNumber.Length - 1);
            }

            return rgNumber;
        }

        public static string GetRgDigit(string inputRg)
        {
            if (string.IsNullOrEmpty(inputRg))
            {
                return inputRg;
            }

            string rgNumber = new string(Array.FindAll(inputRg.ToCharArray(), Char.IsDigit));

            

            if (rgNumber.Length > 0 )
            {
                string digit = rgNumber[rgNumber.Length - 1].ToString();
                return digit;
            }
;
            return string.Empty;
        }
    }
}
