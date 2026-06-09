# Mouse Toggle Counter

Простой счетчик для Unity с управлением по клику мыши.

## Управление

| Действие | Результат |
|----------|-----------|
| Левый клик мыши | Запуск счетчика |
| Левый клик мыши | Остановка счетчика |
| Повторный клик | Продолжение с того же значения |

## Технологии

- Unity 6000.4.5f1
- C# Coroutines
- TextMeshPro

## Структура проекта

mouse-toggle-counter/
├── Assets/
│ ├── Scenes/
│ │ └── SampleScene.unity
│ ├── Scripts/
│ │ └── MouseToggleCounter.cs
│ ├── Settings/
│ └── TextMeshPro/
├── Packages/
├── ProjectSettings/
└── README.md

## Установка и запуск

1. Клонируйте репозиторий
2. Откройте проект в Unity 6000.4.5f1
3. Откройте сцену Assets/Scenes/SampleScene.unity
4. Нажмите Play
5. Кликните левой кнопкой мыши

## Код скрипта

```csharp
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
                _isCounting = false;
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

1.Создайте UI -> Text - TextMeshPro
2.Создайте Create Empty -> назовите CounterController
3.Добавьте скрипт на CounterController
4.Перетащите TextMeshPro в поле _counterText

Особенности

1.Нет лишних переменных
2.Корутина останавливается автоматически
3.Значение сохраняется между запусками

Лицензия
MIT

Автор
demonstalker
