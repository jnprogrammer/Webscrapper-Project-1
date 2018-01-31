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
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://coinmarketcap.com/all/views/all/");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }


    }
}