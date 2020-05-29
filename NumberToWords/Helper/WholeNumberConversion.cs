using System;

namespace NumberToWords.Helper
{
    public static class WholeNumberConversion
    {
        public static String ConvertWholeNumber(String Number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;
                bool isDone = false;
                double amount = (Convert.ToDouble(Number));

                if (amount > 0)
                {
                    //test for zero or digit zero in a nuemric    
                    beginsZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int pos = 0;
                    String place = "";

                    switch (numDigits)
                    {
                        case 1://ones' range
                            word = IdentifyOnesPosition.OnesPosition(Number);
                            isDone = true;
                            break;
                        case 2://tens' range    
                            word = IdentifyTensPosition.TensPosition(Number);
                            isDone = true;
                            break;
                        case 3://hundreds' range    
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4://thousands' range    
                        case 5:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 6://lakh's range    
                        case 7:
                            pos = (numDigits % 6) + 1;
                            place = " Lakh ";
                            break;
                        case 8://crore's range    
                        case 9:
                        case 10:
                            pos = (numDigits % 8) + 1;
                            place = " Crore ";
                            break;    
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {  
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));
                        }  
                    }
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return word.Trim();
        }
    }
}
