using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour {

    public void phonecall()
    {
        Application.OpenURL("tel://2717091699");
    }

    public void googlemaps()
    {
        Application.OpenURL("https://www.google.com/maps/place/Taqueria+Playa+Tropical+Mexican+Restaurant/@49.2097245,-122.9185807,17z/data=!3m1!4b1!4m5!3m4!1s0x5485d8744b4f4365:0x59734df77df7b2a7!8m2!3d49.2097245!4d-122.916392");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
