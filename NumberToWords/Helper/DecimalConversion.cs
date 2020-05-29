using System;

namespace NumberToWords.Helper
{
    public static class DecimalConversion
    {
        public static String ConvertDecimals(String number)
        {
            String cd = "", digit = "", engOne = "";
            for (int i = 0; i < number.Length; i++)
            {
                digit = number[i].ToString();
                if (digit.Equals("0"))
                {
                    engOne = "Zero";
                }
                else
                {
                    engOne = IdentifyOnesPosition.OnesPosition(digit);
                }
                cd += " " + engOne;
            }
            return cd;
        }
    }
}
