# 🧠 Project-14: Math Game v0.2

## 📌 Overview

**Math Game v0.2** is an enhanced desktop application built with C# and Windows Forms, designed to provide an engaging and customizable platform for practicing fundamental arithmetic operations. This version builds upon its predecessor by offering refined mechanics, better UI flow, and more control over gameplay settings such as difficulty level, question type, and session length.

Whether you're a student, teacher, or just someone looking to improve your mental math skills, this game provides a fun and effective way to do so.

---

## 🎯 Main Functionality

The game guides the user through a structured flow:

1. **Start Menu (`frmMathGamePlayMenu`)**  
   The main entry point that allows the user to start a new game session.

2. **Game Information Menu (`frmMathGameInfoMenu`)**  
   Configure your game session:
   - 🔢 Number of Questions
   - 🎚️ Difficulty Level (Easy, Medium, Hard)
   - ➕ Operation Type (Addition, Subtraction, Multiplication, Division, or Mixed)

3. **Gameplay Screen (`frmMathGameStarterMenu`)**  
   Math problems are generated dynamically based on your settings. Users answer in real-time and receive immediate correctness feedback.

4. **Final Results Screen (`frmMathGameShowFinalResults`)**  
   After answering all questions, a summary is displayed showing:
   - ✅ Correct answers
   - ❌ Incorrect answers
   - 🏁 Final score and performance breakdown

---

## 🧰 Technologies Used

- **Language:** C# (.NET)
- **Framework:** .NET Framework
- **UI Framework:** Windows Forms (WinForms)

---

## 🌟 Key Features

- 🎛️ **Customizable Sessions**  
  Choose how many questions to solve, their difficulty, and which operations to practice.

- 🖥️ **User-Friendly GUI**  
  A clean and intuitive Windows Forms interface makes the game accessible to all ages.

- ⚡ **Real-Time Feedback**  
  Instant feedback after each answer helps users learn and self-correct effectively.

- 📊 **Performance Summary**  
  Review your progress with detailed final results after each game session.

- 🚫 **Input Validation**  
  Ensures required options are selected before starting and prevents invalid answers.

- 🧩 **Modular Design**  
  Separate forms for start menu, configuration, gameplay, and results improve code structure and UX flow.

---

## 🔧 Installation & Running

### 🚀 Run the Executable

1. Go to `/bin/Debug/`
2. Launch `Simple Math Game.exe`

---

### 🛠️ Build from Source

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/MustafaIbrahim990/Project-14_Math-Game-v0.2.git
