using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    float location = 1;
    void Awake()
    {
        StartCoroutine(waiting());
    }

    void FixedUpdate()
    {
        
        
    }

    IEnumerator waiting()
    {
        for(int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(enemy, new Vector3(0, 0, 0), Quaternion.identity);
        }
        
        
    }
}
