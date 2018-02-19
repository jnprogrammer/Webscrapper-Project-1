using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace Nunit_Setup
{
    class test
    {
        
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

