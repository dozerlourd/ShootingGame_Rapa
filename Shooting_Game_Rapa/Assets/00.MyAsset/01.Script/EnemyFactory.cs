using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] float deleyTime = 2f;
    [SerializeField] GameObject enemyObj;
    float elapsedTime = 0;
    bool isSpawn = false;

    void Start()
    {
        deleyTime = Random.Range(2f, 3.5f);
    }

    void Update()
    {
        TimerSpawn();
        //OnceSpawn();

    }

    void TimerSpawn()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= deleyTime)
        {
            GameObject enemyClone = Instantiate(enemyObj, transform.position, Quaternion.identity);
            elapsedTime = 0;
        }
    }

    void OnceSpawn()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= deleyTime && !isSpawn)
        {
            GameObject enemyClone = Instantiate(enemyObj, transform.position, Quaternion.identity);
            elapsedTime = 0;
            isSpawn = true;
        }
    }
}
