using CPSC1012Lab06Glaiza;
using System.Diagnostics.Metrics;


Stock stock = new Stock();
string symbol = "";

Console.Write("Enter the stock name: ");
stock.Name = Console.ReadLine();
Console.Write("Enter the stock symbol: ");
stock.Symbol = Console.ReadLine();
Console.Write($"Enter the {stock.Name} ({stock.Symbol}) previous closing price: ");
stock.PreviousClosingPrice = double.Parse(Console.ReadLine());
Console.Write($"Enter the {stock.Name} ({stock.Symbol}) current stock price: ");
stock.CurrentPrice = double.Parse(Console.ReadLine());
if (stock.CurrentPrice > stock.PreviousClosingPrice)
{
    symbol = "+";
}

Console.WriteLine($"\n\n{stock.Name} ({stock.Symbol}):Current price - ${stock.CurrentPrice}, {symbol}{stock.ChangePrice()} ({symbol}{stock.ChangePercent()}%)");


