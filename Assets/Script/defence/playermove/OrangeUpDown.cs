using UnityEngine;

public class OrangeUpDown : MonoBehaviour
{
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        move();
        attack();
    }

    void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0.1f, 0);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -0.1f, 0);
        }
        
    }

    void attack()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("fire!");
        }
    }
}
