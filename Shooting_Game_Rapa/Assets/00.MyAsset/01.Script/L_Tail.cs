using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_Tail : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, target.transform.position.x, 0.1f)
            , Mathf.Lerp(transform.position.y, target.transform.position.y, 0.1f)
            , Mathf.Lerp(transform.position.z, target.transform.position.z, 0.1f));
    }
}
