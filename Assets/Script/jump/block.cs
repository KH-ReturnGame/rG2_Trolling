using UnityEngine;

public class block : MonoBehaviour
{
    bool switchedx;
    bool switchedy;
    public GameObject x;
    public GameObject y;
    void Awake()
    {
        x = GameObject.Find("Switch");
        y = GameObject.Find("Switch (1)");
    }

    void Update()
    {
        switchedx = x.GetComponent<Switch>().switched;
        switchedy = y.GetComponent<Switch>().switched;

        if (!switchedx)
        {
            Destroy(gameObject, 0f);
        }
    } 
}
