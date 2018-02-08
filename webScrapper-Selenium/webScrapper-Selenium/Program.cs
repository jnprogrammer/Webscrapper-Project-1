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
        public class CryptoTable
        {
            public int Id { get; set; }
            
            public string CoinName { get; set; }
                        
            public string CoinSymbol { get; set; }

            public long MarketCap { get; set; }

            public int Price { get; set; }

            //[Column("Circulating Supply ")]
            public long Circulating_Supply_ { get; set; }

            public long Volume24hr { get; set; }
        }

        static void Main(string[] args)
        {
            IWebDriver chromeDriver = new ChromeDriver();
            
            //string pathToFile = @"C:\Users\jnprogrammer9\Documents\Projects\c#\webScrapper-Selenium\webScrapper-Selenium\webScrapper-Selenium\test.txt";
            string coinName, coinSymbol, coinPrice, coinMarketCap, coinSupply, coinVolume24hr;
            chromeDriver.Navigate().GoToUrl("https://coinmarketcap.com/all/views/all/");
            var table = chromeDriver.FindElement(By.XPath("//table[@id='currencies-all']"));
            try
            {
               // "//table[@id='currencies-all']//tr[@id='id-bitcoin']//td[@class='no-wrap currency-name']//a[@class='currency-name-container']"
               
               // coinName = chromeDriver.FindElement(By.XPath("//table[@id='currencies-all']//tr/td//a[@class='currency-name-container']")).Text; //$x("//table[@id='currencies-all']//tr[@id='id-bitcoin']")[0]



                foreach (var row in table.FindElements(By.TagName("thead")))
                {
                    coinName = chromeDriver.FindElement(By.XPath("//table[@id='currencies-all']//tr/td//a[@class='currency-name-container']")).Text;


                    Console.WriteLine(coinName);
                }
                    /* coinSymbol = chromeDriver.FindElement(By.XPath("")).Text;
                                                                                                                                                      coinPrice = chromeDriver.FindElement(By.XPath("")).Text;
                                                                                                                                                      coinMarketCap = chromeDriver.FindElement(By.XPath("")).Text;
                                                                                                                                                      coinSupply = chromeDriver.FindElement(By.XPath("")).Text;
                                                                                                                                                      coinVolume24hr = chromeDriver.FindElement(By.XPath("")).Text;*/

                    //Console.WriteLine("{0} {1} Price:{2} MarketCap:{3} Supply:{4} 24Hr Volume: {5}\n",coinName,coinSymbol,coinPrice,coinMarketCap,coinSupply,coinVolume24hr);  ////table[@id='currencies-all']//tr[@id='id-bitcoin']
                   
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
