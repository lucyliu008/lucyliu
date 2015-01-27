using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CoinJar
{
    public class CoinJar 
    { 
 	    public List<Coin> Coins { get; set; }
        public float TotalVolume { get; set; } 	 
 	    public float UsedVolume { get; set; }	 
 	    public decimal TotalAmount { get; set; } 
 	 
 	    public CoinJar(float JarSizeOunces) 
 	    { 
 		    this.Coins = new List<Coin>();
            this.TotalAmount = 0.00M;
            this.TotalVolume = JarSizeOunces;
            this.UsedVolume = 0f; 
 	    } 
 	 
 	    public bool AddCoin(Coin coin) 
 	    { 
 		    if (coin == null || coin.Currency != typeof(USCurrency)) 
 		    { 
 			    return false;
 		    }

            if (coin.Volume + this.UsedVolume > TotalVolume) 
 		    {
                return false;
                throw new Exception("Coin Jar has reached capacity and no more couns can be added");
 			     
 		    } 
 		 
 		    this.Coins.Add(coin); 
 		    this.TotalAmount += coin.Amount; 
 		    this.UsedVolume += coin.Volume; 
  
 		    return true; 
 	    } 
 	 
 	    public List<Coin> Empty() 
 	    {            
            List<Coin> coins = this.Coins;
 		    this.TotalAmount = 0.00M; 
 		    this.UsedVolume= 0f;
            this.TotalVolume = 0f;
 		    return coins; 
 	    } 
    } 

}

