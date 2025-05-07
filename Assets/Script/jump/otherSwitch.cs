using UnityEngine;

public class otherSwitch : MonoBehaviour
{
    public GameObject Switch;
    public bool swiched;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        swiched = Switch.GetComponent<Switch>().switched;
    }
}
