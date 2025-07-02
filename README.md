# asp_net_project

Проект для изучения и закрепления знаний `ASP.NET Core MVC`

> [!WARNING]
> предпологается что все действия происходят из корня проекта

* [Требуется .NET 9](https://dotnet.microsoft.com/download/dotnet/9.0)

## Клонирование репозитория

```cmd
git clone https://github.com/nais2008/asp_net_project
cd ./asp_net_project/
```

## Установка пакетов

```cmd
dotnet restore
```

## Заполнение переменных среды

```env
# Секретный ключ
DOTNET_SECRET_KEY=your_secret_key
# Включить ли логирование
DOTNET_ENABLE_LOGGING=false
# Хост и порт
DOTNET_HOST=localhost
DOTNET_PORT=5005
```

## Запуск проекта

```cmd
dotnet run
```
