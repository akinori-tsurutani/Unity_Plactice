using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterModel
{

    int maxHP;
    int hp;
    int at;
    int df;
    int coin;

    
    public int MaxHP
    {
        get { return maxHP; }
    }

    public int HP
    {
        get { return hp; }
    }

    public int AT
    {
        get { return at; }
    }

    public int DF
    {
        get { return df; }
    }

    public int Coin
    {
        get { return coin; }
    }

    public MonsterModel()
    {
        maxHP = 10;
        hp = maxHP;
        at = 6;
        df = 3;
        coin = 2;
    }

    public void AttackTo(PlayerModel playerModel)
    {
        Debug.Log("attack player");
        playerModel.Damage(at);
    }

    public void Damage(int damage)
    {
        Debug.Log("damage monster");
        //hp -= damage;
        hp = Mathf.Clamp(hp - (damage - df), 0, maxHP);
    }


    public bool IsDead()
    {
        if (hp <= 0)
        {
            return true;
        }
        return false;
              
    }
}
