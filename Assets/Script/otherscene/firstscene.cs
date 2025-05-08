using UnityEngine;

public class firstscene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 좌클릭
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("클릭된 오브젝트: " + hit.collider.name);
            }
        }
    }
}
