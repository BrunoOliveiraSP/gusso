using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    bool venceu = false;
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
        if (cenario.transform.position.x < -85f)
        {
            if (venceu == false)
            {
                SetVisibility(paginaGame, false);
                SetVisibility(paginaErro, true);
            }
        }
    }

    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.tag);

        if (collision.gameObject.tag == "enemy")
        {
            SetVisibility(paginaGame, false);
            SetVisibility(paginaErro, true);
        }

        if (collision.gameObject.tag == "victory")
        {
            SetVisibility(paginaGame, false);
            SetVisibility(paginaVitoria, true);

            venceu = true;
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

            foreach (Transform child in GameObject.Find("obstaculos").transform)
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
