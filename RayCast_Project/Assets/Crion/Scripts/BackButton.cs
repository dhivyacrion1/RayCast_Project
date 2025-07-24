using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public string SceneToReturn;

    public void OnBackButtonClicked()
    {
        SceneManager.LoadScene(SceneToReturn);
    }
  
}
