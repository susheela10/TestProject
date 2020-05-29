using System;

namespace NumberToWords.Helper
{
    public static class IdentifyOnesPosition
    {
        public static String OnesPosition(String Number)
        {
            int number = Convert.ToInt32(Number);
            String name = "";

            switch (number)
            {
                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }

            return name;
        }
    }
}
