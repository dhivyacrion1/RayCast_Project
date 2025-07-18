using UnityEngine;

public class EntryExitZone : MonoBehaviour
{
    public GameObject[] lightsToControl;
    public bool isEntryZone = true; 

    private void OnTriggerEnter(Collider other)
    {
        
        if ( other.CompareTag("MainCamera"))
        {
            if (lightsToControl.Length == 0)
            {
                Debug.LogWarning("No lights assigned in EntryExitZone script on " + gameObject.name);
                return;
            }

            foreach (GameObject lightObj in lightsToControl)
            {
                if (lightObj != null)
                {
                    
                    lightObj.SetActive(isEntryZone);
                }
            }

            if (isEntryZone)
            {
                Debug.Log("Entered Entry Zone - Lights turned ON");
            }
            else
            {
                Debug.Log("Entered Exit Zone - Lights turned OFF");
            }
        }
    }
}
