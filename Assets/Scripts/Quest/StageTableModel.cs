using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTableModel
{

    const int MaxStageCount = 10;
    List<StageModel> stageModelList;
    List<bool> enemyPoint;

    public StageTableModel()
    {
        stageModelList = new List<StageModel>();

        //一旦すべてのステージで敵が出ないようにする
        for(int i=0; i < MaxStageCount; i++)
        {
            stageModelList.Add(new StageModel());
        }

        //敵が出るステージを設定する
        stageModelList[3].Monster = new MonsterModel();
        stageModelList[5].Monster = new MonsterModel();
        stageModelList[8].Monster = new MonsterModel();
    }

    //プレイヤーの場所で敵が出現するかどうか判定する
    public bool IsEnemyPointAt(int currentStage)
    {
        return stageModelList[currentStage].HasMonster();

    }

    //プレイヤーがゲームをクリアしたかどうか判定する
    public bool HasGameCleared(int currentStage)
    {
        if(stageModelList.Count <= currentStage)
        {
            return true;
        }
        return false;
    }
    public MonsterModel GetMonster(int currentStage)
    {
        return stageModelList[currentStage].Monster;
    }
}
