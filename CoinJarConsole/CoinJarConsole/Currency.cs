using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CoinJar
{
    public abstract class Currency 
    { 
 	    public abstract Coin ManufactureCoinOfAmount(string Name); 
    } 
 
    public class USCurrency : Currency 
    { 
              
        private static Hashtable CoinTypes { get; set; }
   
 	    static USCurrency() 
 	    {
            Type CurrencyType = typeof(USCurrency); 
 		    CoinTypes = new Hashtable();

            // Coins Volume is based on US mint  http://www.usmint.gov/about_the_mint/?action=coin_specifications
            CoinTypes.Add("USPenny", new Coin(CurrencyType, 0.01M, 0.0882f));
            CoinTypes.Add("USNickel", new Coin(CurrencyType, 0.05M, 0.1764f));
            CoinTypes.Add("USDime", new Coin(CurrencyType, 0.10M, 0.0800f));
            CoinTypes.Add("USQuarter", new Coin(CurrencyType, 0.25M, 0.2000f));
            CoinTypes.Add("USHalfDollar", new Coin(CurrencyType, 0.50M, 0.4000f));
            CoinTypes.Add("USDollar",new Coin(CurrencyType, 1.00M, 0.2857f));
 	    }


        public override Coin ManufactureCoinOfAmount(string Name)
        {
            Coin modelCoin = null;

            if (CoinTypes.ContainsKey(Name))
            {
                modelCoin = (Coin)CoinTypes[Name];

            }
            return modelCoin;
        }
    } 

}