# AutoFleet Manager 🚗

A robust Windows desktop application built with **C# (.NET WinForms)** and **SQLite**, designed to manage vehicle fleets, rental inventory, and transactional data efficiently.

## 🛠 Tech Stack
* **Language:** C#
* **Framework:** .NET Windows Forms (WinForms)
* **Database:** SQLite (Local relational database)
* **Architecture:** Object-Oriented Programming (OOP), ADO.NET

## 🚀 Key Features
* **Full CRUD Functionality:** Seamlessly Add, Update, Read, and Delete vehicle records.
* **Dynamic Search Module:** Advanced filtering utilizing multiple relational operators (`=`, `<`, `>`, `<=`, `>=`) and dynamic UI updates via `DataGridView`.
* **Data Integrity & Validation:** Implemented strict data parsing (e.g., currency formatting, integer validation for mileage) and protective guard clauses to prevent run-time application crashes.
* **Custom Navigation & UI:** Built-in record navigation (First, Last, Next, Previous) with state-aware button disabling and dynamic record counting.

## 🧠 Architectural Highlights
The application separates the internal `Car` data model from the UI presentation layer. Database connections and SQL executions are handled via an independent `SQLiteManager` class, ensuring clean code structure and minimizing SQL injection risks during data updates. 
