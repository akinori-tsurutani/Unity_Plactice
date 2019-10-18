using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TownPresenter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTitleButton()
    {
        Debug.Log("ボタンが押されました");
        SceneManager.LoadScene("Title");
    }
    public void OnQuestButton()
    {
        Debug.Log("ボタンが押されました");
        SceneManager.LoadScene("Quest");
    }
    
}
