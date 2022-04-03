using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArManager : MonoBehaviour
{
    public GameObject[] models;
    public string[] labels;
    public GameObject nextBtn;
    public GameObject preBtn;
    public Text label;
    private int count = 0;
 
    void Start(){
        preBtn.SetActive(false);
        models[0].SetActive(true);
        label.text = labels[count];
    }
     
    public void PreModel(){
        nextBtn.SetActive(true);
        models[count].SetActive(false);
        models[--count].SetActive(true);
        label.text = labels[count];
        if(count == 0){
            preBtn.SetActive(false);
        }
    }

    public void NextModel(){
        preBtn.SetActive(true);
        models[count].SetActive(false);
        models[++count].SetActive(true);
        label.text = labels[count];
        if(count == models.Length - 1){
            nextBtn.SetActive(false);
        }
    }

    public void toDetail(){
        SceneManager.LoadScene("DetailScreen");
    }

    public void to3d(){
        SceneManager.LoadScene("LessonScreen");
    }
}
