using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiel : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color baseColor;
    public Color changeColor;

    public void ColorChange(bool changecolor) 
    {
        if (changecolor == true)
        {
            rend.color = changeColor;
        }
        else 
        {
            rend.color = baseColor;
        }
    }
}
