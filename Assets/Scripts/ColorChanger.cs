using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;


    void Update()
    {
        // Check for key press and change color accordingly
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.color = Color.red;
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            spriteRenderer.color = Color.black;
        }
    }
}