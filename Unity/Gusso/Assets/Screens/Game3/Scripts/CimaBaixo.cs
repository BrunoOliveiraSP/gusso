using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CimaBaixo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        float holdTime = 0.8f; //or whatever
        float acumTime = 0;

        if (Input.touchCount > 0)
        {
            acumTime += Input.GetTouch(0).deltaTime;

            if (acumTime >= holdTime)
            {
                print("long");
            }

            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                acumTime = 0;
            }
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //    if (gameObject.name == "baixo")
        //    {
        //        print("baixo");
        //    }
        //    if (gameObject.name == "cima")
        //    {
        //        print("cima");
        //    }

        //    //RaycastHit hit;
        //    //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    //GameObject select = GameObject.FindWithTag("select").transform;

        //    //if (Physics.Raycast(ray, out hit, 100.0f))
        //    //{
        //    //    select.tag = "none";
        //    //    hit.collider.transform.tag = "select";
        //    //}
        //}
    }


    private void OnMouseDown()
    {
        //if (gameObject.name == "baixo")
        //{
        //    print("baixo");
        //}
        //if (gameObject.name == "cima")
        //{
        //    print("cima");
        //}
    }
}
