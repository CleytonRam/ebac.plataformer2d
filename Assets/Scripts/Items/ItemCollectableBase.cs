using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ItemCollectableBase : MonoBehaviour {
    
    
    public string compareTag = "Player";

    [SerializeField] protected int _amount = 1;

   




    private void OnTriggerEnter2D(Collider2D collision)   {
        if (collision.transform.CompareTag(compareTag))       {
            Collect();
            

        
        }
    }

    protected virtual void Collect() {
       
        OnCollect();
        gameObject.SetActive(false);

    }

    protected virtual void OnCollect() {
    
        
    }


}
