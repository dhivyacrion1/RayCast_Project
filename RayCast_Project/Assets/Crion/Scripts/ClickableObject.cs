using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public InfoPanel panelManager;

    void OnMouseDown()
    {
        if (panelManager != null)
        {
            AssetData data = GetComponent<AssetData>();
            if (data != null)
            {
                panelManager.ShowInfoPanel(data.assetName, data.description, transform);
                Debug.Log("Clicked object: " + data.assetName);
            }
        }
    }
}
