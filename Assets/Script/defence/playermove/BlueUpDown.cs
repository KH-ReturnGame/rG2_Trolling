using UnityEngine;

public class BlueUpDown : MonoBehaviour
{
    Rigidbody2D rigid;
    public GameObject Bullet;
    public bool canshot = true;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        move();

    }

    void move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += new Vector3(0, 0.1f, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && canshot)
        {
            attack();
        }

    }

    void attack()
    {
        Instantiate(Bullet, this.transform.position, Quaternion.identity);

    }
}
