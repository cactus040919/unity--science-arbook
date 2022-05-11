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
            Debug.Log("�¾ҽ��ϴ�.");
            quizManger.correct();
        }
        else
        {
            Debug.Log("Ʋ�Ƚ��ϴ�.");
            quizManger.wrong();
        }
    }
}
