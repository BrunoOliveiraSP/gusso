using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    GameObject paginaInicio;
    GameObject paginaGame;
    GameObject paginaVitoria;
    GameObject paginaErro;

    GameObject cenario;

    // Use this for initialization
    void Start()
    {
        cenario = GameObject.Find("cenario");
        paginaInicio = GameObject.Find("pagina_inicio");
        paginaGame = GameObject.Find("pagina_game");
        paginaVitoria = GameObject.Find("pagina_vitoria");
        paginaErro = GameObject.Find("pagina_erro");
    }

    // Update is called once per frame
    void Update () {
        if (cenario.transform.position.x < -75.6f)
        {
            SetVisibility(paginaGame, false);
            SetVisibility(paginaVitoria, true);
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
            foreach (Transform child in GameObject.Find("bg").transform)
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
