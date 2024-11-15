using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 plPos;
    int plHp;
    const int MAX_HP = 30;
    int power;
    // Start is called before the first frame update
    void Start()
    {
        plHp = MAX_HP;
        power = 5;
        plPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(plHp < 0)
        {
            Destroy(gameObject);
        }
    }

    public void Move()
    {
        
    }
    public void Attack()
    {

    }
    public void Switch()
    {

    }
    public void Special()
    {

    }
    public void Defence()
    {

    }

}
