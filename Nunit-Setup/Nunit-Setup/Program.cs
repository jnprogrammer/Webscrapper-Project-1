using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Nunit_Setup
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's get that Data!");
            
            IWebDriver chromeDriver = new ChromeDriver(@"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\Nunit-Setup\Nunit-Setup");
            chromeDriver.Navigate().GoToUrl("https://coinmarketcap.com/all/views/all/");

            var body = chromeDriver.FindElement(By.TagName("body")).Text;

            Console.WriteLine("Got that Data!");


        }
    }
}



/*
 *
 *IWebDriver foxDriver = new FirefoxDriver(@"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\Nunit-Setup\Nunit-Setup");
            //foxDriver.Url = "https://coinmarketcap.com/all/views/all/";

            foxDriver.Navigate().GoToUrl("https://coinmarketcap.com/all/views/all/");
            foxDriver.Navigate().Refresh();
            var textID = foxDriver.FindElement(By.Id("id-bitcoin"));
            Console.WriteLine(textID);
 * 
 */
