using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MudarRoupas : MonoBehaviour {


    public GameObject Gabi_Boca;
    public GameObject Gabi_Blusa;
    public GameObject Gabi_Olhos;
    public GameObject Gabi_Calca;
    public GameObject Gabi_Cabelo;
    public GameObject Gabi_Sapato;
    public GameObject Gabi_Skin;
    public GameObject Hugo_Skin;


    


    public GameObject Hugo_Boca;
    public GameObject Hugo_Blusa;
    public GameObject Hugo_Olhos;
    public GameObject Hugo_Calca;
    public GameObject Hugo_Cabelo;
    public GameObject Hugo_Sapato;


    int hugo_boca_current = 0;
    int hugo_blusa_current = 0;
    int hugo_olhos_current = 0;
    int hugo_calca_current = 0;
    int hugo_cabelo_current = 0;
    int hugo_sapato_current = 0;
    int hugo_skin_current = 0;


    int gabi_skin_current = 0;
    int gabi_boca_current = 0;
    int gabi_blusa_current = 0;
    int gabi_olhos_current = 0;
    int gabi_calca_current = 0;
    int gabi_cabelo_current = 0;
    int gabi_sapato_current = 0;

    Sprite[] hugo_boca;
    Sprite[] hugo_blusa;
    Sprite[] hugo_olhos;
    Sprite[] hugo_calca;
    Sprite[] hugo_cabelo;
    Sprite[] hugo_sapato;
    Sprite[] hugo_skin;

    Sprite[] gabi_skin;
    Sprite[] gabi_boca;
    Sprite[] gabi_blusa;
    Sprite[] gabi_olhos;
    Sprite[] gabi_calca;
    Sprite[] gabi_cabelo;
    Sprite[] gabi_sapato;


    public void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;


        hugo_blusa = Resources.LoadAll<Sprite>("boy tops");
        hugo_cabelo = Resources.LoadAll<Sprite>("hair boy");

        var hugo_olhos_name = new string[] { "face and bottom_0", "face and bottom_2", "face and bottom_6", "face and bottom_8", "face and bottom_14", "face and bottom_16" };
        hugo_olhos = Resources.LoadAll<Sprite>("face and bottom").Where(x => hugo_olhos_name.Contains(x.name)).ToArray();

        var hugo_calca_name = new string[] { "face and bottom_4", "face and bottom_5", "face and bottom_18", "face and bottom_19" };
        hugo_calca = Resources.LoadAll<Sprite>("face and bottom").Where(x => hugo_calca_name.Contains(x.name)).ToArray();

        var hugo_boca_name = new string[] { "face and bottom_22", "face and bottom_23", "face and bottom_24" };
        hugo_boca = Resources.LoadAll<Sprite>("face and bottom").Where(x => hugo_boca_name.Contains(x.name)).ToArray();

        var hugo_sapato_name = new string[] { "face and bottom_10", "face and bottom_20", "face and bottom_25" };
        hugo_sapato = Resources.LoadAll<Sprite>("face and bottom").Where(x => hugo_sapato_name.Contains(x.name)).ToArray();

        var hugo_skin_name = new string[] { "body_3", "body_4", "body_5" };
        hugo_skin = Resources.LoadAll<Sprite>("body").Where(x => hugo_skin_name.Contains(x.name)).ToArray();




        gabi_cabelo = Resources.LoadAll<Sprite>("hair girl");


        var gabi_blusa_name = new string[] { "girl's clothes_0", "girl's clothes_1" , "girl's clothes_2" , "girl's clothes_4" , "girl's clothes_6" };
        gabi_blusa = Resources.LoadAll<Sprite>("girl's clothes").Where(x => gabi_blusa_name.Contains(x.name)).ToArray();

        var gabi_olhos_name = new string[] { "face and bottom_0", "face and bottom_2", "face and bottom_6", "face and bottom_8", "face and bottom_14", "face and bottom_16" };
        gabi_olhos = Resources.LoadAll<Sprite>("face and bottom").Where(x => gabi_olhos_name.Contains(x.name)).ToArray();



        var gabi_calca_name = new string[] { "face and bottom_4", "face and bottom_5", "face and bottom_18", "face and bottom_19" };
        var gabi_calca1 = Resources.LoadAll<Sprite>("face and bottom").Where(x => gabi_calca_name.Contains(x.name)).ToArray();

        var gabi_calca2_name = new string[] { "girl's clothes_3", "girl's clothes_5", "girl's clothes_7" };
        var gabi_calca_2 = Resources.LoadAll<Sprite>("girl's clothes").Where(x => gabi_calca2_name.Contains(x.name)).ToArray();

        gabi_calca = gabi_calca1.Union(gabi_calca_2).ToArray();



        var gabi_boca_name = new string[] { "face and bottom_22", "face and bottom_23", "face and bottom_24" };
        gabi_boca = Resources.LoadAll<Sprite>("face and bottom").Where(x => gabi_boca_name.Contains(x.name)).ToArray();

        var gabi_sapato_name = new string[] { "face and bottom_10", "face and bottom_20", "face and bottom_25" };
        gabi_sapato = Resources.LoadAll<Sprite>("face and bottom").Where(x => gabi_sapato_name.Contains(x.name)).ToArray();

        var gabi_skin_name = new string[] { "body_0", "body_1", "body_2" };
        gabi_skin = Resources.LoadAll<Sprite>("body").Where(x => gabi_skin_name.Contains(x.name)).ToArray();
    }


    public void HugBlusa_Click()
    {
        hugo_blusa_current++;

        if (hugo_blusa_current == hugo_blusa.Length)
            hugo_blusa_current = 0;

        Hugo_Blusa.GetComponent<SpriteRenderer>().sprite = hugo_blusa[hugo_blusa_current];
    }

    public void HugCabelo_Click()
    {
        hugo_cabelo_current++;

        if (hugo_cabelo_current == hugo_cabelo.Length)
            hugo_cabelo_current = 0;

        Hugo_Cabelo.GetComponent<SpriteRenderer>().sprite = hugo_cabelo[hugo_cabelo_current];
    }

    public void HugOlhos_Click()
    {
        hugo_olhos_current++;

        if (hugo_olhos_current == hugo_olhos.Length)
            hugo_olhos_current = 0;

        Hugo_Olhos.GetComponent<SpriteRenderer>().sprite = hugo_olhos[hugo_olhos_current];
    }

    public void HugCalca_Click()
    {
        hugo_calca_current++;

        if (hugo_calca_current == hugo_calca.Length)
            hugo_calca_current = 0;

        Hugo_Calca.GetComponent<SpriteRenderer>().sprite = hugo_calca[hugo_calca_current];
    }

    public void HugBoca_Click()
    {
        hugo_boca_current++;


        if (hugo_boca_current == hugo_boca.Length)
            hugo_boca_current = 0;

        Hugo_Boca.GetComponent<SpriteRenderer>().sprite = hugo_boca[hugo_boca_current];
    }

    public void HugSapato_Click()
    {
        hugo_sapato_current++;

        if (hugo_sapato_current == hugo_sapato.Length)
            hugo_sapato_current = 0;

        Hugo_Sapato.GetComponent<SpriteRenderer>().sprite = hugo_sapato[hugo_sapato_current];
    }

    public void HugSkin_Click()
    {
        hugo_skin_current++;

        if (hugo_skin_current == hugo_skin.Length)
            hugo_skin_current = 0;

        Hugo_Skin.GetComponent<SpriteRenderer>().sprite = hugo_skin[hugo_skin_current];
    }



    public void GabiBlusa_Click()
    {
        gabi_blusa_current++;

        if (gabi_blusa_current == gabi_blusa.Length)
            gabi_blusa_current = 0;

        Gabi_Blusa.GetComponent<SpriteRenderer>().sprite = gabi_blusa[gabi_blusa_current];
    }

    public void GabiCabelo_Click()
    {
        gabi_cabelo_current++;

        if (gabi_cabelo_current == gabi_cabelo.Length)
            gabi_cabelo_current = 0;

        Gabi_Cabelo.GetComponent<SpriteRenderer>().sprite = gabi_cabelo[gabi_cabelo_current];
    }

    public void GabiOlhos_Click()
    {
        gabi_olhos_current++;

        if (gabi_olhos_current == gabi_olhos.Length)
            gabi_olhos_current = 0;

        Gabi_Olhos.GetComponent<SpriteRenderer>().sprite = gabi_olhos[gabi_olhos_current];
    }

    public void GabiCalca_Click()
    {
        gabi_calca_current++;

        if (gabi_calca_current == gabi_calca.Length)
            gabi_calca_current = 0;

        Gabi_Calca.GetComponent<SpriteRenderer>().sprite = gabi_calca[gabi_calca_current];
    }

    public void GabiBoca_Click()
    {
        gabi_boca_current++;


        if (gabi_boca_current == gabi_boca.Length)
            gabi_boca_current = 0;

        Gabi_Boca.GetComponent<SpriteRenderer>().sprite = gabi_boca[gabi_boca_current];
    }

    public void GabiSapato_Click()
    {
        gabi_sapato_current++;

        if (gabi_sapato_current == gabi_sapato.Length)
            gabi_sapato_current = 0;

        Gabi_Sapato.GetComponent<SpriteRenderer>().sprite = gabi_sapato[gabi_sapato_current];
    }

    public void GabiSkin_Click()
    {
        gabi_skin_current++;


        if (gabi_skin_current == gabi_skin.Length)
            gabi_skin_current = 0;

        Gabi_Skin.GetComponent<SpriteRenderer>().sprite = gabi_skin[gabi_skin_current];
    }

}
