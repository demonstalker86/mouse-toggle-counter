![Unity](https://img.shields.io/badge/Unity-6000.4.5f1-black?logo=unity)
![License](https://img.shields.io/badge/License-MIT-green)
![C#](https://img.shields.io/badge/C%23-Coroutines-purple)

# Mouse Toggle Counter

A simple counter for Unity controlled by mouse clicks.

## Controls

| Action | Result |
|--------|--------|
| Left mouse click | Start counter |
| Left mouse click | Stop counter |
| Next click | Continue from same value |

## Technologies

- Unity 6000.4.5f1
- C# Coroutines
- TextMeshPro for text display
- Event-driven architecture

## Architecture

The project follows separation of concerns with three main components:

- **InputReader** - Detects input (configurable button index) and triggers events
- **Counter** - Manages counting logic, coroutine, and emits events
- **CounterView** - Updates UI display based on counter events

## Project Structure

mouse-toggle-counter/
├── Assets/
│ ├── Scripts/
│ │ ├── InputReader.cs
│ │ ├── Counter.cs
│ │ └── CounterView.cs
│ ├── Scenes/
│ │ └── SampleScene.unity
│ ├── Settings/
│ └── TextMesh Pro/
├── Packages/
├── ProjectSettings/
├── .gitignore
└── README.md


## Installation and Launch

1. Clone the repository:

git clone https://github.com/demonstalker86/mouse-toggle-counter.git

2. Open the project in Unity 6000.4.5f1

3. Open the scene Assets/Scenes/SampleScene.unity

4. Press the Play button

5. Left-click in the Game window to start the counter

## Scene Setup

1. Create **UI → Text - TextMeshPro**

2. Create an empty GameObject and name it `CounterSystem`

3. Add `InputReader` and `Counter` scripts to `CounterSystem`

4. In `Counter` component, drag the `CounterSystem` object to the `Input Reader` field

5. Create another empty GameObject and name it `CounterViewObject`

6. Add `CounterView` script to `CounterViewObject`

7. In `CounterView`, drag the TextMeshPro element to the `Counter Text` field

8. In `CounterView`, drag the `CounterSystem` object to the `Counter` field

## Input System Settings

The project works with any `Active Input Handling` settings:

- Input Manager (Old)
- Input System Package
- Both

## Code Features

- No extra variables
- Coroutine stops automatically
- Event-driven communication
- Clean separation of concerns
- Configurable input button
- Configurable increment delay
- Counter value persists between starts

## License

MIT

## Author

demonstalker86
