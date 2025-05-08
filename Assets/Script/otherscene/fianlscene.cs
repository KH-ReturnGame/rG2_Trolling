using UnityEngine;
using UnityEngine.SceneManagement;

public class fianlscene : MonoBehaviour
{
    public int o0, o1, o2, o3, o4, o5, b0, b1, b2, b3, b4, b5;
    public int sumo, sumb;
    void Awake(){
        o0 = PlayerPrefs.GetInt("o0");
        o1 = PlayerPrefs.GetInt("o1");
        o2 = PlayerPrefs.GetInt("o2");
        o3 = PlayerPrefs.GetInt("o3");
        o4 = PlayerPrefs.GetInt("o4");
        o5 = PlayerPrefs.GetInt("o5");
        b0 = PlayerPrefs.GetInt("b0");
        b1 = PlayerPrefs.GetInt("b1");
        b2 = PlayerPrefs.GetInt("b2");
        b3 = PlayerPrefs.GetInt("b3");
        b4 = PlayerPrefs.GetInt("b4");
        b5 = PlayerPrefs.GetInt("b5");
        sumo = o1+o2+o3+o4+o5;
        sumb = b1+b2+b3+b4+b5;
        if(sumo < sumb){
            gameObject.GetComponent<Renderer>().material.color = new Color(6 / 255f, 23 / 255f, 215 / 255f);
        }
        else if(sumo > sumb){
            gameObject.GetComponent<Renderer>().material.color = new Color( 255 / 255f, 106 / 255f, 0 / 255f);
        }
    }

    void Update(){
        if(Input.GetKey(KeyCode.Space)){
            SceneManager.LoadScene("firstscene");
        }
    }
}
