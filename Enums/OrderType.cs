namespace ConsoleApp1.Enums;

public enum OrderType
{
    // Рыночные ордера
    MARKET_BUY,      // Рыночная покупка
    MARKET_SELL,     // Рыночная продажа
    
    // Лимитные ордера
    LIMIT_BUY,       // Лимитная покупка
    LIMIT_SELL,      // Лимитная продажа
    
    // Стоп ордера
    STOP_BUY,        // Стоп покупка
    STOP_SELL,       // Стоп продажа
    
    // Стоп-лимит ордера
    STOP_LIMIT_BUY,  // Стоп-лимит покупка
    STOP_LIMIT_SELL  // Стоп-лимит продажа
}