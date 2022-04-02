using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginScript:MonoBehaviour
{
    
    public GameObject username;
    public GameObject password;

    private string Username;
    private string Password; 

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }

    public void ValidateLogin(){
        if (Username != "" && Password != "") {
            print("Login Success");
            SceneManager.LoadScene(1);
        } else {

        }
    }

    public void toRegister(){
        SceneManager.LoadScene("SignupScreen");
    }
}
