using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.layer == 7){
            PlayerPrefs.SetInt("o4", 1);
            PlayerPrefs.SetInt("b4", 0);
            SceneManager.LoadScene("tank");
        }
        else if(other.gameObject.layer == 8){
            PlayerPrefs.SetInt("o4", 0);
            PlayerPrefs.SetInt("b4", 1);
            SceneManager.LoadScene("tank");
        }
    }
}
