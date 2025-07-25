using System.Collections;
using TMPro;
using UnityEngine;

public class TriggerScene : MonoBehaviour
{
    public GameObject particleObject;            
    public GameObject TransitionButton;         
    public GameObject TriggerSceneInfoPanel;
    public GameObject MR_Starting_Panel;
    public TextMeshProUGUI MR_Starting_Text;

    public void Start()
    {
        MR_Starting_Panel.SetActive(false);
        MR_Starting_Text.enabled = false;
    }

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
        if (other.CompareTag("MRZone"))
        {
            Debug.Log("MGRay");
            MR_Starting_Panel.SetActive(true);
            MR_Starting_Text.enabled = true;
            MR_Starting_Text.text = "Welcome To MagicRay";
            StartCoroutine(ShowPanel());

        }

        

    }
    public IEnumerator ShowPanel()
    {
        yield return new WaitForSeconds(2f);
        MR_Starting_Panel.SetActive(false);
        MR_Starting_Text.enabled = false;

    }
}
