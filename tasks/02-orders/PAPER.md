# Задания на бумагу / телефон (20.10.2026)

Без IDE и без гугла. Отвечай письменно, с «почему». Принесёшь ответы на следующее занятие — разберём в начале.

## 1. Найди баг в своём коде (главное)

```csharp
Order order = new Order();
Money money = new Money();
money.Amount = 1000;
ApplyDiscount(order, 10);   // внутри: order.Total.Amount -= percent;  → вышло -10
```

а) Почему получилось `-10`, а не `990`? Где лежит `1000`, а где `order.Total`? Нарисуй стек и кучу.
б) Исправь — напиши 1–2 строки, чтобы 1000 оказалась в заказе. Учти: `Money` — struct.
в) После исправления: если потом сделать `money.Amount = 5000;` — изменится ли `order.Total.Amount`? Почему?

## 2. Перепиши метод правильно (от руки)

`ApplyDiscount(Order order, decimal percent)` — только меняет сумму по формуле, ничего не печатает. Вывод — в `Main`. Нейминг по правилам C#.

## 3. Прогноз вывода

```csharp
// (а)
var list = new List<Money> { new Money { Amount = 100 } };
var m = list[0];
m.Amount = 500;
Console.WriteLine(list[0].Amount);

// (б)
string status = "new";
string copy = status;
status = status.ToUpper();
Console.WriteLine(copy + " " + status);

// (в)
static void Pay(ref Money m) { m.Amount = 0; }
var price = new Money { Amount = 300 };
Pay(ref price);
Console.WriteLine(price.Amount);
```

## 4. Теория своими словами (2–3 предложения на каждый)

а) `git fetch` vs `git pull`.
б) Почему `string` неизменяемый — две причины.
в) Почему `s += x` в цикле на 10 000 элементов — плохо, и что использовать.
