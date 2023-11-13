using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springScript : MonoBehaviour
{

    [SerializeField] GameObject spring;
    Animator animator;
    [SerializeField] GameObject spawner;
   
 
    bool isTimerActive;

    void Start()
    {
        animator = spring.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
    
        animator.SetTrigger("TriggerSpring");

        // Check if the timer is not active
        if (!isTimerActive)
        {
            // Activate the timer and start the coroutine
            isTimerActive = true;
            StartCoroutine(SpawnWithTimer());
        }
    }

    IEnumerator SpawnWithTimer()
    {
        yield return new WaitForSeconds(5f);

        // Spawn after the timer has elapsed
        spawner.GetComponent<Spawner>().Spawners();

        // Reset the timer and set it as inactive
      
        isTimerActive = false;
    }
}
