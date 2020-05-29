using System;

namespace NumberToWords.Helper
{
    public static class WordsConversion
    {
        public static String ConvertToWords(String numb)
        {
            String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";
            String endStr = "Only";

            try
            {
                int decimalPlace = numb.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNo = numb.Substring(0, decimalPlace);
                    points = numb.Substring(decimalPlace + 1);
                    if (Convert.ToInt32(points) > 0)
                    {
                        andStr = "and";  
                        endStr = "Paisa " + endStr;    
                        pointStr = DecimalConversion.ConvertDecimals(points);
                    }
                }
                val = String.Format("{0} {1}{2} {3}", WholeNumberConversion.ConvertWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return val;
        }
    }
}
