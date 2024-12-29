using ConsoleApp1.Enums;

namespace ConsoleApp1.Models;

public class Option : FinancialInstrument
{
    private string _underlyingAssetId; // ID базового актива
    private decimal _strikePrice;  // Цена исполнения
    private DateTime _expirationDate;  // Дата истечения 
    private OptionType _optionType; // Тип опциона (CALL, PUT и т.д.)
    private decimal _premium; // Премия (цена опциона)

    public Option(string id, string symbol, string name, decimal currentPrice, DateTime issuedDate, string issuer, string underlyingAssetId, decimal strikePrice, DateTime expirationDate, OptionType optionType, decimal premium) : base(id, symbol, name, currentPrice, issuedDate, issuer)
    {
        _underlyingAssetId = underlyingAssetId;
        _strikePrice = strikePrice;
        _expirationDate = expirationDate;
        _optionType = optionType;
        _premium = premium;
    }
}