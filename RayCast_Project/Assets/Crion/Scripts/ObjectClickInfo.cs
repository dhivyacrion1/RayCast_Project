using UnityEngine;
using TMPro;

public class ObjectClickInfo : MonoBehaviour
{
    public Camera cam;
    public TMP_Text objectNameText;

    public GameObject infoPanel; // reference to InfoPanel
    public TMP_Text descriptionText; // reference to DescriptionText inside InfoPanel
    public TMP_Text descriptionText1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Clickable"))
                {
                    string objName = hit.transform.name;
                    Debug.Log("Clicked on: " + objName);
                    objectNameText.text = objName;

                    // Optional: Update description text dynamically here
                    //descriptionText.text = "This is a detailed description for " + objName;
                }
            }
        }
    }

    public void ShowInfo()
    {
        infoPanel.SetActive(true);
    }

    public void CloseInfo()
    {
        infoPanel.SetActive(false);
    }
}
