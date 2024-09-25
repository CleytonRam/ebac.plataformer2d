using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UI;

public class ItemCollecatbleCoin : ItemCollectableBase {


    public ItemManager im;
    public Text coinText;


    private void Update()
    {
        coinText.text = im.coins.ToString();
    }



    protected override void OnCollect() {

        
        base.OnCollect();
        ItemManager.Instance.AddCoins();

        
    }
}
