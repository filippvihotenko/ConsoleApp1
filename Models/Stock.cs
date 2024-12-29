using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models;

public class Stock : FinancialInstrument, IDividendPaying
{
    private long _shares;                // Количество акций
    private decimal _dividendAmount;  // Размер дивиденда на акцию
    private String _companyName;         // Название компании
    private String _sector;              // Сектор экономики
    private DateTime _dividendDate;     // Дата следующей 

    public Stock(string id, string symbol, string name, decimal currentPrice, DateTime issuedDate, string issuer, long shares, decimal dividendAmount, string companyName, string sector, DateTime dividendDate) : base(id, symbol, name, currentPrice, issuedDate, issuer)
    {
        _shares = shares;
        _dividendAmount = dividendAmount;
        _companyName = companyName;
        _sector = sector;
        _dividendDate = dividendDate;
    }
    
    public void PayDividend()
    {
        _dividendDate = DateTime.Now;
        _dividendAmount = decimal.Zero;
    }
    
}