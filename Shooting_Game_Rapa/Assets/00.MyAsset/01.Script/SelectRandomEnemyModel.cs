using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomEnemyModel : MonoBehaviour
{
    [SerializeField] GameObject[] models;
    //[SerializeField] GameObject model1;
    //[SerializeField] GameObject model2;
    //[SerializeField] GameObject model3;
    //[SerializeField] GameObject model4;

    void Start()
    {
        EnemyMove enemyMove = GetComponent<EnemyMove>();
        #region 배열을 모를 때
        //int randomNum = Random.Range(1, 5);

        //if(randomNum == 1) { enemyModel = model1; }
        //else if(randomNum == 2) { enemyModel = model2; }
        //else if(randomNum == 3) { enemyModel = model3; }
        //else { enemyModel = model4; }
        #endregion

        GameObject modelClone = Instantiate(models[Random.Range(0, models.Length)], transform);
        modelClone.transform.position = transform.position;
    }

    void Update()
    {
        
    }
}
