using UnityEngine;
using UnityEngine.SceneManagement;
public class firstback : MonoBehaviour
{
    public bool order = true;
    void Start(){
            order = true;
            gameObject.GetComponent<Renderer>().material.color = new Color( 255 / 255f, 106 / 255f, 0 / 255f);
    }
    void Update()
    {
        
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                if(order){
                    
                    if(hit.collider.name == "1"){
                        PlayerPrefs.SetInt("o0", 1);
                        Debug.Log("fuckyou");
                        order = false;
                    }
                    else if(hit.collider.name == "2"){
                        PlayerPrefs.SetInt("o0", 2);
                        order = false;
                    }
                    else if(hit.collider.name == "3"){
                        PlayerPrefs.SetInt("o0", 3);
                        order = false;
                    }
                    else if(hit.collider.name == "4"){
                        PlayerPrefs.SetInt("o0", 4);
                        order = false;
                    }
                    else if(hit.collider.name == "5"){
                        PlayerPrefs.SetInt("o0", 5);
                        order = false;
                    }
                    gameObject.GetComponent<Renderer>().material.color = new Color(6 / 255f, 23 / 255f, 215 / 255f);
                }
                else if(!order){
                    
                    

                    if(hit.collider.name == "1"){
                        PlayerPrefs.SetInt("b0", 1);
                        Debug.Log("holyshit");
                    }
                    else if(hit.collider.name == "2"){
                        PlayerPrefs.SetInt("b0", 2);
                    }
                    else if(hit.collider.name == "3"){
                        PlayerPrefs.SetInt("b0", 3);
                    }
                    else if(hit.collider.name == "4"){
                        PlayerPrefs.SetInt("b0", 4);
                    }
                    else if(hit.collider.name == "5"){
                        PlayerPrefs.SetInt("b0", 5);
                    }
                    SceneManager.LoadScene("BarPush");
                }
            }
        }
    }
}
