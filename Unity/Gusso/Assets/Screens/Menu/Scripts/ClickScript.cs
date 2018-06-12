using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.Landscape;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (gameObject.name == "game1")
        {
            SceneManager.LoadScene("Game1");
        }
        else if (gameObject.name == "game2")
        {
            SceneManager.LoadScene("Game2");
        }
        else if (gameObject.name == "game3")
        {
            SceneManager.LoadScene("Game3");
        }
        else if (gameObject.name == "sair")
        {
            Application.Quit();
        }
    }
}
