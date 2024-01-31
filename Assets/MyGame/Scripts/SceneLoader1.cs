using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneLoader1 : MonoBehaviour
{
  
    public void LoadNextScene()
    {
        Debug.Log("Load Scene");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

       
        SceneManager.LoadScene(0);
    }
}
