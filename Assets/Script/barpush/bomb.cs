using UnityEngine;
using UnityEngine.SceneManagement;

public class bomb : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D something)
    {
        if (something.gameObject.layer == 8)
        {
            Debug.Log("blue dead");
            PlayerPrefs.SetInt("o1", 0);
            PlayerPrefs.SetInt("b1", 1);
            SceneManager.LoadScene("canon");
        }
        else if (something.gameObject.layer == 7)
        {
            Debug.Log("orange dead");
            PlayerPrefs.SetInt("o1", 1);
            PlayerPrefs.SetInt("b1", 0);
            SceneManager.LoadScene("canon");
        }
    }
}
