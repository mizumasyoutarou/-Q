using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDirector : MonoBehaviour
{
    public GameObject Card;//プレハブ入れ
    public GameObject cardSave;//選んだカードを保存しておく
    public bool cardChoice;
    GameObject[] card = new GameObject[5];
    GameObject clickCard;

    void Start()
    {
        cardChoice = false;
        CardSet();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickCheck();
        }
        if(clickCard != null && Input.GetKeyDown(KeyCode.Return))
        {
            cardChoice = true;
        }
        if (cardChoice)
        {
            cardSave.GetComponent<CardController>().CardUse();
        }
        if (Input.GetMouseButtonDown(1))
        {
            CardSet();
        }

    }

    public void CardSet()//カードを五枚自動生成する
    {
        for (int i = 0; i < 5; i++)
        {
            if(card[i] == null)
            {
                Vector2 cardPos = new Vector2(-5f + (2.5f * (float)i), -3f);

                card[i] = Instantiate(Card, cardPos, Quaternion.identity);
                card[i].GetComponent<CardController>().cardNum = Random.Range(0, 5);
                card[i].GetComponent<CardController>().effectNum = Random.Range(0, 3);
            }
        }
    }
    public void ClickCheck()
    {
        clickCard = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
        if (hit2d)
        {
            clickCard = hit2d.transform.gameObject;
            if (clickCard != null)
            {
                cardSave = clickCard.gameObject;
                Debug.Log("カードが選ばれています");
            }
            else
            {
                Debug.Log("カード未選択です");
            }
        }
    }

}
