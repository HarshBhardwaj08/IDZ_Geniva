using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springScript : MonoBehaviour
{
    [SerializeField] GameObject spring;
    Animator animator;
    [SerializeField] GameObject spawner;
  
    
    void Start()
    {
      animator = spring. GetComponent<Animator>();
    }

   
    
    private void OnMouseDown()
    {
        animator.SetTrigger("TriggerSpring");
        spawner.GetComponent<Spawner>().Spawners();
    }
}
