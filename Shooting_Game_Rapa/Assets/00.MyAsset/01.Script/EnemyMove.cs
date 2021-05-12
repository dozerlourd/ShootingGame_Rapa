using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject player;
    public GameObject Player => player;

    Vector3 dir = Vector3.down;
    int random;

    void Start()
    {
        player = GameObject.Find("Player")?.gameObject;
        random = Random.Range(0, 2);
        if (random == 1)
        {
            dir = player ? (player.transform.position - transform.position).normalized : Vector3.down;
        }
    }

    void Update()
    {
        // p = p0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
}
