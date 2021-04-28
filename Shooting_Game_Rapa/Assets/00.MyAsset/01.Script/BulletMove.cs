using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = moveSpeed * Time.deltaTime;
        transform.position += Vector3.up * h;
    }
}
