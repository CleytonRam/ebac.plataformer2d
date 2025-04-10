using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBase : MonoBehaviour {

    public Action OnKill;
    

    
    public float delayToShow = 0.8f;
    public GameManager gameManager;

    
    
    

    
    public int startlife = 10;

    public bool destroyOnKill = false;
    public float delayToKill = 0f;
    

    private int _currentLife;
    private bool _isDead = false;

    public FlashColor flashColor;



    private void Awake() {
        Init();
        if(flashColor == null) {
            flashColor = GetComponent<FlashColor>();
        }
    }

    private void Init() {
        _isDead = false;
        _currentLife = startlife;
    }

    public void Damage(int damage) {
        if (_isDead) return;

        _currentLife -= damage;

        if (_currentLife <= 0 && !_isDead) {
            Kill();
            if (CompareTag("Player"))
            {
                gameManager.GameOver();
            }
        }

     

        if (flashColor != null) {
            flashColor.Flash();
        }
    }

    private void Kill() {
        
        _isDead = true;

        if (destroyOnKill) {
            Destroy(gameObject,delayToKill);
    
        }   
       OnKill?.Invoke();
    }

    
}
