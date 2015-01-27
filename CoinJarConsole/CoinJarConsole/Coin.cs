using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinJar
{
    public class Coin 
    { 
 	    public Type Currency { get; private set; }
        public decimal Amount { get; private set; }
        public float Volume { get; private set; }

        public Coin(Type Currency, decimal Amount, float Volume)
        {
            this.Currency = Currency;
            this.Amount = Amount;
            this.Volume = Volume; 

        }
    }
}
