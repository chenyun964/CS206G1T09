using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModelManager : MonoBehaviour
{
    public GameObject[] models;
    public string[] labels;
    public GameObject nextBtn;
    public GameObject preBtn;
    public Text label;
    private int count = 0;
    private Vector3 v3 = new Vector3(1, 1, 1);

    private GameObject currentModel;
 
    void Start(){
        preBtn.SetActive(false);
        currentModel = Instantiate(models[count], transform.position, transform.rotation) as GameObject;
        label.text = labels[count];
        currentModel.transform.parent = transform;
        currentModel.transform.localScale = v3;
        
    }
     
    public void PreModel(){
        nextBtn.SetActive(true);
        GameObject thisModel = Instantiate(models[--count], transform.position, transform.rotation) as GameObject;
        Destroy(currentModel);
        thisModel.transform.parent = transform;
        thisModel.transform.localScale = v3;
        label.text = labels[count];
        currentModel = thisModel;
        if(count == 0){
            preBtn.SetActive(false);
        }
    }

    public void NextModel(){
        preBtn.SetActive(true);
        GameObject thisModel = Instantiate(models[++count], transform.position, transform.rotation) as GameObject;
        Destroy(currentModel);
        thisModel.transform.parent = transform;
        thisModel.transform.localScale = v3;
        label.text = labels[count];
        currentModel = thisModel;
        if(count == models.Length - 1){
            nextBtn.SetActive(false);
        }
    }

    public void toDetail(){
        SceneManager.LoadScene("DetailScreen");
    }
}
