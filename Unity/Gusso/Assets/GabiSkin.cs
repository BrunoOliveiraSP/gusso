using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GabiSkin : MonoBehaviour {

    public GameObject Gabi_Skin;


    int gabi_skin_current = 0;
    Sprite[] gabi_skin;


    void Start()
    {
        var gabi_skin_name = new string[] { "body_0", "body_1", "body_2" };
        gabi_skin = Resources.LoadAll<Sprite>("body").Where(x => gabi_skin_name.Contains(x.name)).ToArray();

    }

    private void OnMouseDown()
    {
        gabi_skin_current++;

        if (gabi_skin_current == gabi_skin.Length)
            gabi_skin_current = 0;

        Gabi_Skin.GetComponent<SpriteRenderer>().sprite = gabi_skin[gabi_skin_current];
    }


}
