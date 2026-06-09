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
│ │ └── (project settings)
│ ├── TextMesh Pro/
│ │ └── (TMP resources)
│ └── ...
├── Packages/
│ └── (Unity packages, created automatically)
├── ProjectSettings/
│ └── (project settings)
├── .gitignore
└── README.md

## Installation and Launch

1. Clone the repository:
git clone https://github.com/demonstalker86/mouse-toggle-counter.git

2. Open the project in Unity 6000.4.5f1

3. Open the scene Assets/Scenes/SampleScene.unity

4. Press the Play button

5. Left-click in the Game window to start the counter

Full Script Code

Assets/Scripts/MouseToggleCounter.cs

csharp
using UnityEngine;
using System.Collections;
using TMPro;

public class MouseToggleCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    private int _counterValue = 0;
    private bool _isCounting = false;

    private void Start()
    {
        if (_counterText != null)
            _counterText.text = $"Counter: {_counterValue}";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                _isCounting = false;
            }
            else
            {
                _isCounting = true;
                StartCoroutine(CountCoroutine());
            }
        }
    }

    private IEnumerator CountCoroutine()
    {
        while (_isCounting)
        {
            yield return new WaitForSeconds(0.5f);
            _counterValue++;

            if (_counterText != null)
                _counterText.text = $"Counter: {_counterValue}";
        }
    }
}

Scene Setup

1. Create UI → Text - TextMeshPro

2. Create Create Empty and name it CounterController

3. Add the MouseToggleCounter script to CounterController

4. Drag the TextMeshPro element to the _counterText field in the Inspector

Input System Settings
The project works with any Active Input Handling settings:

1. Input Manager (Old)

2. Input System Package

3. Both

Code Features

1. No extra variables

2. Coroutine stops automatically

3. No StopCoroutine() required

4. Counter value persists between starts

License
MIT

Author
demonstalker86
