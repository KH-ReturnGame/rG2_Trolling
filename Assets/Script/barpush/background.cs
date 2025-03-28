using UnityEngine;

public class background : MonoBehaviour
{
    public GameObject TC;
    public bool color = true;

    void Update()
    {
        TC = GameObject.Find("timechecker");
        color = TC.GetComponent<TimeChecker>().move;
        if (!color)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color( 255 / 255f, 106 / 255f, 0 / 255f);
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(6 / 255f, 23 / 255f, 215 / 255f);
        }
    }
}
