using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.Landscape;
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x >= -85f)
        {
            float speed = 3.0f;
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
    }
}
