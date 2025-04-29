using UnityEngine;
using System.Collections;
public class BlueBulletMove : MonoBehaviour
{
    Rigidbody2D rigid;
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        StartCoroutine(die());
    }

    void Update()
    {
        
    }

    IEnumerator die()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
    void FixedUpdate()
    {
        movement();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 11 || other.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }
    }
    void movement()
    {
        rigid.linearVelocity = new Vector2(-5f, 0);
    }
}
