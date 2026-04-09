# 🛒 AnyStore: Integrated Inventory Management & Billing System

![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/Framework-.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![SQL Server](https://img.shields.io/badge/Database-SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

**AnyStore** is a high-performance desktop application designed to centralize and automate core business operations. It provides a seamless interface for managing real-time inventory, tracking high-volume sales and purchases, and maintaining a robust database of products, dealers, and customers.

---

## 📑 Table of Contents
- [✨ Key Features](#-key-features)
- [🛠️ Tech Stack](#-tech-stack)
- [🏗️ System Architecture](#-system-architecture)
- [🔐 Role-Based Access Control (RBAC)](#-role-based-access-control-rbac)
- [👨‍💻 Developers](#-developers)

---

## ✨ Key Features

- **Real-Time Inventory Management**: Track stock levels dynamically as sales and purchases occur.
- **Comprehensive Billing Module**: Generate accurate invoices for customers and track purchase orders from dealers.
- **Entity Management**: Easily add, update, and manage records for **Products**, **Categories**, **Customers**, and **Dealers**.
- **Transaction Logs**: Keep a detailed history of all business transactions for auditing and accounting purposes.
- **Modern UI**: Clean, intuitive interface designed for ease of use during fast-paced retail operations.

---

## 🛠️ Tech Stack

| Component | Technology |
| :--- | :--- |
| **Language** | C# |
| **Framework** | .NET Framework (Windows Forms) |
| **Database** | Microsoft SQL Server (T-SQL) |
| **Data Access** | ADO.NET |
| **UI Components**| Guna UI Framework |

---

## 🏗️ System Architecture

This project strictly follows **N-Tier Architecture** to separate concerns, making the codebase highly maintainable, scalable, and secure.

* **UI (User Interface)**: The presentation layer containing all Windows Forms and visual elements.
* **BLL (Business Logic Layer)**: Contains the core rules, calculations, and logic of the application. Acts as a bridge between UI and DAL.
* **DAL (Data Access Layer)**: Handles all database interactions, including CRUD operations using ADO.NET.

---

## 🔐 Role-Based Access Control (RBAC)

The system features two distinct access levels to ensure security and operational efficiency:

* **👑 Admin Dashboard ("God-Mode")**: 
  - Manage user accounts and passwords.
  - Configure product categories and global inventory settings.
  - View comprehensive transaction logs and business reports.
  
* **👤 User Dashboard**: 
  - Streamlined for point-of-sale and daily operations.
  - Manage dealer/customer interactions and generate bills.
  - Restricted from administrative settings to prevent unauthorized changes.

---

## 👨‍💻 Author

**Hardik Patel**  
GitHub: https://github.com/Hardik-2510

---

## ⭐ Support

If you found this project useful, please consider giving it a ⭐ on GitHub!