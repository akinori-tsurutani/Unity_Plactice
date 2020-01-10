using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPresenter : MonoBehaviour
{
    CoinView coinView;
    PlayerModel playerModel;

    // Start is called before the first frame update
    void Start()
    {
        coinView.UpdateCoin(playerModel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
