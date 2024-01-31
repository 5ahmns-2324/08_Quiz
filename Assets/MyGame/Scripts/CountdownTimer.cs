using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 60f; 
    public TextMeshProUGUI countdownText;
    public SceneLoader sceneLoader;

    private void Start()
    {
        UpdateCountdownText();
    }
    
    private void Update()
    {
        countdownTime -= Time.deltaTime;

       
        UpdateCountdownText();


        if (countdownTime <= 0f)
        {
 
            ScreenColorRed();


            sceneLoader.LoadNextScene();
        }
    }

    private void UpdateCountdownText()
    {

        countdownText.text = Mathf.CeilToInt(countdownTime).ToString();
    }

    private void ScreenColorRed()
    {

        Camera.main.backgroundColor = Color.red;
    }
}
