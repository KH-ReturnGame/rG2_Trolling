using UnityEngine;
using UnityEngine.SceneManagement;

public class tankbullet : MonoBehaviour
{
    Rigidbody2D rigid;
    public GameObject orange;
    void Awake(){
        orange = GameObject.Find("Orange");
        rigid = GetComponent<Rigidbody2D>();
        rigid.AddForce(orange.transform.eulerAngles * 3, ForceMode2D.Impulse);
        Debug.Log("adioabo");
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.layer == 10){
            PlayerPrefs.SetInt("o5", 0);
            PlayerPrefs.SetInt("b5", 1);
            SceneManager.LoadScene("finalscene");
        }
        else if(other.gameObject.layer == 11){

        }
        if(other.gameObject.layer != 8){
            Destroy(gameObject);
            Debug.Log("asd");
        }
        
    }
}
