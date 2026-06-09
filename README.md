# Mouse Toggle Counter

Счетчик переключений мыши. Простой счетчик для Unity с управлением мышью.

## Управление

| Действие | Результат |
|----------|-----------|
| Левый клик мыши | Запуск счетчика |
| Левый клик мыши | Остановка счетчика |
| Повторный клик | Продолжение с того же значения |

## Технологии

- Unity 6000.4.5f1
- Корутины на C#
- TextMeshPro для отображения текста

## Структура проекта

mouse-toggle-counter/
├── Assets/
│ ├── Scripts/
│ │ └── MouseToggleCounter.cs
│ ├── Scenes/
│ │ └── SampleScene.unity
│ ├── Settings/
│ │ └── (настройки проекта)
│ ├── TextMesh Pro/
│ │ └── (ресурсы TMP)
│ └── ...
├── Packages/
│ └── (пакеты Unity, создаются автоматически)
├── ProjectSettings/
│ └── (настройки проекта)
├── .gitignore
└── README.md


## Установка и запуск

1. Клонируйте репозиторий:
```bash
git clone https://github.com/demonstalker86/mouse-toggle-counter.git
Откройте проект в Unity 6000.4.5f1

Откройте сцену Assets/Scenes/SampleScene.unity

Нажмите кнопку Play

Кликните левой кнопкой мыши в окне Game для запуска счетчика

Полный код скрипта
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
            _counterText.text = $"Счётчик: {_counterValue}";
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
                _counterText.text = $"Счётчик: {_counterValue}";
        }
    }
}

Настройка сцены
Создайте UI → Text - TextMeshPro

Создайте Create Empty и назовите CounterController

Добавьте скрипт MouseToggleCounter на CounterController

Перетащите TextMeshPro в поле _counterText в инспекторе

Настройки Input System
Проект работает с любыми настройками Active Input Handling:

Input Manager (Old)

Input System Package

Both

Особенности кода
Нет лишних переменных

Корутина останавливается автоматически

Не требуется StopCoroutine()

Значение счетчика сохраняется между запусками

Лицензия
MIT

Автор
demonstalker86
