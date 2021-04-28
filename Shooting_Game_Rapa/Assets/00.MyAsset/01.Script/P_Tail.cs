using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Tail : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    void Start()
    {
        
    }

    void Update()
    {
        // p = p0 + vt
        transform.position += (target.transform.position - transform.position) * speed * Time.deltaTime;

    }
}
