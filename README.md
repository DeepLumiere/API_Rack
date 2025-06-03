# DeepRack - ASP.NET Core Web API with PostgreSQL

This project is a simple ASP.NET Core Web API that allows users to book and view appointments. It uses PostgreSQL as the database and Entity Framework Core for ORM.

---

## 🚀 Features

- Book appointments through a public API
- Store appointments in PostgreSQL
- Use EF Core Migrations to manage the database schema
- Swagger UI for API testing

---

## 🛠️ Prerequisites

Make sure you have the following installed:

- [.NET SDK 9.0+](https://dotnet.microsoft.com/en-us/download)
- [PostgreSQL](https://www.postgresql.org/)
- [dotnet-ef CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

Install EF Core CLI if not already installed:

```bash
dotnet tool install --global dotnet-ef
```

## 🎫 Database setup
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 🚀 Running the Project
```bash
dotnet run
```
Navigate to: https://localhost:{port}/swagger

## 👨‍💻 Author
Deep Joshi
CSE @ Nirma University | NASA Space Apps Lead | Passionate about AI, Education & Code Innovation 🚀

