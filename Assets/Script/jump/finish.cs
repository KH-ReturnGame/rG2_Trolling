using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D something)
    {
        if (something.gameObject.layer == 8 || something.gameObject.layer == 7)
        {
            Debug.Log("finish");
            PlayerPrefs.SetInt("o4", 1);
            PlayerPrefs.SetInt("b4", 1);
            SceneManager.LoadScene("tank");

        }
    }
}
