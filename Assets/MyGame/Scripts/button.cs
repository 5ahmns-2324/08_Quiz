using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button nextQuestionButton;

    private bool isCorrectSelected = false;
    private bool isWrongSelected = false;

    void Start()
    {
        button1.onClick.AddListener(() => AntwortCheckOnClick(button1));
        button2.onClick.AddListener(() => AntwortCheckOnClick(button2));
        button3.onClick.AddListener(() => AntwortCheckOnClick(button3));

        nextQuestionButton.gameObject.SetActive(false);

        nextQuestionButton.onClick.AddListener(N�chsteFrageOnClick);
    }

    void AntwortCheckOnClick(Button geklickterButton)
    {
        if (geklickterButton.CompareTag("Richtig"))
        {
            F�rbeButton(geklickterButton, Color.green);
            isCorrectSelected = true;
        }
        else if (geklickterButton.CompareTag("Falsch"))
        {
            F�rbeButton(geklickterButton, Color.red);
            isWrongSelected = true;
            DeaktiviereAlleButtons();
        }

        AktualisiereNextButtonStatus();
    }

    void AktualisiereNextButtonStatus()
    {
        if (isCorrectSelected || isWrongSelected)
        {
            nextQuestionButton.gameObject.SetActive(true);
        }
        else
        {
            nextQuestionButton.gameObject.SetActive(false);
        }
    }

    void DeaktiviereAlleButtons()
    {
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
    }

    void N�chsteFrageOnClick()
    {
        SetzeAlleButtonsAktiv();
        nextQuestionButton.gameObject.SetActive(false);

        isCorrectSelected = false;
        isWrongSelected = false;
    }

    void SetzeAlleButtonsAktiv()
    {
        button1.interactable = true;
        button2.interactable = true;
        button3.interactable = true;
    }

    void F�rbeButton(Button button, Color farbe)
    {
        button.image.color = farbe;
    }
}
