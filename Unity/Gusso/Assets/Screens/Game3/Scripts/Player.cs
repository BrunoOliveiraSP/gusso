using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    bool venceu = false;

    AudioSource explosion;
    GameObject paginaVitoria;
    GameObject paginaGame;
    GameObject paginaErro;
    GameObject cenario;
    GameObject player;


    void Start()
    {
        player = gameObject;
        cenario = GameObject.Find("cenario");
        paginaGame = GameObject.Find("pagina_game");
        paginaErro = GameObject.Find("pagina_erro");
        paginaVitoria = GameObject.Find("pagina_vitoria");
        explosion = GameObject.Find("explosao").GetComponent<AudioSource>();
    }


    void Update () {

        /* 
         * Termina o Jogo se o Cenário acabar
         * 
         */
        if (cenario.transform.position.x < -85f)
        {
            if (venceu == false)
            {
                SetVisibility(paginaGame, false);
                SetVisibility(paginaErro, true);
            }
        }

        /* 
         * Evento de Segurar para 'Ir para Cima' e 'Ir para Baixo'
         * 
         */
        if (Input.touchCount > 0 &&
            (Input.GetTouch(0).phase == TouchPhase.Began ||
             Input.GetTouch(0).phase == TouchPhase.Stationary))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);

            if (hit.collider != null)
            {
                float speed = 5.0f;

                if (hit.collider.tag == "cima")
                {
                    player.transform.Translate(Vector3.up * speed * Time.deltaTime);
                    if (player.transform.localPosition.y > 6.8f)
                        player.transform.localPosition = new Vector3(player.transform.localPosition.x, 6.8f);
                }

                if (hit.collider.tag == "baixo")
                {
                    player.transform.Translate(Vector3.down * speed * Time.deltaTime);
                    if (player.transform.localPosition.y < -2f)
                        player.transform.localPosition = new Vector3(player.transform.localPosition.x, -2f);
                }
            }
        }
    }

    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            explosion.Play();
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
