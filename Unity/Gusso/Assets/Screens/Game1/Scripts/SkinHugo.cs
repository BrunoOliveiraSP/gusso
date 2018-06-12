using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SkinHugo : MonoBehaviour {

    public GameObject Hugo_Skin;


    int hugo_skin_current = 0;
    Sprite[] hugo_skin;


    void Start () {
        var hugo_skin_name = new string[] { "body_3", "body_4", "body_5" };
        hugo_skin = Resources.LoadAll<Sprite>("body").Where(x => hugo_skin_name.Contains(x.name)).ToArray();

    }

    private void OnMouseDown()
    {
        hugo_skin_current++;

        if (hugo_skin_current == hugo_skin.Length)
            hugo_skin_current = 0;

        Hugo_Skin.GetComponent<SpriteRenderer>().sprite = hugo_skin[hugo_skin_current];
    }


}
