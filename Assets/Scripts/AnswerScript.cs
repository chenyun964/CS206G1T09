using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public Color startColor;

    public Sprite def;

    private void Start()
    {
        startColor = GetComponent<Image>().color;
    }

    public void Answer()
    {
        if(isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            quizManager.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            quizManager.wrong();
        }
    }

}
