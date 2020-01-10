using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageView : MonoBehaviour
{
    [SerializeField] GameObject monsterViewPrefab;

    public MonsterView SpawnMonster()
    {
        GameObject monster = Instantiate(monsterViewPrefab);//Prefabをオブジェクトとして生成する
        monster.transform.SetParent(transform, false);//objectの親要素を設定する（今回は自身が親）
        return monster.GetComponent<MonsterView>();
    }
}
