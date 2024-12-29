using ConsoleApp1.Enums;

namespace ConsoleApp1.Models;

public class Order
{
    private string _id; //уникальный идентификатор ордера
    private string _traderId; //идентификатор трейдера
    private string _financialInstrumentId; //дентификатор финансового инструмента
    private OrderType _orderType; //тип ордера (enum OrderType: MARKET_BUY, MARKET_SELL, LIMIT_BUY и т.д.)
    private decimal _price; //цена, указанная в ордере
    private int _quantity; //количество финансовых инструментов в ордере
    private OrderStatus _status; //статус ордера (enum OrderStatus: PENDING, EXECUTED, CANCELLED и т.д.)
    private DateTime _createdAt; //дата и время создания ордера
}