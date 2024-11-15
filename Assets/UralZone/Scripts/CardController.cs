using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public int cardNum = 0;
    public int effectNum = 0;
    public string card = "";
    public string effect = "";
    public bool check;
    GameObject clickCheck;
    GameObject CardDirector;
    CardBox Box;
    void Start()
    {
        CardDirector = GameObject.Find("CardDirector");
        Box = CardDirector.GetComponent<CardBox>();
        clickCheck = transform.Find("ClickCheck").gameObject;

        card = Box.CardName[cardNum];
        effect = Box.Effect[effectNum];
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            clickCheck.SetActive(true);
        }
        else
        {
            clickCheck.SetActive(false);
        }
    }
    public void CardUse()
    {
        
        Debug.Log("‘I‘ğ‚³‚ê‚Ä‚¢‚Ü‚·");
        if (Input.GetMouseButtonDown(1))
        {
            CardDirector.GetComponent<CardDirector>().cardChoice = false;
            Debug.Log("‘I‘ğ‚ª‰ğœ‚³‚ê‚Ü‚µ‚½");
        }
        
    }
}
