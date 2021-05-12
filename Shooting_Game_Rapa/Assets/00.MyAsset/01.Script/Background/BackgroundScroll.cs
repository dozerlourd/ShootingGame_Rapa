using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] float speed;
    Material material;
    Vector2 texVec = Vector2.zero;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        texVec += new Vector2(0, speed * Time.deltaTime);
        material.SetTextureOffset("_MainTex", texVec);
        //material.mainTextureOffset += new Vector2(0, speed *  Time.deltaTime);
    }
}
