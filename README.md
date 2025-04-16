# 🧮 Shape Calculator Console App

This C# console application allows users to calculate the **area** and **circumference** of multiple 2D geometric shapes: **Circle**, **Square**, **Rectangle**, and **Triangle**.

It showcases fundamental OOP (Object-Oriented Programming) concepts including **abstraction**, **inheritance**, and **polymorphism**.

---

## 📌 Features

- Prompt-based input via the console
- Supports the following shapes:
  - 🔵 Circle
  - ◼️ Square
  - ▭ Rectangle
  - 🔺 Triangle
- Calculates:
  - 📐 Area
  - 📏 Circumference (where applicable)
- Interactive loop for multiple calculations

---

## 🧠 OOP Concepts Used

| Concept        | Implementation                                                |
|----------------|---------------------------------------------------------------|
| Abstraction    | `Shape` is an abstract class with required methods to implement |
| Inheritance    | Each shape (`Circle`, `Square`, `Rectangle`, `Triangle`) inherits from `Shape` |
| Polymorphism   | Each class overrides `area()`, `circumference()`, and `Print()` |
| Encapsulation  | Shape data is managed through constructors and private fields  |

---


## 💬 Sample Interaction

A Program To Clac Area And Circumference : ( Circle , Square , Rectangle , Triangle ) 
Enter What Shape You Need Of (Circle , Square , Rectangle , Triangle) :
Circle
Enter The Radius Of The Circle : 
5
The Area Of Circle is : 78.5
The circumference Of Circle is : 31.400000000000002
Wanna Calc Again ?
Yes
...

