// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Invoice invoice = new Invoice();
Water water = new Water();

Console.WriteLine("Hello, World!");
PrintHola();


void PrintHola ()
{
    Console.WriteLine("Tu Puta madre");
}


public interface IDrink {
    public string Name { get; set; }
    public decimal Invoice { get; set; }
    public decimal Price { get; set; }
    public decimal GetPrice();
}

public class Water : IDrink
{
    public string Name { get; set; }
    public decimal Invoice { get; set; }
    public decimal Price { get; set; }
    public decimal GetPrice()
    {
        return Price * Invoice;
    }
}

public class Alcohol : IDrink
{
    public string Name { get; set; }
    public decimal Invoice { get; set; }
    public decimal Price { get; set; }
    public decimal Promo { get; set; }
    public decimal GetPrice()
    {
        return (Price * Invoice) - Promo;
    }
}

public class Sugary : IDrink
{
    public string Name { get; set; }
    public decimal Invoice { get; set; }
    public decimal Price { get; set; }
    public decimal Expiration { get; set; }
    public decimal GetPrice()
    {
        return (Price * Invoice) - Expiration;
    }
}

public class Invoice
{
    public decimal GetTotal(IEnumerable<IDrink> ListDrink)
    {
        decimal total = 0;
        foreach(var drink in ListDrink)
        {
            total += drink.GetPrice();
        }
        return total;
    }
}