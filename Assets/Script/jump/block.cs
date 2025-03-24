using UnityEngine;

public class block : MonoBehaviour
{
    bool switched;
    public GameObject x;
    void Awake()
    {
        x = GameObject.Find("switch");
        switched = x.GetComponent<Switch>().switched;
    }

    void Update()
    {
        //asdf
    }
}
