using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterSE : MonoBehaviour
{
    private AudioSource audioS;
    float length;

    private void ClipFinished()
    {
        Debug.Log("FINISHED!!!");
        
    }
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //左クリックされたらサウンドを再生
        if(Input.GetMouseButtonDown(0))
        {
            audioS.Play();
            length = audioS.clip.length;
            Invoke("ClipFinished", length);

        }
       
    }
    public float Length
    {
        get{ return length; }
    }
}
