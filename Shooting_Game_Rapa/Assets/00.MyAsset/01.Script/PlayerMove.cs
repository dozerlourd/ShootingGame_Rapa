using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //W A S D 키를 입력받아 전후좌우로 이동시킨다.
    [SerializeField] float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.position += (Vector3.right * h * moveSpeed * Time.deltaTime).normalized;
        //transform.position += transform.up * moveSpeed * Time.deltaTime;
    }
}
