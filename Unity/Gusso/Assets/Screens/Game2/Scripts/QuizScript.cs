using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizScript : MonoBehaviour {

    static int correctAnswears = 0;

    GameObject paginaIniciar;
    GameObject paginaQuiz1;
    GameObject paginaQuiz2;
    GameObject paginaQuiz3;
    GameObject paginaQuiz4;
    GameObject paginaQuiz5;
    GameObject paginaVitoria;
    GameObject paginaErro;

    // Use this for initialization
    void Start () {
        correctAnswears = 0;

        paginaIniciar = GameObject.Find("pagina_inicio");
        paginaQuiz1 = GameObject.Find("pagina_quiz1");
        paginaQuiz2 = GameObject.Find("pagina_quiz2");
        paginaQuiz3 = GameObject.Find("pagina_quiz3");
        paginaQuiz4 = GameObject.Find("pagina_quiz4");
        paginaQuiz5 = GameObject.Find("pagina_quiz5");
        paginaVitoria = GameObject.Find("pagina_vitoria");
        paginaErro = GameObject.Find("pagina_fail");

        SetVisibility(paginaQuiz1, false);
        SetVisibility(paginaQuiz2, false);
        SetVisibility(paginaQuiz3, false);
        SetVisibility(paginaQuiz4, false);
        SetVisibility(paginaQuiz5, false);
        SetVisibility(paginaVitoria, false);
        SetVisibility(paginaErro, false);
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void btnIniciar_Click()
    {
        SetVisibility(paginaIniciar, false);
        SetVisibility(paginaQuiz1, true);
    }

    private void btnQuiz1_Click(string answear)
    {
        switch (answear)
        {
            case "quiz pergunta 1_1":
                correctAnswears++;
                break;
        }
        SetVisibility(paginaQuiz1, false);
        SetVisibility(paginaQuiz2, true);
    }

    private void btnQuiz2_Click(string answear)
    {
        switch (answear)
        {
            case "quiz pergunta 2_2":
                correctAnswears++;
                break;
        }
        SetVisibility(paginaQuiz2, false);
        SetVisibility(paginaQuiz3, true);
    }

    private void btnQuiz3_Click(string answear)
    {
        switch (answear)
        {
            case "quiz pergunta 3_3":
                correctAnswears++;
                break;
        }
        SetVisibility(paginaQuiz3, false);
        SetVisibility(paginaQuiz4, true);
    }

    private void btnQuiz4_Click(string answear)
    {
        switch (answear)
        {
            case "quiz pergunta 4_4":
                correctAnswears++;
                break;
        }
        SetVisibility(paginaQuiz4, false);
        SetVisibility(paginaQuiz5, true);
    }

    private void btnQuiz5_Click(string answear)
    {
        switch (answear)
        {
            case "quiz pergunta 5_3":
                correctAnswears++;
                break;
        }
        SetVisibility(paginaQuiz5, false);
        
        if (correctAnswears == 5)
            SetVisibility(paginaVitoria, true);
        else
            SetVisibility(paginaErro, true);
    }

    private void btnFailSim_Click()
    {
        SceneManager.LoadScene("Game2");
    }

    private void btnFailNao_Click()
    {
        SceneManager.LoadScene("Menu");
    }


    private void OnMouseDown()
    {
        if (gameObject.name == "iniciar")
            btnIniciar_Click();

        if (gameObject.name.StartsWith("quiz pergunta 1_"))
            btnQuiz1_Click(gameObject.name);
        if (gameObject.name.StartsWith("quiz pergunta 2_"))
            btnQuiz2_Click(gameObject.name);
        if (gameObject.name.StartsWith("quiz pergunta 3_"))
            btnQuiz3_Click(gameObject.name);
        if (gameObject.name.StartsWith("quiz pergunta 4_"))
            btnQuiz4_Click(gameObject.name);
        if (gameObject.name.StartsWith("quiz pergunta 5_"))
            btnQuiz5_Click(gameObject.name);

        if (gameObject.name.StartsWith("quiz fail_sim"))
            btnFailSim_Click();
        if (gameObject.name.StartsWith("quiz fail_nao"))
            btnFailNao_Click();

    }

    private void SetVisibility(GameObject control, bool enabled)
    {
        foreach (Transform child in control.transform)
        {
            child.gameObject.GetComponent<Renderer>().enabled = enabled;
            if (child.gameObject.GetComponent<Collider2D>() != null)
                child.gameObject.GetComponent<Collider2D>().enabled = enabled;
        }

        print(correctAnswears);
    }
}
