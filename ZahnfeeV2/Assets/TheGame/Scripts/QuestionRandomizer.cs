using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionRandomizer : MonoBehaviour
{
    public List<Question> myQuestionList;
    private Question currentQuestion;

    public Text question;
    public Text answerLT, answerLB, answerRT, answerRB;

    void Start ()
    {
        currentQuestion = GetSingleQuestion();
        question.text = currentQuestion.question;
        answerLT.text = currentQuestion.answers[0];
        answerLB.text = currentQuestion.answers[1];
        answerRT.text = currentQuestion.answers[2];
        answerRB.text = currentQuestion.answers[3];
    }

    private int GetRandomIndexInList (int length)
    {
        return Random.Range(0, length);
    }
	
    private Question GetSingleQuestion()
    {
        Question myQuest = null;

        if (myQuestionList.Count > 0)
        {
            int randomListIndex = GetRandomIndexInList(myQuestionList.Count);
            myQuest = myQuestionList[randomListIndex];
            myQuestionList.RemoveAt(randomListIndex);
        }
        else
        {
            myQuest = myQuestionList[0];
            myQuestionList = null;
        }

        return myQuest;
    }

}
