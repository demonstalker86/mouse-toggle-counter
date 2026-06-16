using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private Counter _counter;
        
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_counter != null)
            {
                _counter.ToggleCounting();
            }
        }
    }
}