using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManger quizManger;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("맞았습니다.");
            quizManger.correct();
        }
        else
        {
            Debug.Log("틀렸습니다.");
            quizManger.wrong();
        }
    }
}
