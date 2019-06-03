using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void sceneMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void sceneTop()
    {
        SceneManager.LoadScene(2);
    }

    public void scenePromo()
    {
        SceneManager.LoadScene(3);
    }

    public void sceneCat()
    {
        SceneManager.LoadScene(4);
    }
}
