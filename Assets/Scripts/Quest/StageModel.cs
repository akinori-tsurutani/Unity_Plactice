using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageModel
{
    MonsterModel monsterModel = null;

    public MonsterModel Monster
    {
        get { return monsterModel; }
        set { monsterModel = value; }
    }

    public bool HasMonster()
    {
        if(monsterModel == null)
        {
            return false;
        }
        return true;
    }
}
