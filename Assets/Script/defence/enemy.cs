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
        color = Random.Range(1, 3); //1: orange, 2: blue
        if (color == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(255 / 255f, 106 / 255f, 0 / 255f);

        }
        else if (color == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(6 / 255f, 23 / 255f, 215 / 255f);

        }
    }

    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        this.transform.position += new Vector3(0, movedir*0.02f, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("fuck");
        if (color == 1 && other.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }

        if (color == 2 && other.gameObject.layer == 8)
        {
            Destroy(gameObject);
            Debug.Log("fucker");
        }

        if (other.gameObject.layer == 9)
        {
            Debug.Log("lose");
            Destroy(gameObject);
        }
    }
}
