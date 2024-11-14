using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDirector : MonoBehaviour
{
    public GameObject Card;
    GameObject[] card = new GameObject[5];
    void Start()
    {
        CardSet();
    }

    void Update()
    {
        
    }

    public void CardSet()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector2 cardPos = new Vector2(-5f + (2.5f * (float)i), -3f);
            card[i] = Instantiate(Card,cardPos,Quaternion.identity);
            card[i].GetComponent<CardController>().cnt = Random.Range(0,3);
        }
    }

}
