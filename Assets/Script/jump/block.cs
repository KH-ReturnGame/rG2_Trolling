using UnityEngine;

public class block : MonoBehaviour
{
    bool switchedx;
    public GameObject x;
    void Awake()
    {
        x = GameObject.Find("Switch");
    }

    void Update()
    {
        switchedx = x.GetComponent<Switch>().switched;

        if (!switchedx)
        {
            Destroy(gameObject, 0f);
        }
    } 
}
