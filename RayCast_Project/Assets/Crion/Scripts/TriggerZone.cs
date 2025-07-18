using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public string zoneName = "Default Zone";

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered zone: " + zoneName);
        // Example: change color of an object, show UI panel, etc.
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited zone: " + zoneName);
        // Example: revert color or hide UI panel
    }
}
