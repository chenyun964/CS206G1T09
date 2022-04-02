using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginScript:MonoBehaviour
{
    
    public GameObject username;
    public GameObject password;
    public GameObject login;

    public Button btnLogin; 

    private string Username;
    private string Password; 

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        
    }

    // Update is called once per frame
    void Update()
    {
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;

        btnLogin = login.GetComponent<Button>();
        btnLogin.onClick.AddListener(ValidateLogin);
    }


    private void ValidateLogin()
    {
        if (Username != "" && Password != "")
        {
            print("Login Success");
            SceneManager.LoadScene(1);
        } else
        {

        }
    }
}
