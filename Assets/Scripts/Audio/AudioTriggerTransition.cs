using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioTriggerTransition : MonoBehaviour
{
    public AudioSource snapshot01;
    public AudioSource snapshot02;

    public string tagToCompare = "Player";


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
            snapshot01.Play();
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
            snapshot02.Play();
        
    }
}
