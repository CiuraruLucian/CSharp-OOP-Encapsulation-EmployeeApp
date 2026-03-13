# C# OOP Encapsulation – Employee Application

## 📌 Overview

This project is a simple **C# console application** built to demonstrate core **Object-Oriented Programming (OOP)** principles, with a strong focus on **encapsulation**.

The application models an `Employee` object whose internal data is protected using private fields and accessed through controlled public methods.

---

## 🎯 Learning Objectives

This project demonstrates:

* Encapsulation in C#
* Private fields and controlled access
* Getter and Setter (Accessor & Mutator) methods
* Data validation inside class methods
* Constructor usage
* Basic object interaction
* Method-based state modification

---

## 🧱 Project Structure

```
EmployeeApp/
│
├── Program.cs     → Application entry point
└── Employee.cs    → Employee class definition
```

---

## ⚙️ Features

### Employee Class

* Stores employee data securely:

  * Name
  * ID
  * Current Pay

* Prevents invalid data through validation rules:

  * Name must be ≤ 15 characters
  * Employee ID ≤ 1000
  * Salary capped at company limit

### Methods Included

* `GetName()` / `SetName()`
* `GetId()` / `SetId()`
* `GetCurrPay()` / `SetCurrPay()`
* `GiveBonus()`
* `DisplayStats()`

---

## 🧠 Encapsulation Example

Instead of allowing direct access:

```csharp
employee.empName = "John"; // ❌ Not allowed
```

Data is accessed safely:

```csharp
employee.SetName("John");
Console.WriteLine(employee.GetName());
```

This ensures validation and protects object integrity.

---

## ▶️ How to Run

1. Open the project in **Visual Studio**
2. Build the solution
3. Run the application:

```
Ctrl + F5
```

---

## 💻 Technologies Used

* C#
* .NET Console Application
* Object-Oriented Programming (OOP)

---

## 📚 Concepts Practiced

* Encapsulation
* Class Design
* Constructors
* Method Validation
* Object State Management

---

## 🚀 Future Improvements

* Replace getters/setters with C# Properties
* Add exception handling
* Implement inheritance (Manager/Developer classes)
* Store employees in collections
* Add menu-driven interaction

---

## 👤 Author

Lucian Ciuraru

---

⭐ This repository is part of my journey learning C# and software engineering fundamentals.
