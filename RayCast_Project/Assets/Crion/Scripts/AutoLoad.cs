using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLoad: MonoBehaviour
{
    public string SceneToLoad;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}