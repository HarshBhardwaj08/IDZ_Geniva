using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PluckCards : MonoBehaviour
{
    public List<GameObject>gameObjects = new List<GameObject>();
    SpriteRenderer spriteRenderer;
    int randomValue;
    public GameObject monkey;
    Animator animator;
   

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = monkey.GetComponent<Animator>();
       
    }
    void Start()
    {
        randomValue = Random.Range(0, gameObjects.Count);
        changeSprite(randomValue);
    }
    public void changeSprite(int rand)
    {
       spriteRenderer.sprite = gameObjects[randomValue].GetComponent<SpriteRenderer>().sprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {  
       if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == spriteRenderer.sprite)
        {
            int randomValue = Random.Range(0, gameObjects.Count);
            spriteRenderer.sprite = gameObjects[randomValue].GetComponent<SpriteRenderer>().sprite;
            collision.gameObject.SetActive(false);
            animator.SetTrigger("AnimTrigger");
           
        }
      
    }

}
