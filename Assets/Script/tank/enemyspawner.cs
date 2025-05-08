using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject target;
    void Awake(){
        Instantiate(target, new Vector3(-19, 7, 0), Quaternion.identity);
        Instantiate(target, new Vector3(-11, 6.5f, 0), Quaternion.identity);
        Instantiate(target, new Vector3(19.5f, -7.5f, 0), Quaternion.identity);
        Instantiate(target, new Vector3(18, 6, 0), Quaternion.identity);
    }
}
