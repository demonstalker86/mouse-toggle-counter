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
            _counterText.text = $"Ñ÷¸ò÷èê: {_counterValue}";
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
                _counterText.text = $"Ñ÷¸ò÷èê: {_counterValue}";
        }
    }    
}