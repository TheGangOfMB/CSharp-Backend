# ROADMAP: C# Backend → Junior .NET

Тема закрыта = объяснил своими словами + решил задачу без подсказок + ответил на 3 собесных вопроса.

> Программа будет скорректирована по итогам диагностики (см. `PROGRESS.md`).

## 1. Язык C#
- [ ] Типы значений и ссылочные, stack/heap
- [ ] Boxing/unboxing
- [ ] string и иммутабельность, StringBuilder
- [ ] Nullable (value types и nullable reference types)
- [ ] Классы, структуры, record
- [ ] Интерфейсы и абстрактные классы
- [ ] Generics и ограничения
- [ ] Делегаты, события, лямбды, замыкания
- [ ] Исключения
- [ ] IDisposable / using
- [ ] Pattern matching

## 2. Коллекции и LINQ
- [ ] List, Dictionary, HashSet, Queue — устройство и сложность
- [ ] Big-O операций
- [ ] IEnumerable, yield, отложенное выполнение
- [ ] IEnumerable vs IQueryable
- [ ] LINQ: основные операторы и подводные камни

## 3. Как работает .NET
- [ ] CLR, IL, JIT
- [ ] GC, поколения, LOH
- [ ] Span/Memory (понимание)

## 4. Асинхронность
- [ ] Потоки vs задачи, ThreadPool
- [ ] Task, async/await под капотом (state machine)
- [ ] ConfigureAwait, SynchronizationContext, deadlock'и
- [ ] CancellationToken
- [ ] lock, гонки, конкурентные коллекции

## 5. ООП и дизайн
- [ ] SOLID на живых примерах
- [ ] Strategy, Factory, Decorator
- [ ] Repository, Mediator
- [ ] DRY / KISS / YAGNI, когда паттерн вредит

## 6. Базы данных
- [ ] SQL руками: SELECT, JOIN, GROUP BY
- [ ] Индексы
- [ ] Транзакции и уровни изоляции
- [ ] Нормализация
- [ ] PostgreSQL
- [ ] EF Core: миграции, tracking, Include, N+1
- [ ] Dapper

## 7. ASP.NET Core
- [ ] HTTP и REST по-взрослому
- [ ] Web API: контроллеры и Minimal API
- [ ] DI и lifetime'ы
- [ ] Middleware pipeline
- [ ] Конфигурация и Options
- [ ] Логирование (Serilog)
- [ ] Валидация
- [ ] Обработка ошибок, ProblemDetails
- [ ] Версионирование, Swagger/OpenAPI
- [ ] ИИ как рабочий инструмент: постановка задачи, проверка кода

## 8. Безопасность
- [ ] Аутентификация vs авторизация
- [ ] JWT, refresh-токены
- [ ] Хеширование паролей
- [ ] OWASP Top 10 (база)

## 9. Тестирование
- [ ] xUnit
- [ ] Моки (Moq/NSubstitute)
- [ ] Unit vs интеграционные тесты
- [ ] Testcontainers

## 10. Инфраструктура
- [ ] Docker, docker-compose
- [ ] Redis, кэширование
- [ ] RabbitMQ или Kafka (база)
- [ ] Фоновые задачи (BackgroundService)
- [ ] CI в GitHub Actions

## 11. Архитектура
- [ ] Слоистая архитектура
- [ ] Clean Architecture
- [ ] CQRS
- [ ] Монолит vs микросервисы
- [ ] System design для джуна

## 12. Алгоритмы для собесов
- [ ] Массивы и строки
- [ ] Хеш-таблицы
- [ ] Два указателя
- [ ] Сортировки
- [ ] Рекурсия
- [ ] Деревья и графы (база)

## 13. Трудоустройство
- [ ] Резюме
- [ ] GitHub-профиль и README пет-проекта
- [ ] Разбор вакансий
- [ ] Мок-собес: теория
- [ ] Мок-собес: live coding
- [ ] Мок-собес: поведенческие вопросы

## Пет-проект (`project/`)
- [ ] Консольный прототип (доменная модель)
- [ ] Коллекции/LINQ в домене
- [ ] Async I/O
- [ ] Рефакторинг по SOLID
- [ ] PostgreSQL + EF Core
- [ ] Web API
- [ ] Авторизация (JWT)
- [ ] Тесты (unit + интеграционные)
- [ ] Docker + docker-compose, Redis
- [ ] CI в GitHub Actions
- [ ] README, деплой — проект для резюме
