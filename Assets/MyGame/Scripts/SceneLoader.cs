using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
  
    public void LoadNextScene()
    {
        Debug.Log("Load Scene");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

       
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
