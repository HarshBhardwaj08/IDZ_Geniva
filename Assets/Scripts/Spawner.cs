using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    public static Spawner instance;
    public List<GameObject> gameObjects = new List<GameObject>();
    public List<Transform> locations = new List<Transform>();
    public GameObject spawnObject;
    public Sprite spr2d;
    public int randomvalue;
    private void Awake()
    {
        instance = this;
    }
    public void Spawners()
    {
        randomvalue = Random.Range(0, gameObjects.Count);
        GameObject foods = gameObjects[randomvalue];
        spr2d = foods.GetComponent<SpriteRenderer>().sprite;
        int randomTransform = Random.Range(0,locations.Count);  
        spawnObject= Instantiate(foods,locations[randomTransform]. transform.position, locations[randomTransform].transform.rotation);
    }
}
