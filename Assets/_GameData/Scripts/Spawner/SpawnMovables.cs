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
            var movableItem = Instantiate(MovableItems[Random.Range(0,MovableItems.Count)], new Vector3(Random.Range(-7f,7f), 3, Random.Range(-20f,0f)), Quaternion.identity);
            if(movableItem.gameObject == MovableItems[3].gameObject)
            {
                movableItem.transform.rotation = Quaternion.Euler(-90, 0, 0);
            }
            else
            {
                movableItem.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            timerValue = Timer;
        }
    }
    
    
}
