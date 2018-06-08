using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game3Click : MonoBehaviour {

    GameObject paginaInicio;
    GameObject paginaGame;
    GameObject paginaVitoria;
    GameObject paginaErro;


    // Use this for initialization
    void Start () {
        paginaInicio = GameObject.Find("pagina_inicio");
        paginaGame = GameObject.Find("pagina_game");
        paginaVitoria = GameObject.Find("pagina_vitoria");
        paginaErro = GameObject.Find("pagina_erro");

        SetVisibility(paginaInicio, true);
        SetVisibility(paginaGame, false);
        SetVisibility(paginaVitoria, false);
        SetVisibility(paginaErro, false);
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnMouseDown()
    {
        if (gameObject.name == "menu")
        {
            SceneManager.LoadScene("Menu");
        }

        if (gameObject.name == "sim")
        {
            SceneManager.LoadScene("Game3   ");
        }

        if (gameObject.name == "nao")
        {
            SceneManager.LoadScene("Menu");
        }

        if (gameObject.name == "iniciar")
        {
            SetVisibility(paginaInicio, false);
            SetVisibility(paginaGame, true);
        }
    }



    private void SetVisibility(GameObject control, bool enabled)
    {
        foreach (Transform child in control.transform)
        {
            if (child.gameObject.GetComponent<Renderer>() != null)
                child.gameObject.GetComponent<Renderer>().enabled = enabled;
            if (child.gameObject.GetComponent<Collider2D>() != null)
                child.gameObject.GetComponent<Collider2D>().enabled = enabled;
        }

        if (control.name == "pagina_game")
        {
            foreach (Transform child in GameObject.Find("bg_stars").transform)
            {
                if (child.gameObject.GetComponent<Renderer>() != null)
                    child.gameObject.GetComponent<Renderer>().enabled = enabled;
                if (child.gameObject.GetComponent<Collider2D>() != null)
                    child.gameObject.GetComponent<Collider2D>().enabled = enabled;
            }

            foreach (Transform child in GameObject.Find("planetas").transform)
            {
                if (child.gameObject.GetComponent<Renderer>() != null)
                    child.gameObject.GetComponent<Renderer>().enabled = enabled;
                if (child.gameObject.GetComponent<Collider2D>() != null)
                    child.gameObject.GetComponent<Collider2D>().enabled = enabled;
            }

            if (enabled == true)
            {
                GameObject.Find("cenario").transform.position = new Vector3(1.9f, GameObject.Find("cenario").transform.position.y);
            }
        }
    }
}
