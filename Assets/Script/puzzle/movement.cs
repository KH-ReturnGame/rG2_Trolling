using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    Rigidbody2D rigid;
    public float speed = 0.25f;
    void Awawke()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.layer == 9){
            PlayerPrefs.SetInt("O2", 0);
            PlayerPrefs.SetInt("b2", 0);
            SceneManager.LoadScene("defence");
        }
        else if(other.gameObject.layer == 10){
            PlayerPrefs.SetInt("O2", 1);
            PlayerPrefs.SetInt("b2", 1);
            SceneManager.LoadScene("defence");
        }
    }

    void FixedUpdate(){
        Omove();
        Bmove();
    }

    void Omove()
    {
        Vector3 MoveVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            MoveVelocity = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            MoveVelocity = Vector3.right;
        }
        transform.position += MoveVelocity * speed * Time.deltaTime * 0.5f;
    }

    void Bmove()
    {
        Vector3 MoveVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveVelocity = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveVelocity = Vector3.down;
        }
        transform.position += MoveVelocity * speed * Time.deltaTime * 0.5f;
    }
}
