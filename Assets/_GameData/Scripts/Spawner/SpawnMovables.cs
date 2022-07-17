using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovables : MonoBehaviour
{
    public List<GameObject> MovableItems = new List<GameObject>();
    public float Timer = 3f;
    private float timerValue;

    void Start()
    {
        timerValue = Timer;
    }

    void Update()
    {
        if (GameManager.instance.canPlay)
        {
            timerValue -= Time.deltaTime;
            if (timerValue <= 0)
            {
                CreateNewItems();
                timerValue = Timer;

            }
        }
        
    }

    public void CreateNewItems()
    {
        Instantiate(MovableItems[Random.Range(0, MovableItems.Count)], new Vector3(Random.Range(-7f, 7f), 3, Random.Range(-20f, 0f)), Quaternion.identity);
    }
    
}
