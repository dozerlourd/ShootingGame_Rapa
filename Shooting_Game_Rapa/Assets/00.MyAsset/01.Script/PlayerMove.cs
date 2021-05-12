using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //W A S D 키를 입력받아 전후좌우로 이동시킨다.
    [SerializeField] float moveSpeed;

    void Awake()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;
        transform.position += Vector3.up * v * moveSpeed * Time.deltaTime;
        System.Console.Write(h.ToString(), v.ToString());
    }

    private void OnDisable()
    {
        SoundManager.Instance.PlayGameOverSound();
        UIManager.Instance.ActivateMenuPanel();
    }
}
