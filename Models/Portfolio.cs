namespace ConsoleApp1.Models;

public class Portfolio
{
    private string _id;
    private string _ownerId;
    private List<FinancialInstrument> _financialInstruments;
    private decimal _totalValue;
    private DateTime _lastUpdated;
}