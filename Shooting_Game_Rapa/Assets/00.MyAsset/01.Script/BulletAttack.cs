using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAttack : MonoBehaviour
{
    [SerializeField] GameObject vfx1_orange, vfx2_gravity;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(col.gameObject);
            GameManager.Instance.AddScore(1);
            Instantiate(vfx2_gravity, transform.position, Quaternion.identity);
            Instantiate(vfx1_orange, col.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        
    }
}
