using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody2D rigid;
    float movedir = 1;
    float color = 1;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        movedir = Random.Range(-2, 1);
        if (movedir == 0)
        {
            movedir = 1;
        }
        else if(movedir == -2)
        {
            movedir = -1;
        }
        color = Random.Range(1, 2); //1: orange, 2: blue
    }

    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        this.transform.position += new Vector3(0, movedir*0.02f, 0);
    }
}
