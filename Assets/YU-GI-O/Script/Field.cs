using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject field;

    public int tate;
    public int yoko;

    void Start()
    {
        for (int x = 0; x < tate; x++) 
        {
            for (int y = 0; y < yoko; y++) 
            {
                GameObject tiel = Instantiate(field, transform);
                tiel.transform.position = new Vector3(y, x);
                if ((x + y) % 2 != 0) 
                {
                    tiel.GetComponent<SpriteRenderer>().color = Color.black;
                }
            }
        }
        transform.position = new Vector2((float)-yoko / 2+0.5f , (float)-tate / 2+2.5f);
    }

    void Update()
    {
        
    }
}
