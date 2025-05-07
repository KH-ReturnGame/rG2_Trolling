using UnityEngine;

public class bomb : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D something)
    {
        if (something.gameObject.layer == 8)
        {
            Debug.Log("blue dead");
        }
        else if (something.gameObject.layer == 7)
        {
            Debug.Log("orange dead");
        }
    }
}
