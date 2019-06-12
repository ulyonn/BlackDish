using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FbScript : MonoBehaviour
{

    public GameObject DialogLoggedIn;
    public GameObject DialogLoggedOut;
    public GameObject DialogUsername;
    public GameObject DialogProfilePic;
    double tiempo;
    bool sesion;

    private void Start()
    {
        sesion = false;
        tiempo = 0;
    }
    private void Update()
    {
        if (sesion == true)
        {
            tiempo = Time.time;
            if (tiempo > 4)
            {
                SceneManager.LoadScene("menu");
            }
        }
    }


    private void Awake()
    {
        FB.Init(SetInit, OnHideUnity);
    }

    //Comprueba si esta la sesión iniciada y lanza un debug
    void SetInit()
    {
        if (FB.IsLoggedIn)
        {
            Debug.Log("Fb is logged in");
        }
        else
        {
            Debug.Log("You have not logged in");
        }

        DealWithFBMenus(FB.IsLoggedIn);

    }

    void OnHideUnity(bool isGameShown)
    {
        if (isGameShown)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    //
    public void FBlogin()
    {

        List<string> permissions = new List<string>();
        permissions.Add("public_profile");

        FB.LogInWithReadPermissions(permissions, AuthCallBack);
    }

    void AuthCallBack(IResult result)
    {
        if (result.Error != null)
        {
            Debug.Log(result.Error);
        }
        else
        {
            if (FB.IsLoggedIn)
            {
                var aToken = Facebook.Unity.AccessToken.CurrentAccessToken;
                Debug.Log("Session started correctly");

            }
            else
            {
                Debug.Log(result.Error);
            }

            DealWithFBMenus(FB.IsLoggedIn);

        }
    }

    void DealWithFBMenus(bool isLoggedIn)
    {
        if (isLoggedIn)
        {
            DialogLoggedIn.SetActive(true);
            DialogLoggedOut.SetActive(false);

            FB.API("/me?fields=first_name", HttpMethod.GET, DisplayUsername);
            FB.API("/me/picture?type=square&heigh=128&width=128", HttpMethod.GET, DisplayProfilePic);
            
        }
        else
        {
            DialogLoggedIn.SetActive(false);
            DialogLoggedOut.SetActive(true);
        }
    }


    //Aca muestra el primer nombre del usuario logeado 
    void DisplayUsername(IResult result)
    {
        Text UserName = DialogUsername.GetComponent<Text>();
        GlobalVariables.username = UserName;

        if (result.Error == null)
        {
            UserName.text = "Welcome, " + result.ResultDictionary["first_name"];
        }
        else
        {
            Debug.Log(result.Error);
        }
    }


    //Aca muestra la imagen de perfil del usuario logeado
    void DisplayProfilePic(IGraphResult result)
    {
        if (result.Texture != null)
        {
            Image ProfilePic = DialogProfilePic.GetComponent<Image>();
            ProfilePic.sprite = Sprite.Create(result.Texture, new Rect(0, 0, 128, 128), new Vector2());
            sesion = true;
            GlobalVariables.profilePic = ProfilePic;

        }
        else
        {

        }
    }

    public void logoutfb()
    {
        FB.LogOut();
        Debug.Log("Cerraste sesion");
        SceneManager.LoadScene("login");
    }
}
