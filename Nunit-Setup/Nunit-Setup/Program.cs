//using System;
//using NUnit.Framework;
//using OpenQA.Selenium.Firefox;

//namespace Nunit_Setup
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Let's get that Data!");
//            var foxDriver = new FirefoxDriver(@"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\Nunit-Setup\Nunit-Setup");
//            foxDriver.Url = "https://coinmarketcap.com/all/views/all/";
//        }
//    }
//}

using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace Nunit_Setup
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        FirefoxDriver foxDriver = new FirefoxDriver(@"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\Nunit-Setup\Nunit-Setup");
        [SetUp]
        public void Initialize()
        {

            var foxDriver = new FirefoxDriver(@"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\Nunit-Setup\Nunit-Setup");
        }

        [Test]
        public void OpenAppTest()
        {
            foxDriver.Url = "https://coinmarketcap.com/all/views/all/";
        }

        [TearDown]
        public void EndTest()
        {
            foxDriver.Close();
        }


    }
}

