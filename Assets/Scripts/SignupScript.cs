using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SignupScript : MonoBehaviour
{
    public GameObject usernameObj;

    public GameObject emailObj;
    public GameObject passwordObj;

    public GameObject confirmPasswordObj;

    private string username;
    private string email;
    private string password;
    private string confirmPassword;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        username = usernameObj.GetComponent<InputField>().text;
        email = emailObj.GetComponent<InputField>().text;
        password = passwordObj.GetComponent<InputField>().text;
        confirmPassword = confirmPasswordObj.GetComponent<InputField>().text;
    }

    public void ValidateSignup(){
        if (username != "" && email != "" && (password == confirmPassword)){
            print("Signup Success");
            SceneManager.LoadScene(1);
        } else {

        }
    }

    public void toLogin(){
        SceneManager.LoadScene("LoginScreen");
    }


}
