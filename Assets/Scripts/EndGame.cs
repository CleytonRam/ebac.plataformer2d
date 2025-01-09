using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndGame : MonoBehaviour
{
    public string tagToCompare = "Player";
    public GameObject uiEndGame;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(tagToCompare))
        {
            CallEndGame();
            Pause();
           
        }
    }

 

    public void CallEndGame() 
    {
        uiEndGame.SetActive(true);
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
}
