using UnityEngine;

public class OrangeUp : MonoBehaviour
{
    Rigidbody2D rigid;
    int movedir = 1;
    public bool movement;
    public GameObject TC;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        TC = GameObject.Find("timechecker");
        movement = TC.GetComponent<TimeChecker>().move;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0.2f * movedir, 0);
        }
    }
}
