using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeChange : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public bool isRed;
    public bool isGreen;
    public bool isBlue;
    public enum colorState
    {
        Red
        ,Green
        ,Blue

    }
    public colorState currentColor;


    void Update()
    {
        // Check for key press and change color accordingly
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.color = Color.red;
            isRed = true;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = Color.blue;
            isBlue = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = Color.green;
            isGreen = true;
        }
        switch(isRed)
        {

        }
    }
}