using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public QuestionData[] questions;
    public TextMeshProUGUI questionTxt;
    public Button[] optionButtons;

    int currentIndex = 0;
    private Button button;
    private Image buttonImage;
    public Color correctColor = Color.green;
    public Color wrongColor = Color.red;

    private void Start()
    {
        button = GetComponent<Button>();
        buttonImage = GetComponent<Image>();
        LoadQuestion();
        
    }

    void LoadQuestion()
    {
        if (currentIndex>=questions.Length)
        {
            Debug.Log("Sýnav Bitti..");
            DisableButtons();
            return;
        }

        QuestionData currentQuestion = questions[currentIndex];
        questionTxt.text = currentQuestion.questionTxt;

        for (int i = 0; i < optionButtons.Length; i++)
        {
            int index = i;
            optionButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = currentQuestion.options[i];
            optionButtons[i].onClick.RemoveAllListeners();
            optionButtons[i].onClick.AddListener(() => CheckAnswer(index));
        }
    }
     void CheckAnswer(int selectedIndex)
    {
        if (selectedIndex==questions[currentIndex].correctAnswerIndex)
        {
            
            Debug.Log("dogru");
        }
        else
        {
            
            Debug.Log("yanlýs");
        }
        currentIndex++;
        LoadQuestion();
    }
    void DisableButtons()
    {
        foreach (var button in optionButtons)
        {
            button.interactable = false;
        }
    }
}
