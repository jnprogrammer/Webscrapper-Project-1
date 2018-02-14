using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
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

            public int Price { get; set; }
                      
        }
        public class CryptoContext : DbContext
        {
            public DbSet<CryptoTable> CryptoTables { get; set; }
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



               // foreach (var row in table.FindElements(By.TagName("tbody")))
               
                coinName = chromeDriver.FindElement(By.XPath("//table[@id='currencies-all']//tr/td//a[@class='currency-name-container']")).Text;
                coinSymbol = chromeDriver.FindElement(By.XPath("//table[@id='currencies-all']//tr/td[@class='text-left col-symbol']")).Text;
                coinPrice = chromeDriver.FindElement(By.XPath("//table[@id='currencies-all']//tr/td//a[@class='price']")).Text;

                // < td class="text-left col-symbol">BTC</td>
                Console.WriteLine(coinName);
                Console.WriteLine(coinSymbol);
                Console.WriteLine(coinPrice);



                using (var db = new CryptoContext())
                {
                    var aCryptoTable = new CryptoTable { CoinName = coinName, CoinSymbol = coinSymbol };
                    db.CryptoTables.Add(aCryptoTable);
                    db.SaveChanges();

                    var query = from b in db.CryptoTables
                                orderby b.CoinName
                                select b;

                    foreach (var item in query)
                    {
                        Console.WriteLine(item.CoinSymbol);
                    }
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
