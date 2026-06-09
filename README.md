![Unity](https://img.shields.io/badge/Unity-6000.4.5f1-black?logo=unity)
![License](https://img.shields.io/badge/License-MIT-green)
![C#](https://img.shields.io/badge/C%23-Coroutines-purple)

# Mouse Toggle Counter

A simple counter for Unity controlled by mouse clicks.

## Controls

Left mouse click - Start counter
Left mouse click - Stop counter
Next click - Continue from same value

## Technologies

Unity 6000.4.5f1
C# Coroutines
TextMeshPro for text display

## Project Structure

mouse-toggle-counter/
Assets/
Scripts/
MouseToggleCounter.cs
Scenes/
SampleScene.unity
Settings/
(project settings)
TextMesh Pro/
(TMP resources)
Packages/
(Unity packages, created automatically)
ProjectSettings/
(project settings)
.gitignore
README.md

## Installation and Launch

Clone the repository:
git clone https://github.com/demonstalker86/mouse-toggle-counter.git

Open the project in Unity 6000.4.5f1

Open the scene Assets/Scenes/SampleScene.unity

Press the Play button

Left-click in the Game window to start the counter

## Full Script Code

Assets/Scripts/MouseToggleCounter.cs

using UnityEngine;
using System.Collections;
using TMPro;

public class MouseToggleCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;
    private int counterValue = 0;
    private bool isCounting = false;

    private void Start()
    {
        if (counterText != null)
            counterText.text = "Counter: " + counterValue;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isCounting)
            {
                isCounting = false;
            }
            else
            {
                isCounting = true;
                StartCoroutine(CountCoroutine());
            }
        }
    }

    private IEnumerator CountCoroutine()
    {
        while (isCounting)
        {
            yield return new WaitForSeconds(0.5f);
            counterValue++;

            if (counterText != null)
                counterText.text = "Counter: " + counterValue;
        }
    }
}

## Scene Setup

Create UI -> Text - TextMeshPro

Create Create Empty and name it CounterController

Add the MouseToggleCounter script to CounterController

Drag the TextMeshPro element to the counterText field in the Inspector

## Input System Settings

The project works with any Active Input Handling settings:

Input Manager (Old)
Input System Package
Both

## Code Features

No extra variables
Coroutine stops automatically
No StopCoroutine required
Counter value persists between starts

## License

MIT

## Author

demonstalker86

Click the mouse - the counter works!
