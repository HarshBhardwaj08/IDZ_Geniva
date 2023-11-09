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

   
    private void OnMouseUp()
    {
        animator.SetBool("Clapping", false);
        audioSource.Stop();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Foods")
        {
            animator.SetBool("Clapping", true);
            audioSource.Play();
            Spawner.instance.spawnObject.SetActive(false);
        }
    }
    

}
