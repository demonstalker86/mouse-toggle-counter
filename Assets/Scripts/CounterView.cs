using UnityEngine;
using TMPro;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        if (_counter != null)
        {
            _counter.ValueIncreased += UpdateDisplay;
        }
    }

    private void OnDisable()
    {
        if (_counter != null)
        {
            _counter.ValueIncreased -= UpdateDisplay;
        }
    }

    private void Start()
    {
        if (_counter != null && _counterText != null)
        {
            UpdateDisplay(_counter.CurrentValue);
        }
    }
        
    private void UpdateDisplay(int value)
    {
        if (_counterText != null)
        {
            _counterText.text = $"Ñ÷¸ò÷èê: {value}";
        }
    }
}