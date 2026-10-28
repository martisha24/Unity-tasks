using UnityEngine;
using UnityEngine.InputSystem;

public class PressCounter : MonoBehaviour
{
    private int count = 0;

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            count++;
            Debug.Log("Press count: " + count);

            if (count == 5)
            {
                Debug.Log("Five presses reached!");
            }
        }
    }
}