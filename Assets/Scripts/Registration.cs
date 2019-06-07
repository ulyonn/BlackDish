using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{

    public InputField emailField;
    public InputField userField;
    public InputField passwordField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", emailField.text);
        form.AddField("name", userField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://localhost/blackdish/register.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Usuario creado satisfactoriamente");
            UnityEngine.SceneManagement.SceneManager.LoadScene("loginEmail");
        }
        else
        {
            Debug.Log("Ocurrio un error al crear un usuario. Error #" + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (passwordField.text.Length >= 8 && passwordField.text.Length <= 16);
    }

}