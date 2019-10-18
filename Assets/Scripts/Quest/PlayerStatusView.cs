using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStatusView : MonoBehaviour
{
    [SerializeField] Text hpText;
    [SerializeField] Text atText;

    // Start is called before the first frame update
    
    public void UpdateText(PlayerModel playerModel)
    {
        hpText.text = string.Format("HP:{0}/{1}", playerModel.HP, playerModel.MaxHP);
        atText.text = string.Format("AT:{0}", playerModel.AT);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
