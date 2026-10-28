using UnityEngine;
using UnityEngine.InputSystem;

public class ColorByParity : MonoBehaviour
{
    private int count = 0;

    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            count++;

            string colorName;
            if (count % 2 == 0)
            {
                GetComponent<Renderer>().material.color = Color.red;
                colorName = "red";
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.blue;
                colorName = "blue";
            }

            Debug.Log("Count: " + count + ", color: " + colorName);
        }
    }
}