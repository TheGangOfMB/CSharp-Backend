# Диагностика: 2 мини-задачи

> **Статус (16.10.2026):** теоретическая диагностика уже пройдена (см. `PROGRESS.md`).
> Задача 1 — по желанию, после тем «коллекции и LINQ».
> Задача 2 — **отложена как контрольная после блока 1**: в ней все текущие дыры сразу (async void, IDisposable, исключения, строки). Решаем её, когда блок 1 закрыт, и сравниваем с тем, что было бы сейчас.

Правила: без ИИ и без копипасты из интернета. Документацию Microsoft смотреть можно, но отметь, что именно смотрел.
Создай консольный проект здесь же (`dotnet new console`) и пиши код в нём.

---

## Задача 1. Отчёт по заказам

```csharp
public enum OrderStatus { Pending, Paid, Cancelled }

public record Order(int Id, string CustomerEmail, decimal Amount, OrderStatus Status, DateTime CreatedAt);
```

Напиши метод:

```csharp
IReadOnlyList<(string Email, decimal Total)> TopCustomers(IEnumerable<Order> orders, int top, DateTime from)
```

Он возвращает `top` клиентов с наибольшей суммой **оплаченных** заказов, созданных не раньше `from`, по убыванию суммы.

Требования:
1. Email сравнивается без учёта регистра (`Ivan@Mail.ru` и `ivan@mail.ru` — один клиент).
2. Сделай две версии: на LINQ и без LINQ (циклы + `Dictionary`).
3. Обработай некорректные аргументы так, как, по-твоему, правильно в продакшене.
4. В `Main` проверь на 5–7 заказах, включая граничные случаи.
5. Напиши в комментарии сложность (Big-O) обеих версий.

---

## Задача 2. Найди баги

Код ниже компилируется. Найди **все** проблемы (их больше трёх), объясни, к чему каждая приведёт в продакшене, и предложи исправленную версию.

```csharp
public class UserService
{
    private static List<User> _cache = new List<User>();

    public async void LoadUsersAsync(string connectionString)
    {
        var connection = new SqlConnection(connectionString);
        connection.Open();

        var cmd = new SqlCommand("SELECT * FROM Users WHERE Name = '" + _filter + "'", connection);
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            _cache.Add(new User { Id = (int)reader["Id"], Name = (string)reader["Name"] });
        }
    }

    private string _filter = "";

    public void SetFilter(string filter) => _filter = filter;

    public User GetUser(int id)
    {
        try
        {
            return _cache.First(u => u.Id == id);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public string BuildReport()
    {
        string result = "";
        foreach (var u in _cache)
            result += u.Id + ": " + u.Name + "\n";
        return result;
    }
}
```

Ответ запиши в `tasks/00-diagnostics/task2.md`.
