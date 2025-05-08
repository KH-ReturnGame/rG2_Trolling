using UnityEngine;

public class OrangeTopMove : MonoBehaviour
{
    //Rigidbody2D rigid;
    Quaternion quaternion = Quaternion.identity;
    public Quaternion rotation;
    public GameObject bullet;

    void Awake()
    {
       // rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rotate();
        fire();
    }

    void rotate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 0, -1);
        }

    }

    void fire()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rotation = transform.rotation;
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
