using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinJar
{
    public class Program 
    { 
        public static void Main() 
        {
            USCurrency currency = new USCurrency(); 
            CoinJar jar = new CoinJar(32f); 
            Coin newCoin = null; 

            Console.WriteLine("Total Amount: " + jar.TotalAmount); 
            Console.WriteLine("Used Volum: " + jar.UsedVolum);

            newCoin = currency.ManufactureCoinOfAmount("USPenny");
            Console.WriteLine("Coin successfully created: " + (newCoin != null));

            newCoin = currency.ManufactureCoinOfAmount("AusPenny");
            Console.WriteLine("Coin successfully created: " + (newCoin != null));

            jar.AddCoin(currency.ManufactureCoinOfAmount("USHalfDollar"));
            jar.AddCoin(currency.ManufactureCoinOfAmount("USHalfDollar"));
            jar.AddCoin(currency.ManufactureCoinOfAmount("USPenny"));
            jar.AddCoin(currency.ManufactureCoinOfAmount("USQuarter"));
            jar.AddCoin(currency.ManufactureCoinOfAmount("USDollar"));
            jar.AddCoin(currency.ManufactureCoinOfAmount("USDollar"));          
            Console.WriteLine("Total Amount: " + jar.TotalAmount); 
            Console.WriteLine("Used Volum: " + jar.UsedVolum); 

            List<Coin> myCoins = jar.Empty();
            Console.WriteLine("Total Amount: " + jar.TotalAmount);
            Console.WriteLine("Used Volum: " + jar.UsedVolum);
            
        } 
    } 

}
