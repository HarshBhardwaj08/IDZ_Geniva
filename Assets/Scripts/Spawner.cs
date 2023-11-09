using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    public static Spawner instance;
    public List<GameObject> gameObjects = new List<GameObject>();
    public List<Transform> locations = new List<Transform>();
    public GameObject spawnObject;

    private void Awake()
    {
        instance = this;
    }
    public void Spawners()
    {
        int randomvalue = Random.Range(0, gameObjects.Count);
        GameObject foods = gameObjects[randomvalue];
        int randomTransform = Random.Range(0,locations.Count);  
        spawnObject= Instantiate(foods,locations[randomTransform]. transform.position, locations[randomTransform].transform.rotation);
    }
}
