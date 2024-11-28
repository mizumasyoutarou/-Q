using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDirector2 : MonoBehaviour
{
    public GameObject Card;//プレハブ入れ
    public GameObject cardSave;//選んだカードを保存しておく
    public GameObject Player;
    public bool cardChoice;
    GameObject[] card = new GameObject[5];
    GameObject clickCard;

    void Start()
    {
        cardChoice = false;
        //最初にカードを生成するメソッドを起動する
        CardSet();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickCheck();
        }
        //選択したカードがある状態かつ、enterキーを押したら
        //カードをつかうようにするflgを有効化する
        if (clickCard != null && Input.GetKeyDown(KeyCode.Return))
        {
            cardChoice = true;
        }
        //フラグが有効化されたら、プレイヤーにカードの情報を渡すメソッドを起動する
        if (cardChoice)
        {
            GameDirector.uiFlg = true;
            cardSave.GetComponent<CardController>().CardUse();
        }
        //右クリしたら足りないカードを補充する（仮）
        if (Input.GetMouseButtonDown(1))
        {
            CardSet();
        }

    }

    public void CardSet()//カードを五枚自動生成する
    {
        for (int i = 0; i < 5; i++)
        {
            //すでにカードがあったら生成しない
            if (card[i] == null)
            {
                Vector2 cardPos = new Vector2(-5f + (2.5f * (float)i), -3f);

                card[i] = Instantiate(Card, cardPos, Quaternion.identity);
                card[i].GetComponent<CardController>().cardNumCC = Random.Range(0, 5);
                card[i].GetComponent<CardController>().effectNumCC = Random.Range(0, 3);
            }
        }
    }
    public void ClickCheck()
    {
        //クリックしたもののオブジェクトを初期化する
        clickCard = null;

        //rayを飛ばして、飛ばした先にあるゲームオブジェクトを取得する(仮)
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
        //もしオブジェクトがあったら
        if (hit2d)
        {
            clickCard = hit2d.transform.gameObject;//取得したオブジェクトを一時保存
            //保存したオブジェクトがnullじゃなければ
            if (clickCard != null)
            {
                //cardSaveに何かすでに物が入っていたら、CardControllerのcheckフラグを無効化する
                if (cardSave != null)
                {
                    cardSave.GetComponent<CardController>().check = false;
                }
                cardSave = clickCard.gameObject;//cardSaveにオブジェクトを保存
                cardSave.GetComponent<CardController>().check = true;//cardSaveのcheckフラグを有効化する
                //Debug.Log(cardSave.GetComponent<CardController>().check);
            }
            else//何も取得していなかったらcardSaveを初期化する
            {
                cardSave = null;
                Debug.Log("カード未選択です");
            }
        }
    }

}
