
struct OrderStruct { public decimal Amount; }

class OrderClass{ public decimal Amount; }

class Program
{
    static void Main(string[] args)
    {

        //struct
        var a = new OrderStruct { Amount = 100m };
        var b = a;
        b.Amount = 999m;

        Console.WriteLine($"""
            Struct: 
            a = {a.Amount}
            b = {b.Amount}
            """);

        //class
        var c = new OrderClass { Amount = 100m };
        var d = c;
        d.Amount = 999m;

        Console.WriteLine($"""
            Class: 
            c = {c.Amount}
            d = {d.Amount}
            """);

        var e = new OrderClass { Amount = 100m };
        var f = e;
        e = new OrderClass { Amount = 50m };
        Console.WriteLine($"""
                Class: 
                e = {e.Amount}
                f = {f.Amount}
                """);


    }
}
