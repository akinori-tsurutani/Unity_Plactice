using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStatusView : MonoBehaviour
{
    [SerializeField] Text hpText;
    [SerializeField] Text atText;
    [SerializeField] Text dfText;
    [SerializeField] Text coinText;

    // Start is called before the first frame update
    
    public void UpdateText(PlayerModel playerModel)
    {
        hpText.text = string.Format("HP:{0}/{1}", playerModel.HP, playerModel.MaxHP);
        atText.text = string.Format("AT:{0}", playerModel.AT);
        dfText.text = string.Format("DF:{0}", playerModel.DF);
        coinText.text = string.Format("Coin:{0}", playerModel.Coin);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
