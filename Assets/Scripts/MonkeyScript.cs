using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonkeyScript : MonoBehaviour
{
     Animator animator;
     AudioSource audioSource;
    
   
    private void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>(); 

    }
    public void startPlaying()
    {
        audioSource.Play();
    }
    public void stoplaying()
    {
        audioSource.Stop();
        Debug.Log("Stop Play");
    }
   
    

}
