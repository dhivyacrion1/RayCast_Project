//using UnityEngine;

//public class ObjectClickInfo : MonoBehaviour
//{
//   
//    public Camera cam;
//    public InfoPanel infoPanelScript; // Reference to InfoPanel script component
//    public GameObject infoButton; // Reference to InfoButton GameObject

//    void Start()
//    {
//        if (infoButton != null)
//            infoButton.SetActive(false); // Hide InfoButton by default
//    }

//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
//            RaycastHit hit;

//            if (Physics.Raycast(ray, out hit))
//            {
//                if (hit.transform.CompareTag("Clickable"))
//                {
//                    AssetData assetData = hit.transform.GetComponent<AssetData>();

//                    if (assetData != null)
//                    {
//                        string objName = assetData.assetName;
//                        string objDescription = assetData.description;

//                        Debug.Log("Clicked on: " + objName);

//                        if (objName == "Chair") // adjust to your exact assetName spelling
//                        {
//                            if (infoButton != null)
//                                infoButton.SetActive(true); // Show InfoButton

//                            if (infoPanelScript != null)
//                                infoPanelScript.infoPanel.SetActive(false); // Hide InfoPanel initially
//                        }
//                        else
//                        {
//                            if (infoButton != null)
//                                infoButton.SetActive(false); // Hide InfoButton

//                            if (infoPanelScript != null)
//                                infoPanelScript.infoPanel.SetActive(false); // Hide InfoPanel
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
