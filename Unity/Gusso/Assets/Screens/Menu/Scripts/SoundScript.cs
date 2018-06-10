using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

    public static bool soundEnabled = true;

	void Start () {
	    if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().mute = !soundEnabled;
        }
	}
	
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (gameObject.name == "icone_som")
        {
            soundEnabled = !soundEnabled;

            if (GameObject.Find("som").GetComponent<AudioSource>() != null)
            {
                GameObject.Find("som").GetComponent<AudioSource>().mute = !soundEnabled;
            }
        }
    }
}
