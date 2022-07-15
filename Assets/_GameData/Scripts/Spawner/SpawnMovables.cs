using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovables : MonoBehaviour
{
    public List<GameObject> MovableItems = new List<GameObject>();
    void Start()
    {
        foreach (var item in MovableItems)
        {
            Instantiate(item, new Vector3(Random.Range(-7f,7f), 3, Random.Range(-20f,0f)), Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
