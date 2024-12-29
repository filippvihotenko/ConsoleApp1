namespace ConsoleApp1.Enums;

public enum OrderStatus
{
    PENDING,        // Ожидает исполнения
    
    // Промежуточные статусы
    PARTIALLY_FILLED, // Частично исполнен
    PROCESSING,      // В процессе обработки
    
    // Конечные статусы
    EXECUTED,        // Полностью исполнен
    CANCELLED,       // Отменён
    REJECTED,        // Отклонён
    EXPIRED         // Истёк срок действия
}