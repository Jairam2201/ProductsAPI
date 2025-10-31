# 🛒 Products Management API — ASP.NET Core Web API

A fully functional **ASP.NET Core Web API** built for managing products with CRUD operations, database integration using **Entity Framework Core**, and integration with a **third-party currency API** (ExchangeRate API).  
This project demonstrates strong backend design, clean architecture, and RESTful API practices.

---

## 🚀 Features

### 🧩 Product Management (CRUD)
- Add, view, edit, and delete product records.
- Supports up to **12 product properties**, including name, category, price, stock, brand, etc.
- Implements **RESTful API standards** with proper status codes.

### 🌐 Third-Party API Integration
- Integrated with **ExchangeRate-API** to fetch live currency exchange data.
- Designed for easy extension to other external APIs.

### 🗃️ Database Integration
- SQL Server database created with **Entity Framework Core (Code First)**.
- Includes migrations and a `.sql` file for manual setup.
- Two tables:
  - `Products`
  - `ExternalApiLogs`

---

## 🧱 Technologies Used

| Category | Technology |
|-----------|-------------|
| Framework | ASP.NET Core 9.0 Web API |
| ORM | Entity Framework Core |
| Language | C# |
| Database | Microsoft SQL Server |
| Tools | Visual Studio / VS Code |
| Testing | Postman |
| Third-Party API | ExchangeRate-API |
| Version Control | Git + GitHub |

---

## 🧰 Project Structure

