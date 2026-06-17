using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private int _clickButtonIndex = 0;

    public event System.Action  Clicked;
        
    private void Update()
    {
        if (Input.GetMouseButtonDown(_clickButtonIndex))
        {
            Clicked?.Invoke();
        }
    }
}