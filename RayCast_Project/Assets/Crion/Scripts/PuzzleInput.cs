using UnityEngine;
using TMPro;

public class PuzzleInput : MonoBehaviour
{
    public GameObject puzzlePanel;
    public TMP_InputField answerInput;
    public TMP_Text questionText;
    public TMP_Text feedbackText;

    void Start()
    {
        PuzzleManager.puzzleSolved = false;

       

        if (questionText != null)
            questionText.text = "What is 2 × 2?";
    }

    public void CheckAnswer()
    {
        string input = answerInput.text;

        if (string.IsNullOrWhiteSpace(input))
        {
            feedbackText.text = "Please enter a number.";
            return;
        }

        int answer;
        if (int.TryParse(input.Trim(), out answer))
        {
            if (answer == 4)
            {
                PuzzleManager.puzzleSolved = true;
                feedbackText.text = "Correct! You may go.";
                
              
            }
            else
            {
                feedbackText.text = "Incorrect. Try again.";
            }
        }
        else
        {
            feedbackText.text = "Please enter a valid number.";
        }
    }
}
