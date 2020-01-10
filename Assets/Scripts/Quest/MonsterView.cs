using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MonsterView : MonoBehaviour
{
    [SerializeField] Text hpText;
    Action onTap;

    public void UpdateHPText(MonsterModel monsterModel)
    {
        hpText.text = string.Format("HP:{0}/{1}", monsterModel.HP, monsterModel.MaxHP);
    }
    public void AddListenerOnTap(Action action)
    {
        onTap += action;
    }
    public void OnTap()
    {
        Debug.Log("Tap Monster");
        onTap();
    }
}
