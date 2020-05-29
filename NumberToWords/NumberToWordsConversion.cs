using NumberToWords.Helper;
using System;

namespace NumberToWords
{
    public class NumberToWordsConversion : IConsole
    {
        static void Main(string[] args)
        {
            try
            {
                InvokeConversion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InvokeConversion()
        {
            NumberToWordsConversion ntw = new NumberToWordsConversion();

            string isNegative = "";
            ntw.WriteLine("Enter a Number to convert to words");
            
            string number = ntw.ReadLine();
            number = Convert.ToDouble(number).ToString();

            if (number.Contains("-"))
            {
                isNegative = "Minus ";
                number = number.Substring(1, number.Length - 1);
            }
            if (number == "0")
            {
                ntw.WriteLine("The number in word is \nZero Only");
            }
            else
            {
                Console.WriteLine("The number in word fomat is \n{0}", isNegative + WordsConversion.ConvertToWords(number));
            }
            ntw.ReadLine();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
