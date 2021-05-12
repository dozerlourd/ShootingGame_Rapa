using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    AudioSource audioSource;
    [SerializeField] AudioClip bangClip;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            audioSource.PlayOneShot(bangClip, 0.2f);
        }
    }
}
