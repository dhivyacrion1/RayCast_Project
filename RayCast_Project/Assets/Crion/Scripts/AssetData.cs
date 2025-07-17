using UnityEngine;

public class AssetData : MonoBehaviour
{
    public string assetName;

    [TextArea(3, 10)] // <-- This makes the description box taller (min 3 lines, max 10 lines)
    public string description;

    public Vector3 panelOffset = new Vector3(0, 2f, 0);
    public Vector3 panelRotation = Vector3.zero;
}
