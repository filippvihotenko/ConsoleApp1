using ConsoleApp1.Enums;

namespace ConsoleApp1.Models;

public class Bond : FinancialInstrument
{
    private decimal _faceValue; //номинальная стоимость облигации
    private decimal _couponRate; //купонная ставка
    private DateTime _maturityDate; // дата погашения облигации
    private string _rating; //кредитный рейтинг облигации
    private int _interestPaymentFrequency; //частота выплаты процентов
    private string _company;

    public Bond(string id, string symbol, string name, decimal currentPrice, DateTime issuedDate, string issuer, decimal faceValue, decimal couponRate, DateTime maturityDate, string rating, int interestPaymentFrequency, string company) : base(id, symbol, name, currentPrice, issuedDate, issuer)
    {
        _faceValue = faceValue;
        _couponRate = couponRate;
        _maturityDate = maturityDate;
        _rating = rating;
        _interestPaymentFrequency = interestPaymentFrequency;
        _company = company;
    }

    public decimal calculateYieldToMaturity()
    {
        double timeToMaturity = _maturityDate.Subtract(DateTime.Now).TotalDays;
        decimal ytm = _couponRate + (_faceValue - currentPrice)  / (_faceValue * (decimal)timeToMaturity);
        return ytm;
    }
}