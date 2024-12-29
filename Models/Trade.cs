namespace ConsoleApp1.Models;

public class Trade
{
    private string _id;  // Уникальный id
    private string _buyOrderId;  // ID ордера на покупку
    private string _sellOrderId; // ID ордера на продажу
    private decimal _executionPrice;  // Цена исполнения сделки

    public Trade(string id, string buyOrderId, string sellOrderId, decimal executionPrice)
    {
        _id = id;
        _buyOrderId = buyOrderId;
        _sellOrderId = sellOrderId;
        _executionPrice = executionPrice;
    }

    public string Id
    {
        get => _id;
        set => _id = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string BuyOrderId
    {
        get => _buyOrderId;
        set => _buyOrderId = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string SellOrderId
    {
        get => _sellOrderId;
        set => _sellOrderId = value ?? throw new ArgumentNullException(nameof(value));
    }

    public decimal ExecutionPrice
    {
        get => _executionPrice;
        set => _executionPrice = value;
    }
}