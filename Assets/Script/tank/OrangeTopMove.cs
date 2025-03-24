using UnityEngine;

public class OrangeTopMove : MonoBehaviour
{
    Vector3 dir = new Vector3(0, 0, 1);

    float rotationInput = 0;
    float rotatSpeed = 10;
    Rigidbody2D rigid;
    Quaternion quaternion = Quaternion.identity;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
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

        }
    }
}
