using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonkeyScript : MonoBehaviour
{
     Animator animator;
     AudioSource audioSource;
     public AudioClip new_clip;
   
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
        audioSource.clip = null;
        StartCoroutine(stopAudio());
        Debug.Log("Stop Play");
    }
   IEnumerator stopAudio()
    {
        yield return new WaitForSeconds(1.20f);
       
        audioSource.clip = new_clip;

    }
    

}
