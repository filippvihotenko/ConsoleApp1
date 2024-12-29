using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models;

public abstract class FinancialInstrument
{
    protected string id;
    protected string symbol;
    protected string name;
    protected decimal currentPrice;
    protected DateTime issuedDate;
    protected string issuer;
    protected Decimal volatility;
    protected List<decimal> priceHistory;
    protected int historySize = 30;
    
    protected FinancialInstrument(string id, string symbol, string name, decimal currentPrice, DateTime issuedDate, string issuer)
    {
        id = id;
        symbol = symbol;
        name = name;
        currentPrice = currentPrice;
        issuedDate = issuedDate;
        issuer = issuer;
    }

    public decimal CurrentPrice
    {
        get => currentPrice;
        set => currentPrice = value;
    }

    public void UpdatePriceFromTrade(Trade trade)
    {
        if (currentPrice== null ||  trade.ExecutionPrice.CompareTo(currentPrice) < 0)
        {
           this.currentPrice = trade.ExecutionPrice;
        }
    }

    protected decimal calculateVolatility()
    {
        decimal sumOfPrices = priceHistory.Sum();
        decimal sumOfSquares = 0;
        decimal n = 0;
        foreach (var price in priceHistory)
        {
            sumOfSquares += DecimalPow(price, 2);
            n += 1;
        }
        return Sqrt(sumOfSquares / n - 1);
    }
    
    public static decimal Sqrt(decimal x, decimal epsilon = 0.0M)
    {
        if (x < 0) throw new OverflowException("Cannot calculate square root from a negative number");
        decimal current = (decimal)Math.Sqrt((double)x), previous;
        do
        {
            previous = current;
            if (previous == 0.0M) return 0;
            current = (previous + x / previous) / 2;
        }
        while (Math.Abs(previous - current) > epsilon);
        return current;
    }

    static decimal DecimalPow(decimal x, int power)
    {
        decimal result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= x;
        }
        return result;
    }

    
}