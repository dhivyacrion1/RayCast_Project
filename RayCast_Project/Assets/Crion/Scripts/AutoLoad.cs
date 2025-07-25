using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AutoLoad: MonoBehaviour
{
    public string SceneToLoad;
    public GameObject MR_Panel;
    public TextMeshProUGUI MR_Text;
    public GameObject NextScenePanel;
    public TextMeshProUGUI NextSceneText;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            SceneManager.LoadScene(SceneToLoad);
        }

        if (other.CompareTag("MRRay"))
        {
           
            MR_Panel.SetActive(true);
            MR_Text.enabled = true;
            MR_Text.text = "Welcome To MagicRay";
            StartCoroutine(ShowPanel());

        }

        if (other.CompareTag("NextScene")) 
        {
          
            NextScenePanel.SetActive(true);
            NextSceneText.enabled = true;
            NextSceneText.text = "Entering into chemistry Lab";
            StartCoroutine(ShowPanel());

        }



    }
    public IEnumerator ShowPanel()
    {
        yield return new WaitForSeconds(2f);
        MR_Panel.SetActive(false);
        MR_Text.enabled = false;

        NextScenePanel.SetActive(false);
        NextSceneText.enabled = false;
    }
}
