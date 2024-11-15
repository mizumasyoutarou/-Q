using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Vector2 enPos;
    int enHp;
    const int MAX_HP = 30;
    int power;
    // Start is called before the first frame update
    void Start()
    {
        enHp = MAX_HP;
        power = 5;
        enPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (enHp < 0)
        {
            Destroy(gameObject);
        }
    }
}
