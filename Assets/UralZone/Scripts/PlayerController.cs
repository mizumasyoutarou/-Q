using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 plPos;
    public GameObject Enemy;
    int plHp;
    const int MAX_HP = 30;
    int power;
    public int cardNumPC = 5;
    public int effectNumPC = 3;
    bool rangeFlg = false;
    bool distanceFlg = false;
    // Start is called before the first frame update
    void Start()
    {
        plHp = MAX_HP;//プレイヤーの体力を最大値にする
        power = 5;
        plPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        PatternCardJudge();//プレイヤーの行動を判断する
        if(plHp < 0)//プレイヤーのHPがなくなったら消滅
        {
            Destroy(gameObject);
        }
    }

    public void PatternCardJudge()
    {
        switch (cardNumPC)
        {
            case 0:
                Attack();
                rangeFlg = false;
                distanceFlg = false;
                break;
            case 1:
                Attack();
                rangeFlg = true;
                distanceFlg = false;
                break;
            case 2:
                Attack();
                distanceFlg = true;
                rangeFlg = false;
                break;
            case 3:
                Special();
                rangeFlg = false;
                distanceFlg = false;
                break;
            case 4:
                Defence();
                rangeFlg = false;
                distanceFlg = false;
                break;
            case 5:
                rangeFlg = false;
                distanceFlg = false;
                break;
        }
    }
    public void PatternEffectJudge()
    {
        switch (effectNumPC)
        {
            case 0:
                Move();
                break;
            case 1:
                Switch();
                break;
            case 2:
                Enemy.GetComponent<EnemyController>().KnockBack();
                break;
            case 3:
                break;
        }
    }
    public void Move()//移動の処理
    {
        
    }
    public void Attack()//攻撃の処理
    {
        if (rangeFlg)
        {
            Debug.Log("範囲攻撃準備中");
        }
        else if (distanceFlg)
        {
            Debug.Log("遠距離攻撃準備中");
        }
        else if(!rangeFlg && !distanceFlg)
        {
            Debug.Log("攻撃準備中");
        }
    }
    public void Switch()//入れ替えの処理
    {

    }
    public void Special()//特殊の処理
    {
        Debug.Log("特殊準備中");
    }
    public void Defence()//防御の処理
    {
        Debug.Log("防御準備中");
    }

}
