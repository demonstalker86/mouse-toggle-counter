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

## Project Structure

mouse-toggle-counter/
├── Assets/
│ ├── Scripts/
│ │ └── MouseToggleCounter.cs
│ ├── Scenes/
│ │ └── SampleScene.unity
│ ├── Settings/
│ ├── TextMesh Pro/
│ └── ...
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

- Create UI -> Text - TextMeshPro
- Create Empty and name it CounterController
- Add MouseToggleCounter script to CounterController
- Drag TextMeshPro to counterText field in Inspector

## Input System Settings

Works with any Active Input Handling:
- Input Manager (Old)
- Input System Package
- Both

## Code Features

- No extra variables
- Coroutine stops automatically
- No StopCoroutine required
- Counter value persists

## License

MIT

## Author

demonstalker86
