# 🛒 AnyStore: Integrated Inventory Management & Billing System

## 📋 Project Overview
**AnyStore** is a high-performance desktop application designed to centralize and automate core business operations. It provides a seamless interface for managing real-time inventory, tracking high-volume sales and purchases, and maintaining a robust database of products, dealers, and customers.

The system is engineered with a strict **Role-Based Access Control (RBAC)** architecture. This ensures a secure environment where administrators maintain full system oversight while standard users focus on efficient day-to-day transaction processing without accessing sensitive configuration data.

---

## 🛠️ Tech Stack

### **Development & Logic**
- **Language**: C# (.NET Framework)
- **Architecture**: N-Tier Architecture principles
- **Data Access**: ADO.NET for high-performance database connectivity

### **UI/UX Design**
- **Framework**: Windows Forms (WinForms)
- **Design System**: Customized modern UI with intuitive navigation flows
- **Visuals**: Guna UI Framework (or standard WinForms controls)

### **Database & Storage**
- **Engine**: Microsoft SQL Server (T-SQL)
- **Schema**: Relational Database Design with 6 core entities
- **Integrity**: Primary Key/Foreign Key constraints with Identity Specification (Auto-Increment)

---

## 🔐 Role-Based Access Control (RBAC)



- **👑 Admin Dashboard**: Grants full "God-Mode" access. Admins can manage the entire user base, configure product categories, adjust global inventory settings, and monitor all transaction logs.
- **👤 User Dashboard**: A streamlined interface focused on the sales and purchase lifecycle. Users handle dealer/customer interactions and billing while restricted from administrative settings.
