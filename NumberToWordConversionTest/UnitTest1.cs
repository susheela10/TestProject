using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords;

namespace NumberToWordConversionTest
{
    [TestClass]
    public class UnitTest1 : IConsole
    {
        string number = "";
        [TestMethod]
        public void ConvertNumber()
        {
            number = "12345";

            try
            {
                NumberToWords.NumberToWordsConversion.InvokeConversion();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            } 
        }

        public void WriteLine(string message)
        {
            throw new NotImplementedException();
        }

        public string ReadLine()
        {
            return number;
        }
    }
}
