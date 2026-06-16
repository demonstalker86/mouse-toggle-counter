using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
    public int CurrentValue {  get; private set; }
    public bool IsCounting { get; private set; }

    public System.Action<int> OnValueChanged;

    private Coroutine _countingCoroutine;

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
    }

    private void StopCounting()
    {
        IsCounting = false;

        if (_countingCoroutine != null)
        {
            StopCoroutine(_countingCoroutine);

            _countingCoroutine = null;
        }
    }

    private IEnumerator CountCoroutine()
    {
        while (IsCounting)
        {
            yield return new WaitForSeconds(0.5f);
            CurrentValue++;

            OnValueChanged?.Invoke(CurrentValue);
        }
    }    
}