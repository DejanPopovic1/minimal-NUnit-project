using ConsoleApp1;
using NUnit.Framework;


namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            StringPrinter sp = new StringPrinter();
            Assert.AreEqual(sp.PrintString(), "Hello");
        }
    }
}