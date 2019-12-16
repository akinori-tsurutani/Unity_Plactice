using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinView : MonoBehaviour
{
    [SerializeField] Text coinText;
    // Start is called before the first frame update
    public void UpdateCoin(PlayerModel playerModel)
    {
        coinText.text = string.Format("Coin : {0}", playerModel.Coin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
