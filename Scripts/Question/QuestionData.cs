using UnityEngine;
[CreateAssetMenu(fileName ="New Qestion",menuName ="Quiz/Question")]
public class QuestionData : ScriptableObject
{
    [TextArea]
    public string questionTxt;
    public string[] options = new string[4];
    public int correctAnswerIndex;
}
