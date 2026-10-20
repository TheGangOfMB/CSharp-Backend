struct Money { public decimal Amount; public string Currency; };

class Order { public int id; public Money Total; public string Status; }

class Project
{
    static void Main(string[] args)
    {
        Order order = new Order();
        Money money = new Money();

        money.Amount = 1000;
        decimal percent = 10;

        ApplyDiscount(order, percent);


    }

    static void ApplyDiscount(Order order, decimal percent)
    {
        order.Total.Amount -= percent;
        decimal sum = order.Total.Amount;

        Console.WriteLine($"стоимость со скидной в {percent}% = {sum}"); // прогноз: стоимость со скидной в 10% = 900
        // ошибка: получается -10, так процент надо расчитывать не тупо вычитая процент, а использовать формулу: цена * (1 - процент / 100)

        order.Total.Amount = 1000;
        order.Total.Amount = order.Total.Amount * (1 - percent / 100);
        decimal CorrectSum = order.Total.Amount;
        Console.WriteLine($"стоимость со скидной в {percent}% = {CorrectSum}"); // Теперь лдолжно быть правильно
        // ошибка: получается -9,0, значит проблемма не в вычислениях
    }
}
