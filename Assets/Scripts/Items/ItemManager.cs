using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Timeline.TimelinePlaybackControls;


public class ItemManager : Singleton <ItemManager> {


    
  
    public int coins;
    public Text coinText;




    private void Start() {
        Reset();
    }

    private void Update()
    {
        coinText.text = coins.ToString();
    }


    private void Reset()  {
        coins = 0;
    }

    public void AddCoins(int amount = 1) {
        coins += amount;
    }

}
