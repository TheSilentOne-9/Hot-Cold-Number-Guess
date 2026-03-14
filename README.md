# 🔥❄️ Hot & Cold Number Guessing Game
A C# number guessing console game featuring algorithmic proximity feedback and robust user input validation.

## 📌 Overview
This repository features a fully optimized version of the classic "Hot and Cold" number guessing game. Originally developed as an introductory logic project, the codebase has been significantly refactored to eliminate anti-patterns, prevent application crashes, and adhere to clean C# development standards.

## 🚀 Features
* **Proximity Feedback System:** Dynamically guides the player with "Very Hot," "Hot," "Cold," and "Very Cold" hints based on the absolute mathematical difference from the target number.
* **Crash Prevention:** Replaced outdated `int.Parse` methods with safe `int.TryParse` validations to handle non-numerical keystrokes gracefully.
* **Strict Range Validation:** Prevents players from entering numbers outside the 1-100 range without penalizing their attempt count.
* **Continuous Play:** Features a persistent game loop allowing consecutive rounds without needing to restart the application.

## 🧠 Technical Highlights
* Removed `for-loop` counter manipulation in favor of a cleaner, decoupled `while-loop` for state management.
* Utilized `Math.Abs()` for efficient proximity calculations.
* Implemented class-level `static readonly Random` generation for memory safety and true randomness.

## 💻 Installation & Usage

1. Clone the repository to your local machine.

2. Navigate to the downloaded folder and open the .sln file using Visual Studio.

3. Press F5 or click the Start button at the top menu to build and run the game.
