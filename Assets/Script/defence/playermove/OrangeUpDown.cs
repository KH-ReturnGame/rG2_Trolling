using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OrangeUpDown : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0.1f, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.D) && canshot)
        {
            attack();
            canshot = false;
            StartCoroutine(Waiting());
        }

    }

    void attack()
    {
        Instantiate(Bullet, this.transform.position, Quaternion.identity);

    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(0.5f);
        canshot = true;
    }

    void OnTriggerEnter2D(Collider2D something)
    {
        if (something.gameObject.layer == 8)
        {
            Debug.Log("orange dead");
            PlayerPrefs.SetInt("o3", 0);
            PlayerPrefs.SetInt("b3", 1);
            SceneManager.LoadScene("jump");
        }
    }
}
