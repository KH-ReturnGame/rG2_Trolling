using UnityEngine;
using UnityEngine.SceneManagement;

public class PushFinish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.layer == 9){
            PlayerPrefs.SetInt("o1", 1);
            PlayerPrefs.SetInt("b1", 1);
            SceneManager.LoadScene("puzzle");
        }
    }
}
