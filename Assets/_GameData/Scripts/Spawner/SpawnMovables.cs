using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovables : MonoBehaviour
{
    public List<GameObject> MovableItems = new List<GameObject>();
    private float timerValue;
    public float Timer = 3f;
    void Start()
    {
        timerValue = Timer;
    }

    void Update()
    {
        timerValue -= Time.deltaTime;
        if (timerValue <= 0)
        {
            Instantiate(MovableItems[Random.Range(0,MovableItems.Count)], new Vector3(Random.Range(-7f,7f), 3, Random.Range(-20f,0f)), Quaternion.identity);
            timerValue = Timer;
        }
    }
    
    
}
