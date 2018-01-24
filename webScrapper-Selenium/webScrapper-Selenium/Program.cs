using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace webScrapper_Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver chromeDriver = new ChromeDriver();
            string pathToFile = @"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\webScrapper-Selenium\webScrapper-Selenium\test.text";
            string information;
            chromeDriver.Navigate().GoToUrl("https://coinmarketcap.com/all/views/all/");

            try
            {
              information = chromeDriver.FindElement(By.XPath("//table[@id='currencies-all']//tr[@id='id-bitcoin']")).Text;
              File.WriteAllText(pathToFile, information);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error:" + e);
            }

            Console.WriteLine("No errors thrown");
            

        }

        
    }
}
