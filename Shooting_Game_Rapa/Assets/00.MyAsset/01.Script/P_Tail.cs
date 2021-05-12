using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Tail : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    Vector3 dir = Vector3.zero;

    void Start()
    {

    }

    void Update()
    {
        // p = p0 + vt
        transform.position += (target.transform.position - transform.position).normalized * speed * Time.deltaTime;
    }
}
