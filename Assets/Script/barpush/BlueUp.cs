using UnityEngine;
using UnityEngine.SceneManagement;

public class BlueUp : MonoBehaviour
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
        TC = GameObject.Find("timechecker");
        movement = TC.GetComponent<TimeChecker>().move;
        if (movement)
        {
            movedir = 1;
        }
        else
        {
            movedir = -1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += new Vector3(0, 0.2f * movedir, 0);
        }
        
    }
}
