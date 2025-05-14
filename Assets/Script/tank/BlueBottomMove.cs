using UnityEngine;

public class BlueBottomMove : MonoBehaviour
{
    float movespeed = 10;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        move();
    }

    void move()
    {

        Vector3 horvel = Vector3.zero;
        Vector3 virvel = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horvel = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            horvel = Vector3.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            virvel = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            virvel = Vector3.down;
        }
        transform.position += horvel * movespeed * Time.deltaTime + virvel * movespeed * Time.deltaTime;
    }
}
