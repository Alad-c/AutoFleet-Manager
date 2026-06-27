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
<img width="830" height="513" alt="Screenshot 2026-06-27 140005" src="https://github.com/user-attachments/assets/fb35450d-4650-4697-84a4-71ff0ee6d9cc" />
<img width="689" height="416" alt="Screenshot 2026-06-27 140503" src="https://github.com/user-attachments/assets/9bb2f48b-1df2-494f-80dd-74e657ba7a90" />
