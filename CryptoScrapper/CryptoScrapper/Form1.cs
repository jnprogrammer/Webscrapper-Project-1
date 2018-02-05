using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace CryptoScrapper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           // IWebDriver chromeDriver = new ChromeDriver();
           // chromeDriver.Navigate().GoToUrl("https://coinmarketcap.com/all/views/all/");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (var db = new CryptoCurrencyEntities())
            {
                Console.WriteLine("Enter data on a crypto currency");
                var coinName = "Bitcoin";
                var coinSymbol = "BTC";
                var marketCap = 13453;
                var price = 6920;
                var circulatingSupply = 1679;
                var volume24hr = 832649;
                var changeHour = 61;
                var change24hr = 90;
                var changeDay = 38;


                var cryptoTable = new CryptoTable { Id = 1,
                    Name = coinName,
                    Symbol = coinSymbol,
                    MarketCap = marketCap,
                    Price = price,
                    CirculatingSupply = circulatingSupply,
                    Volume24Hour = volume24hr,
                    ChangeHour = changeHour,
                    Change24Hour= change24hr,
                    ChangeDay = changeDay
                  };

                db.CryptoTables.Add(cryptoTable);
                db.SaveChanges();
            }
        }
    }
}