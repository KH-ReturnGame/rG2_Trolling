using UnityEngine;

public class otherSwitch : MonoBehaviour
{
    public Switch swich;
    public GameObject bridge;
    public bool swiched;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        swiched = swich.switched;
        swiched = !swiched;
        if (swiched)
        {
            Bridge();
        }
        swich.switched = swiched;
    }

    void Bridge()
    {
        for(int i = 0;i < 7;i++)
        {
            Instantiate(bridge, new Vector3(-14+i*4.5f, -5, 0), Quaternion.identity); 
        }
        
    }
}
