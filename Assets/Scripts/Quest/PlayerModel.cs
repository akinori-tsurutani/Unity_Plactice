using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerModel
{

    static PlayerModel Instance = null;
    
    static public PlayerModel GetInstance()
    {
        if (Instance == null)
        {
            Instance = new PlayerModel();
        }
        return Instance;
    }
    int maxHP;
    int hp;
    int at;
    int df;
    public static int coin;
    int currentStage;

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
    
    public int CurrentStage
    {
        get { return currentStage; }
    }
    public PlayerModel()
    {
        maxHP = 100;
        hp = maxHP;
        at = 5;
        df = 2;
        coin = 0;
        currentStage = 0;
    }

    public void AttackTo(MonsterModel monsterModel)
    {
        Debug.Log("attack monster");
        monsterModel.Damage(at);
    }

    public void Damage(int damage)
    {
        Debug.Log("damage player");
        hp = Mathf.Clamp(hp - (damage - df), 0, maxHP);
    }

    public void UpAttackPoint()
    {
        at++;
    }

    public void UpDefensePoint()
    {
        if(at % 2 == 0)
        {
            df++;
        }
    }

    public void GetCoin(MonsterModel monsterModel)
    {
        coin += monsterModel.Coin;
    }
    //すすむともどるボタンに対応する関数を作成
    public void NextStage()
    {
        currentStage++;

    }
    public void BackToTown()
    {
        currentStage = 0;
    }
   
}
