using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this object will handle most of the gameflow, including touching events

public class GameFlowManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        getMouseEvent();
	}

    void getMouseEvent()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.gameObject.CompareTag("SoundCube"))
                {
                    hit.collider.gameObject.GetComponent<CubeBehavior>().cubeTouched();
                }
            }
        }
    }
}

