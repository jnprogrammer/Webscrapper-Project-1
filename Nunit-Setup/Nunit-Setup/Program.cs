using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
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

            var table = chromeDriver.FindElement(By.Id("currencies-all"));
            var pauseTime = chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
            var htmlBody = table.Text;
            string pathToFile = @"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\Nunit-Setup\Nunit-Setup\table.txt";

            foreach (var row in table.FindElements(By.TagName("thead")))
            {

                //use Redgex to filter data before writing it
                //myRegex.Match(htmlBody);

                try
                {
                    File.WriteAllText(pathToFile, htmlBody);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Err:" + e);
                }
            }
            Console.WriteLine("Data saved to Text file");


        }


      /*  void displayDataConsole(ChromeDriver chromdriver)
        {
            var table = chromeDriver.FindElement(By.Id("currencies-all"));


            foreach (var row in table.FindElements(By.TagName("tr")))
            {
                Console.WriteLine(value: row);
            }
        }*/
        //
        void saveDataToFile(ChromeDriver chromeDriver)
        {
            var htmlBody = chromeDriver.PageSource;
            string pathToFile = @"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\Nunit-Setup\Nunit-Setup\htmlToScrape.html";
            //StringBuilder htmlfile = new StringBuilder(htmlBody);

            try
            {
                File.WriteAllText(pathToFile, htmlBody);
            }
            catch (Exception e)
            {
                Console.WriteLine("Err:" + e);
            }

            Console.WriteLine("Got that Data saved to a file! \n");
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
