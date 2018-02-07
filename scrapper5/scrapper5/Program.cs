using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace scrapper5
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new CryptoContext())
            {
                Console.WriteLine("Enter data on a crypto currency");
                var coinName = "Bitcoin";
                var coinSymbol = "BTC";
                var marketCap = 13453;
                var price = 6920;
                var circulatingSupply = 1679;
                var volume24hr = 832649;
               


                var cryptoTable = new CryptoTable
                {
                    Id = 1,
                    CoinName = coinName,
                    CoinSymbol = coinSymbol,
                    MarketCap = marketCap,
                    Price = price,
                    Circulating_Supply_ = circulatingSupply,
                    Volume24hr = volume24hr
                    
                };

                db.CryptoTables.Add(cryptoTable);
                db.SaveChanges();
            }
        }
    }
}
