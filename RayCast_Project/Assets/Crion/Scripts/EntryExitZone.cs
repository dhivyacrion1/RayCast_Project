using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class EntryExitZone : MonoBehaviour
{
    public GameObject[] lightsToControl;
    public bool isEntryZone = true;
    public GameObject waterFlow;
    [SerializeField] private AudioSource waterAudio;

    public GameObject messagePanel;
    public TextMeshProUGUI messageText;
    public float messageDuration = 8f;
    public GameObject ChemistryLabPanel;
    public TextMeshProUGUI chemistryLabText;
    

    public string sceneToLoad;

    private bool hasTriggered = false;

    void Start()
    {
        if (messagePanel != null)
            messagePanel.SetActive(true);
        ChemistryLabPanel.SetActive(false);
        chemistryLabText.enabled = false;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasTriggered) return;

        if (other.CompareTag("EntryZone"))
        {
            
            ChemistryLabPanel.SetActive(true);
            chemistryLabText.enabled=true;
            chemistryLabText.text = "Welcome To Chemistry Lab";
            StartCoroutine(ShowPanel());

        }
        
        if (other.CompareTag("MainCamera"))
        {
            hasTriggered = true;


            foreach (GameObject lightObj in lightsToControl)
            {
                if (lightObj != null)
                    lightObj.SetActive(isEntryZone);
            }


            if (waterFlow != null)
            {
                waterFlow.SetActive(isEntryZone);
                if (waterAudio != null)
                {
                    if (isEntryZone)
                        waterAudio.Play();
                    else
                        waterAudio.Stop();
                }
            }



            if (!isEntryZone)
            {
                if (!string.IsNullOrEmpty(sceneToLoad))
                {
                    if (sceneToLoad == "TriggerZoneScene")
                    {
                        if (PuzzleManager.puzzleSolved)
                        {


                            if (ChemistryLabPanel != null && messageText != null)
                            {
                                ChemistryLabPanel.SetActive(true);
                                chemistryLabText.text = "you enterd to chemistry lab";
                                StartCoroutine(ShowPanel());
                            }


                            StartCoroutine(LoadSceneAfterDelay(sceneToLoad, 1f));
                        }
                        else
                        {
                            if (messagePanel != null && messageText != null)
                            {
                                messagePanel.SetActive(true);
                                messageText.text = "Solve the puzzle first!";
                                StartCoroutine(HideMessageOnly());
                            }
                        }
                    }
                    else
                    {
                        SceneManager.LoadScene(sceneToLoad);
                    }
                }
            }
        }

    }


    public IEnumerator ShowPanel()
    {
        yield return new WaitForSeconds(3f);
        ChemistryLabPanel.SetActive(false);
        chemistryLabText.enabled = false;

    }

    IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);

        if (messagePanel != null)
            messagePanel.SetActive(true);

        PuzzleManager.puzzleSolved = true;
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator HideMessageOnly()
    {
        yield return new WaitForSeconds(messageDuration);
        if (messagePanel != null)
            messagePanel.SetActive(true);
    }
}
