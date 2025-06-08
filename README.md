# 🏦 ATMMachineSolution

A secure and modular **ATM Machine Simulation API** built with **ASP.NET Core Web API (.NET 6)** using **SOLID principles** and a clean architecture approach. This project allows simulation of PIN validation, balance inquiries, withdrawals, and deposits, designed for integration with a frontend like React.

---

## ✨ Features

- ✅ PIN validation with mock data
- 💰 View account balance
- ➕ Deposit funds
- ➖ Withdraw funds
- 🧱 Clean project structure (Core, Infrastructure, API, Tests)
- 📘 Interactive Swagger documentation
- 🧪 NUnit-based unit tests

---

## 📂 Project Structure

```
ATMMachineSolution/
├── ATMMachine.Core/           # Interfaces and domain models
├── ATMMachine.Infrastructure/ # Implementation of account service
├── ATMMachine.WebApi/         # Web API with Swagger
├── ATMMachine.Tests/          # Unit test project
└── ATMMachineSolution.sln     # Solution file
```

---

## 🚀 Getting Started

### 🛠 Requirements

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

### ⚙️ Build and Run the API
bash
dotnet restore
dotnet build
dotnet run --project ATMMachine.WebApi

Open your browser and navigate to:
http://localhost:5000/swagger

> If you see an HTTPS browser error, switch the address to use `http://` instead of `https://`.

-------------------

## 🔗 API Endpoints

| Route                        | Method | Description         |
|-----------------------------|--------|---------------------|
| `/api/atm/validate`         | POST   | Validate PIN        |
| `/api/atm/balance/{card}`   | GET    | Get account balance |
| `/api/atm/withdraw`         | POST   | Withdraw funds      |
| `/api/atm/deposit`          | POST   | Deposit funds       |

---

## 🔐 Example Requests

**Validate PIN:**
```json
POST /api/atm/validate
{
  "cardNumber": "1234567890",
  "pin": "1234"
}
```

**Withdraw Funds:**
```json
POST /api/atm/withdraw
{
  "cardNumber": "1234567890",
  "amount": 100
}
```

---

## 🧪 Running Tests

```bash
dotnet test
```

---

## 💡 Design Principles

This project is designed with SOLID principles:
- Single Responsibility
- Open/Closed
- Liskov Substitution
- Interface Segregation
- Dependency Inversion

---

## 📘 License

MIT License © 2025

