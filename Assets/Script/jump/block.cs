using UnityEngine;

public class block : MonoBehaviour
{
    bool switched;
    public GameObject x;
    void Awake()
    {
        x = GameObject.Find("Switch");
        
    }

    void Update()
    {
        switched = x.GetComponent<Switch>().switched;
        if (!switched)
        {
            Destroy(gameObject, 0f);
        }
    } 
}
