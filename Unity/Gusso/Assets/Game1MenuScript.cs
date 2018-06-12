using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game1MenuScript : MonoBehaviour {

    private void OnMouseDown()
    {
        SceneManager.LoadScene("Menu");
    }
}
