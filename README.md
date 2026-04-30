# Tiny C# Projects 🚀

This repository is dedicated to my learning journey in C# and the .NET ecosystem. Here, I document my progress as I transition from Python to a strongly-typed, object-oriented language.

## 📌 Roadmap
My goal is to build a series of small projects to master the following concepts:
- [x] **Hello World:** Setting up the environment and first output.
- [x] **Variable Types & Logic:** Exploring C# syntax and basic operators.
- [x] **Control Flow:** Building decision-making logic (If/Else, Switch).
- [x] **Object-Oriented Programming (OOP):** Classes, Inheritance, and Polymorphism.
- [x] **File Management:** Porting my Python persistence logic to C#.
- [x] **LINQ:** Learning how to query data efficiently in .NET.

## 🛠️ Tech Stack
- Language: C#
- Framework: .NET 8.0
- IDE: Visual Studio Code / Visual Studio

## 📈 Current Status
Starting with the basics! Every great software started with a `Console.WriteLine("Hello World!");`.

# 🏦 WorldBank LINQ

A console-based banking system built in C# focusing on **Object-Oriented Programming (OOP)**, JSON data persistence, and advanced in-memory queries using **LINQ**. The project simulates real banking operations, dividing the scope between the Customer experience and a hidden administrative panel.

## 🏗️ Project Architecture
The code was refactored and structured following industry standards, separating responsibilities to facilitate maintenance and scalability:
* **Entities (Models):** Classes that represent business rules and data (`User`, `Account`, `Admin`). Applies concepts of Inheritance and Polymorphism.
* **Services:** Classes responsible for processing logic and data persistence (`Bank`). Uses Composition ("Has-a" relationship).
* **Persistence:** Data is saved locally in a `bank_data.json` file, ensuring that accounts and balances survive after the application is closed.

## ✨ Features (Customer View)
Any regular user who starts the program can access standard ATM services:
* Account creation (with input validation and error prevention).
* Login system via account number and password.
* **Main Balance:** Deposits and Withdrawals on the main balance.
* **Vault (Savings):** Transfer of funds to a savings area separate from the main balance.

---

## 🕵️‍♂️ The Secret Admin Panel

WorldBank features a hidden administrative panel in the main menu, accessible only to those with Master credentials. This panel was built to demonstrate the power of **C# LINQ (Language Integrated Query)** to perform mathematical operations and complex filters on object lists instantly.

### How to access:
1. In the main menu, type the secret option: `0`
2. **Master Code:** `MASTER`
3. **Master Password:** `MASTER123`

### LINQ Superpowers Implemented:
Inside the panel, the Administrator has access to real-time auditing tools:
* **Account Audit:** Counts how many registered customers exist in the bank.
* **Capital Sum (LINQ `.Sum`):** Instantly calculates and displays the sum of all money stored in the bank (Main Balance + Vault of all customers).
* **Empty Accounts Filter (LINQ `.Where`):** Tracks and lists the names and account numbers of all customers who have an absolutely zeroed balance (0 in the main balance and 0 in the vault).
