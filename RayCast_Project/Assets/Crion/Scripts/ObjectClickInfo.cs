using UnityEngine;
using TMPro;

public class ObjectClickInfo : MonoBehaviour
{
    public Camera cam;
    public TMP_Text objectNameText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Only update if object has tag "Clickable"
                if (hit.transform.CompareTag("Clickable"))
                {
                    string objName = hit.transform.name;
                    Debug.Log("Clicked on: " + objName);
                    objectNameText.text = objName;
                }
                else
                {
                    Debug.Log("Clicked non-clickable: " + hit.transform.name);
                }
            }
        }
    }
}
