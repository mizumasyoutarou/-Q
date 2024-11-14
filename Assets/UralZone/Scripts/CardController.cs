using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public int cnt = 0;
    public string card = "";
    GameObject CardDirector;
    CardBox Box;
    void Start()
    {
        CardDirector = GameObject.Find("CardDirector");
        Box = CardDirector.GetComponent<CardBox>();

        card = Box.CardName[cnt];
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    Destroy(gameObject);
        //}
    }
}
