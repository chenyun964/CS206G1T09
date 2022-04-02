using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetailScript : MonoBehaviour
{
    public Button quizBtn;
    public Button lessonBtn;

    public Sprite active;
    public Sprite inactive;

    public GameObject quiz;
    public GameObject lesson;

    private Image imgComponent;
    // Start is called before the first frame update
    void Start(){
        quiz.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showQuiz(){
        imgComponent = lessonBtn.GetComponent<Image>();
        imgComponent.sprite = inactive;
        lesson.SetActive(false);

        imgComponent = quizBtn.GetComponent<Image>();
        imgComponent.sprite = active;
        quiz.SetActive(true);
    }

    public void showLesson(){
        imgComponent = quizBtn.GetComponent<Image>();
        imgComponent.sprite = inactive;
        quiz.SetActive(false);

        imgComponent = lessonBtn.GetComponent<Image>();
        imgComponent.sprite = active;
        lesson.SetActive(true);
    }

    public void toHome(){
         SceneManager.LoadScene("HomeScreen");
    }
}
