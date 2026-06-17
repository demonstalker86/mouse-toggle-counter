using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private float _incrementDelay = 0.5f;

    private Coroutine _countingCoroutine;
    private WaitForSeconds _delay;

    public event System.Action<int> ValueIncreased;      
    public event System.Action<bool> CountingToggled;    

    public int CurrentValue { get; private set; }
    public bool IsCounting { get; private set; }

    private void Awake()
    {
        _delay = new WaitForSeconds(_incrementDelay);
    }

    private void OnEnable()
    {
        if (_inputReader != null)
        {
            _inputReader.Clicked += ToggleCounting;
        }
    }

    private void OnDisable()
    {
        if (_inputReader != null)
        {
            _inputReader.Clicked -= ToggleCounting;
        }
    }

    public void ToggleCounting()
    {
        if (IsCounting)
        {
            StopCounting();
        }
        else
        {
            StartCounting();
        }
    }

    private void StartCounting()
    {
        IsCounting = true;

        _countingCoroutine = StartCoroutine(CountCoroutine());

        CountingToggled?.Invoke(true);
    }

    private void StopCounting()
    {
        IsCounting = false;

        if (_countingCoroutine != null)
        {
            StopCoroutine(_countingCoroutine);

            _countingCoroutine = null;
        }

        CountingToggled?.Invoke(false);
    }

    private IEnumerator CountCoroutine()
    {
        while (IsCounting)
        {
            yield return _delay;
            CurrentValue++;

            ValueIncreased?.Invoke(CurrentValue);  
        }
    }
}