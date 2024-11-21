using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GameObject image;
    public GameObject effectBox;
    public GameObject cardName;
    public GameObject nonsetting;
    public GameObject cardAbility;
    public GameObject cardEffect;
    public GameObject cardDirector;
    public static bool uiFlg;
    void Start()
    {
        image.SetActive(false);
        effectBox.SetActive(false);
        cardName.SetActive(false);
        nonsetting.SetActive(false);
        cardAbility.SetActive(false);
        cardEffect.SetActive(false);
    }

    void Update()
    {
        if (uiFlg)
        {
            image.SetActive(true);
            effectBox.SetActive(true);
            cardName.SetActive(true);

            nonsetting.SetActive(true);
            cardAbility.SetActive(true);
            cardEffect.SetActive(true);
        }
        else
        {
            image.SetActive(false);
            effectBox.SetActive(false);
            cardName.SetActive(false);
            nonsetting.SetActive(false);
            cardAbility.SetActive(false);
            cardEffect.SetActive(false);
            
        }
    }

}
