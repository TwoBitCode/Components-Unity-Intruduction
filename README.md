# **Unity Game Components Project**


<img width="467" alt="image" src="https://github.com/user-attachments/assets/dbebe49e-54ee-4811-9276-205b4752708a">



## **🌐 Play the Game on itch.io**
Explore and play our game on itch.io:

➡️ [TwoBitCode itch.io Games](https://twobitcode.itch.io/components) 


## **📖 Overview**
This project is a Unity-based game development task focusing on creating a series of components that demonstrate different game-object behaviors. The components include a pendulum-like movement (Oscillator), continuous rotation (Rotator), a pulsing effect for a game-object, and the ability to hide/show a game-object using player input.

The project is divided into the following parts:

1. **🔄 Oscillator Component** - A component that moves a game object back and forth in a pendulum motion.
2. **🔁 Rotator Component** - A component that continuously rotates a game object around a specific axis.
3. **❤️ Pulsating Object** - A game object (sphere) that increases and decreases in size gradually, mimicking a heartbeat.
4. **👁️ Hide/Show Component** - A component that allows the player to toggle the visibility of a game object using a button press.

---

## **✨ Features**
## 🛠️ Components and Features

### 1. 🔄 Oscillator Component
The Oscillator moves a game object back and forth in a smooth, pendulum-like motion. The movement slows down when reaching the boundaries and speeds up as it moves back to the center, similar to a real-world pendulum. 
- 📐 Uses trigonometric functions to create a smooth oscillation effect.
- 🎯 The center of the oscillation is based on the initial position of the object in the scene.
- 🎛️ Parameters are customizable in Unity, allowing for control over the oscillation direction, speed, and amplitude.
- 
### 2. 🔁 Rotator Component
The Rotator continuously rotates a game object around a specified axis at a set speed.
- 🌀 Rotation speed and axis can be configured in Unity's Inspector.
- ⚙️ Simple and reusable component for any game object that requires continuous rotation.

### 3. ❤️ Pulsating Object (Heartbeat Effect)
A spherical game object that gradually grows and shrinks in size, simulating a pulsing or heartbeat effect.
- 📏 Uses a smooth, sinusoidal function to change the object's scale over time.
- ⏱️ The pulsing speed and scale limits are adjustable via Unity's Inspector.
- 
### 4. 👁️ Hide/Show Component
This component allows a game object to be hidden or displayed by pressing a button. It utilizes Unity's `InputAction` to manage input events.
- 👆 Toggles visibility of the game object when a specific button is pressed.
- 🛠️ Easy to assign different input keys or buttons for customization.


## **⚙️ Setup**
1. 📝 Clone the project from the GitHub repository.
2. 🎮 Open the project in Unity.
3. ▶️ Play the scene to see the demonstration of all components.
4. 🛠️ Adjust parameters for each component in the Inspector to see how different settings affect behavior.

---

## 📝 Labels and Annotations
In the scene, each game object includes descriptive text that explains the behavior being demonstrated:
- 🆕 To create text labels, an empty GameObject with a Text Mesh Pro component is used.
- 🎨 The text properties, such as size, color, and alignment, are configured to improve visibility.

---

## **🎨 Customization**
Each component includes parameters that can be adjusted directly in Unity's Inspector:
- **🔄 Oscillator**: Center position, speed, direction, and amplitude.
- **🔁 Rotator**: Axis of rotation and speed.
- **❤️ Pulsating Object**: Pulse speed and scale range.
- **👁️ Hide/Show**: Input key for toggling visibility.

---

## 📦 Installation Requirements
- **🖥️ Unity**: Ensure you have Unity installed (version 2021.3 or later recommended).
- **📦 Text Mesh Pro**: If Text Mesh Pro is not installed, go to `Window > Package Manager`, search for "Text Mesh Pro," and install it. This is required for displaying descriptive text in the scene.
---


## **🌟 Contributors**
- Vivian Umansky
- Miriam Nagar
