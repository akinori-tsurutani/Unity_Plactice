using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitlePresenter : MonoBehaviour
{

    // NewGameButtonを押した時の動作関数を作成
    public void OnNewGameButton()
    {
        Debug.Log("ボタンがおされました"); //確認用
        SceneManager.LoadScene("Town"); //Scene"Town"をloadする

    }

    // ContinueButtonを押したときの動作関数を作成
    public void OnContinueButton()
    {
        Debug.Log("ボタンが押されました");//確認用
        SceneManager.LoadScene("Town"); //Scene"Town"をloadする
    }

}
