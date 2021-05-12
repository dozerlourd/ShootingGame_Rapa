using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] GameObject player;
    [SerializeField] AudioSource BGM_Manager;
    AudioSource myAudio;

    [SerializeField] AudioClip gameoverClip;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(this);

        myAudio = GetComponent<AudioSource>();
    }

    public void PlayGameOverSound()
    {
        BGM_Manager.Stop();
        myAudio.PlayOneShot(gameoverClip,0.3f);
    }
}
