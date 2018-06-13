using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour {

    public GameObject Menu;

    bool comecou = false;
	void Update () {

        if (Input.touchCount == 4 /*|| Input.GetMouseButtonDown(0)*/)
        {
            foreach (Transform child in Menu.transform)
            {
                child.gameObject.GetComponent<Renderer>().enabled = false;
            }

            comecou = true;
            gameObject.transform.position = new Vector3(-7f, gameObject.transform.position.y);
        }

        if (comecou == true)
        {
            float speed = 3.0f;
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (transform.position.x > 36f)
        {
            foreach (Transform child in Menu.transform)
            {
                child.gameObject.GetComponent<Renderer>().enabled = true;
            }
            comecou = false;
        }


    }
}
