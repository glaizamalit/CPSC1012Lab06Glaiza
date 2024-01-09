using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012Lab06Glaiza
{
    internal class Stock
    {
        // Properties - auto implemented
        public double CurrentPrice { get; set; }
        public string Name { get; set; }
        public double PreviousClosingPrice { get; set; }
        public string Symbol { get; set; }


        // Methods
        public double ChangePercent()
        {
            double changePercent;
            changePercent = Math.Round((CurrentPrice - PreviousClosingPrice) / PreviousClosingPrice * 100, 2);
            return changePercent;
        }

        public double ChangePrice()
        {
            double changePrice;
            int currentLength = CurrentPrice.ToString().Substring(CurrentPrice.ToString().IndexOf(".") + 1).Length;
            int previousLength = PreviousClosingPrice.ToString().Substring(PreviousClosingPrice.ToString().IndexOf(".") + 1).Length;
            int decimalPlaces;
            if (currentLength > previousLength)
            {
                decimalPlaces = currentLength;
            }
            else
            {
                decimalPlaces = previousLength;
            }
            changePrice = CurrentPrice - PreviousClosingPrice;
            return Math.Round(changePrice, decimalPlaces);
        }


        public Stock()
        {
            Name = "";
            Symbol = "";
            PreviousClosingPrice = 0;
            CurrentPrice = 0;
        }

        public Stock(string name, string symbol, double previousClosingPrice, double currentPrice)
        {
            CurrentPrice = currentPrice;
            Name = name;
            PreviousClosingPrice = previousClosingPrice;
            Symbol = symbol;
        }
    }
}
