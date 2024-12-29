namespace ConsoleApp1.Models;

public class Trader
{
   private string _id;
   private string _name;
   private string _surname;
   private string _email;
   private decimal _balance;
   private List<Order> _orders;
   private Portfolio _portfolio;
}