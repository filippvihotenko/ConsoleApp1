namespace ConsoleApp1.Models;

public class Market
{
    private string _id;
    private string _name;
    private DateTime _tradingHours;
    private bool _isOpen;
    private List<Trader> _traders;
    private List<Portfolio> _portfolios;

    public Market(string id, string name, DateTime tradingHours, bool isOpen, List<Trader> traders, List<Portfolio> portfolios)
    {
        _id = id;
        _name = name;
        _tradingHours = tradingHours;
        _isOpen = isOpen;
        _traders = traders;
        _portfolios = portfolios;
    }

    public string Id
    {
        get => _id;
        set => _id = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime TradingHours
    {
        get => _tradingHours;
        set => _tradingHours = value;
    }

    public bool IsOpen
    {
        get => _isOpen;
        set => _isOpen = value;
    }

    public List<Trader> Traders
    {
        get => _traders;
        set => _traders = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Portfolio> Portfolios
    {
        get => _portfolios;
        set => _portfolios = value ?? throw new ArgumentNullException(nameof(value));
    }
}