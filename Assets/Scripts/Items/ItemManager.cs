using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Timeline.TimelinePlaybackControls;


public class ItemManager : Singleton <ItemManager> {


    
  
    public int coins;
   




    private void Start() {
        Reset();

    }

  


    private void Reset()  {
        coins = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1) {
        coins += amount;
    }

    private void UpdateUI()
    {
       //coinsText.text = coins.ToString();

        UIInGameManager.Instance.UpdateTextCoins(coins.ToString());
    }
}
