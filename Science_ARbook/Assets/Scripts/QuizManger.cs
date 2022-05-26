using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManger : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionText;
    public Text ScoreText;

    public GameObject QuizUI;
    public GameObject GoUI;

    int totalQuestion = 0;
    public int score;

    SceneManger sceneManger;

    private void Start()
    {
        totalQuestion = QnA.Count;
        sceneManger = new SceneManger();
        GoUI.SetActive(false);
        makeQuestion();
    }

    void makeQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionText.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("문제를 다 풀었습니다.");
            GameOver();
            currentQuestion = 0;
        }
    }

    void SetAnswers() 
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        makeQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        makeQuestion();
    }

    void GameOver()
    {
        QuizUI.SetActive(false);
        GoUI.SetActive(true);
        ScoreText.text = score + "개 맞았습니다.";
    }
}
