using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] GameObject vfx1_orange, vfx2_gravity;
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            col.gameObject.SetActive(false);
            if (GameManager.Instance.CurrScore > GameManager.Instance.BestScore)
            {
                GameManager.Instance.SetBestScore();
            }
            Instantiate(vfx2_gravity, col.transform.position, Quaternion.identity);
            Instantiate(vfx1_orange, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
