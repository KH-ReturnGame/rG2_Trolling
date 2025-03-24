using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMove : MonoBehaviour
{
    float speed = 10;
    float jump = 4;
    Rigidbody2D rigid;
    bool canjump;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        int layerMask = ~LayerMask.GetMask("Blue") - LayerMask.GetMask("trap");
        Debug.DrawRay(transform.position, Vector3.down, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(rigid.position, Vector3.down, 1f, layerMask);
        if (hit.collider != null)
        {
            canjump = true;
        }
        else if (hit.collider == null)
        {
            canjump = false;
        }
    }

    void FixedUpdate()
    {
        move();
        jumping();
    }

    void move()
    {

        Vector3 MoveVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveVelocity = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveVelocity = Vector3.right;
        }
        transform.position += MoveVelocity * speed * Time.deltaTime;
    }

    void jumping()
    {
        if (Input.GetKey(KeyCode.UpArrow) && canjump)
        {
            Vector2 jumpVec = new Vector2(0, jump);
            rigid.AddForce(jumpVec, ForceMode2D.Impulse);
            canjump = false;
        }
    }
}