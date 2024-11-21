using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public int cardNumCC = 0;
    public int effectNumCC = 0;
    public string card = "";
    public string effect = "";
    public bool check;
    public bool cardFlg = default;
    GameObject Player;
    GameObject GameD;
    GameObject clickCheck;
    GameObject CardDirector;
    CardBox Box;
    int cnt = 0;
    void Start()
    {
        CardDirector = GameObject.Find("CardDirector");
        Player = GameObject.Find("Player");
        GameD = GameObject.Find("GameDirector");
        Box = CardDirector.GetComponent<CardBox>();
        clickCheck = transform.Find("ClickCheck").gameObject;

        //カードとエフェクトにカードボックスからとってきた情報を入れる」
        card = Box.CardName[cardNumCC];
        effect = Box.Effect[effectNumCC];
    }

    void Update()
    {
        if (check)//選択したときの枠を表示するかしないか
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
        
        //PlayerControllerとGameDirectorにカードの情報を送る
        if (cnt == 0)
        {
            Player.GetComponent<PlayerController>().cardNumPC = cardNumCC;
            Player.GetComponent<PlayerController>().effectNumPC = effectNumCC;
            GameD.GetComponent<GameDirector>().

            cnt ++;
        }
        Debug.Log("選択されています");
        if (Input.GetMouseButtonDown(1))//選択解除
        {
            GameDirector.uiFlg = false;
            //PlayerControllerのカードの情報を初期化する
            Player.GetComponent<PlayerController>().cardNumPC = 5;
            Player.GetComponent<PlayerController>().effectNumPC = 3;
            CardDirector.GetComponent<CardDirector>().cardChoice = false;
            cnt --;
            Debug.Log("選択が解除されました");
        }
        
    }
}
