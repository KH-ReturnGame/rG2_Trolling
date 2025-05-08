using UnityEngine;
using UnityEngine.SceneManagement;

public class fianlscene : MonoBehaviour
{
    void Awake(){
        
    }

    void Update(){
        if(Input.GetKey(KeyCode.Space)){
            SceneManager.LoadScene("firstscene");
        }
    }
}
