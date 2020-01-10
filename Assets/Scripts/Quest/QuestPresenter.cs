using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
using UnityEngine.SceneManagement;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField] Text StageText;
    [SerializeField] PlayerStatusView playerStatusView;
    [SerializeField] StageView stageView;
    [SerializeField] GameObject menuView;

    PlayerModel playerModel;
    StageTableModel stageTableModel;

    void Start()
    {
        playerModel = PlayerModel.GetInstance(); //PlayerModelClassから作成
        stageTableModel = new StageTableModel();

        StageText.text = string.Format("STAGE : {0}", playerModel.CurrentStage);
        playerStatusView.UpdateText(playerModel);
    }

    void SetupMonster()
    {
        menuView.SetActive(false);
        //StageTableModelからMonsterModelを生成
        MonsterModel monsterModel = stageTableModel.GetMonster(playerModel.CurrentStage);
        //モンスターの描写
        MonsterView monsterView = stageView.SpawnMonster();
        monsterView.UpdateHPText(monsterModel);
        monsterView.AddListenerOnTap(() => OnTapMonster(monsterView, monsterModel));//分からん！！
    }

    void OnTapMonster(MonsterView monsterView, MonsterModel monsterModel)
    {
        Debug.Log("Presenterでの処理");
        AttackToMonster(monsterView, monsterModel);
        AttackToPlayer(monsterModel);
    }

    void AttackToMonster(MonsterView monsterView, MonsterModel monsterModel)
    {
        playerModel.AttackTo(monsterModel);
        if(monsterModel.IsDead())
        {
            //モンスターを削除()
            Destroy(monsterView.gameObject); ;
            //ATをあげる
            playerModel.UpAttackPoint();
            //DFをあげる
            playerModel.UpDefensePoint();
            //Coinの取得
            playerModel.GetCoin(monsterModel);
            //変更された攻撃力を正しく表示する
            playerStatusView.UpdateText(playerModel);
            //ボタンを出す
            menuView.SetActive(true);
            
        }
        monsterView.UpdateHPText(monsterModel);
    }


    void AttackToPlayer(MonsterModel monsterModel)
    {
        if(monsterModel.IsDead())
        {
            return;
        }
        monsterModel.AttackTo(playerModel);
        playerStatusView.UpdateText(playerModel);
    }
    public void OnNextButton()
    {
        playerModel.NextStage();
        StageText.text = string.Format("STAGE : {0}", playerModel.CurrentStage);

        //StageTableModelのログ確認
        if(stageTableModel.HasGameCleared(playerModel.CurrentStage))
        {
            Debug.Log("クリア");
            playerModel.BackToTown();
            SceneManager.LoadScene("Town");

        }
        else if(stageTableModel.IsEnemyPointAt(playerModel.CurrentStage))
        {
            Debug.Log("敵の出現");
            SetupMonster();
        }
    }



    public void OnBackButton()
    {
        playerModel.BackToTown();
        SceneManager.LoadScene("Town");
    }
}
