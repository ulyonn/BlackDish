using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePic : MonoBehaviour {
    public Image imagendeusuario;

    // Use this for initialization
    void Start () {
        imagendeusuario.sprite = GlobalVariables.profilePic.sprite;
    }
}
