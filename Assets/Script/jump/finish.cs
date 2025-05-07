using UnityEngine;

public class finish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D something)
    {
        if (something.gameObject.layer == 8 || something.gameObject.layer == 7)
        {
            Debug.Log("finish");
        }
    }
}
