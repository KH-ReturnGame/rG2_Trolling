using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject bridge;
    public bool switched = false;
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {      
        if (other.gameObject.layer == LayerMask.NameToLayer("Orange") || other.gameObject.layer == 8)
        {
            switched = !switched;
        }

        if (switched)
        {
            Bridge();
        }
    }

    void Bridge()
    {
        for(int i = 0;i < 7;i++)
        {
            Instantiate(bridge, new Vector3(-14+i*4.5f, -5, 0), Quaternion.identity); 
        }
        
    }
}
