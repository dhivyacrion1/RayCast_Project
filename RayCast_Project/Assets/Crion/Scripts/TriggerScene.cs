using UnityEngine;

public class TriggerScene : MonoBehaviour
{
    public GameObject particleObject;            
    public GameObject TransitionButton;         
    public GameObject TriggerSceneInfoPanel;     

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera")) 
        {
            if (particleObject != null)
                particleObject.SetActive(true);

            if (TransitionButton != null)
                TransitionButton.SetActive(true);

            if (TriggerSceneInfoPanel != null)
                TriggerSceneInfoPanel.SetActive(true);
        }
    }
}
