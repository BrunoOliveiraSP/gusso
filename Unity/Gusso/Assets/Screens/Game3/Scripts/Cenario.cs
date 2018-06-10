using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour {

    public static bool comecou = false;


    void Start () {
        Screen.orientation = ScreenOrientation.Landscape;
        comecou = false;
	}


    void Update () {

        if (transform.position.x >= -85f && comecou == true)
        {
            float speed = 3.0f;
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
    }
}
