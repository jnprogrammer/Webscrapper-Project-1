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
            
            //string pathToFile = @"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\webScrapper-Selenium\webScrapper-Selenium\test.txt";
            string coinName, coinSymbol, coinPrice, coinMarketCap, coinSupply, coinVolume24hr;
            chromeDriver.Navigate().GoToUrl("https://coinmarketcap.com/all/views/all/");
            
            try
            {
               // "//table[@id='currencies-all']//tr[@id='id-bitcoin']//td[@class='no-wrap currency-name']//a[@class='currency-name-container']"
               
                coinName = chromeDriver.FindElement(By.XPath("//table[@id='currencies-all']//tr/td//a[@class='currency-name-container']")).Text; //$x("//table[@id='currencies-all']//tr[@id='id-bitcoin']")[0]
                                                                                                                                                 /* coinSymbol = chromeDriver.FindElement(By.XPath("")).Text;
                                                                                                                                                  coinPrice = chromeDriver.FindElement(By.XPath("")).Text;
                                                                                                                                                  coinMarketCap = chromeDriver.FindElement(By.XPath("")).Text;
                                                                                                                                                  coinSupply = chromeDriver.FindElement(By.XPath("")).Text;
                                                                                                                                                  coinVolume24hr = chromeDriver.FindElement(By.XPath("")).Text;*/

                //Console.WriteLine("{0} {1} Price:{2} MarketCap:{3} Supply:{4} 24Hr Volume: {5}\n",coinName,coinSymbol,coinPrice,coinMarketCap,coinSupply,coinVolume24hr);  ////table[@id='currencies-all']//tr[@id='id-bitcoin']
                Console.WriteLine(coinName);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error:" + e);
            }
            chromeDriver.Close();
            Console.WriteLine("No errors thrown");
            

        }

        
    }
}
