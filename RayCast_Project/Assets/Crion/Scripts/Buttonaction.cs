using UnityEngine;

public class Buttonaction : MonoBehaviour
{
    public GameObject TriggerSceneInfoPanel;  
    public GameObject TransitionButton;       
    public GameObject HorrorSceneInfoPanel;   

    public void OnTransitionButtonClick()
    {
        if (TriggerSceneInfoPanel != null)
            TriggerSceneInfoPanel.SetActive(false);

        if (TransitionButton != null)
            TransitionButton.SetActive(false);

        if (HorrorSceneInfoPanel != null)
            HorrorSceneInfoPanel.SetActive(true);
    }
}
