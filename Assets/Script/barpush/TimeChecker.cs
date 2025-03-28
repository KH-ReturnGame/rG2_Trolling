using UnityEngine;

public class TimeChecker : MonoBehaviour
{
    public bool move = true;
    void Awake()
    {
        Invoke("Orange", 0.1f);
    }

    void Orange()
    {
        move = false;
        Invoke("Blue", Random.Range(1f, 3f));
    }

    void Blue()
    {
        move = true;
        Invoke("Orange", Random.Range(1f, 3f));
    }
}
