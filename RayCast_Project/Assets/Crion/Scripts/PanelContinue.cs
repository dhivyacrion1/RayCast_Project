using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelContinue : MonoBehaviour
{
    public string sceneToLoad;

    public void OnContinueClicked()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
            SceneManager.LoadScene(sceneToLoad);
    }
}
